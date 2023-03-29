using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using z1.Interfaces;
using z1.Models;
using z1.Share;

namespace z1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        public MainWindow()
        {
            InitializeComponent();
          
            _worker = new XmlDocumentWorker (_logger);
        }

        private void buttonFindBooksName_Click(object sender, RoutedEventArgs e)
        {
            var books = _worker.FindBy(textBoxBooksName.Text);
            PrintBooks(books);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteBooks.Text)
                || !string.IsNullOrEmpty(textBoxDeleteBooks.Text))
            {
                _worker.Delete(textBoxDeleteBooks.Text);
                
            }
        }
        private void PrintBooks(Books books)
        {
            textBlockXMLFileBook.Text = "========Book========" + Environment.NewLine;
            textBlockFileBook.Text += books?.ToString() ?? "Book not found";
        }

        private void PrintBookss(List<Books> bookss)
        {
            textBlockXMLFileBook.Text = "========Books========" + Environment.NewLine;
            foreach (var book in bookss)
            {
                textBlockXMLFileBook.Text += book.ToString();
            }
        }

        private void textBoxBooksName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxBooksName.Text))
            {
                
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml document (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
            }
        }

        private void textBoxDeleteBooks_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
