using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Product()
        {
            Name = "Computer";
            Price = 1000;
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine(name + ": $" + price);
        }
    }
}