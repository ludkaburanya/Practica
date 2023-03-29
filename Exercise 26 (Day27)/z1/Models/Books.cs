using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1.Models
{
    internal class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"-------->Book is {Name}")
                .AppendLine($"\tauthor is {Author}")
                .AppendLine($"\tyear {Year}")
                .ToString();
        }
    }
}
