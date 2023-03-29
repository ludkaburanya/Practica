using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using z1.Interfaces;
using z1.Models;

namespace z1.Share
{
    internal class XmlDocumentWorker:IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker (ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }

        public void Add(Books books)
        {
            var xRoot = _document.DocumentElement;

            XmlElement booksElem = _document.CreateElement("book");
            XmlAttribute nameAttribute = _document.CreateAttribute("name");
            XmlText xmlText = _document.CreateTextNode(books.Name);
            nameAttribute.AppendChild(xmlText);

            booksElem.AppendChild(booksElem);

            XmlElement authorElem = _document.CreateElement("author");
            XmlText authorText = _document.CreateTextNode(books.Author);
            
            authorElem.AppendChild(authorElem);

            XmlElement yearElem = _document.CreateElement("year");
            XmlText yearText = _document.CreateTextNode(books.Year.ToString());
            authorElem.AppendChild(yearElem);

            booksElem.AppendChild(yearElem);

            xRoot.AppendChild(booksElem);
            _document.Save(_xmlFilePath);
        }
        public List<Books> GetAll()
        {
            List<Books> bookses = new List<Books>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot)
            {
                var books = GetBooks(node);
                    bookses.Add(books);
            }
            return bookses;
        }
    
    public void Delete(string name)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem("name");
                    
                    
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(name))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    
                   
                }
            }
        }

        public Books FindBy(string name)
        {
            Books books = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                books = GetBooks(xNode);
                if  (books.Name.Equals(name))
                {
                    return books;
                }
            }
            return books;
        }

      
         
        public void Load (string xmlFieleRath)
        {
            _xmlFilePath = xmlFieleRath;
            _document.Load(xmlFieleRath);
        }

        private Books GetBooks(XmlNode node)
        {
            var books = new Books();
            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("name");
                books.Name = attributeName?.Value;
            }
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("author"))
                    {
                        books.Author = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("year"))
                        books.Year = int.Parse(childNode.InnerText);
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    
                }
            }
            return books;
        }
        
    }
}
