using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaKvartira2
{
    internal class Apartment
    {
        private string name;
        private double squre;
        private double price;

        public string Name { get => name; }
        public double Squre { get => squre; }
        public double Price { get => price; }

        public Apartment(string name, double sgure, double price)
        {
            this.name = name;
            this.squre = sgure;
            this.price = price;
        }
    }
}
