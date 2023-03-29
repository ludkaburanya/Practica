using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using z1.Models;

namespace z1.Interfaces
{
    internal interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Books books);
        void Delete(string name);
        Books FindBy(string name);
    }
}
