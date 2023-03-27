using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probaKvartira2
{
    internal class ApartmentInTheCenter : Apartment
    {
        private string districtName;

        public double allowance = 0.01;

        public ApartmentInTheCenter ( string districtName, string name, double squre, double price) : base (name, squre, price)
        {
            this.districtName = districtName;
        }

        public double PriceIncludingLocationSurcharge() => base.Price / allowance;
        // СДЕЛАТЬ РАСЧЕТ ФОРМУЛЫ!
    }
}
