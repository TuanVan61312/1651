using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name;}
            set
            {
                if (value == "") name = "No name";
                else name = value;
            }
        }
        public int Price { get; set;} //short-cut, no attributes
        private static int count = 0;//count number of Product object
        private int id;
        public int ID
        {
            get { return id;}
        }

        public Product()
        {
            Name = "No name";
            Price = 0;
            id = ++count;
        }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
            id = ++count;
        }

        public void ShowInfo()
        {
            Console.WriteLine("ID: " + ID + ", name: " + Name + ", price: " + Price);
        }
    }
}