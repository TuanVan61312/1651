using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Shop
    {
        private List<Product> products;
        private List<SaleProduct> saleProducts;
        public Shop()
        {
            products = new List<Product>();
            saleProducts = new List<SaleProduct>();
        }
        public void PrintMenu()
        {
            System.Console.WriteLine("1. Add new products");
            System.Console.WriteLine("2. Sell products");
            System.Console.WriteLine("3. Quit");
        }
        public int GetChoice()
        {
            System.Console.WriteLine("Choose options: ");
            return int.Parse(Console.ReadLine());
        }
        public void AddNewProduct()
        {
            System.Console.WriteLine("Normal product or sale product? (n/s): ");
            string answer = Console.ReadLine();
            Product p = EnterProduct();

            if (answer == "n")
            {
                products.Add(p);    
            }
            else
            {
                System.Console.WriteLine("Enter % sales: ");
                int sale = int.Parse(Console.ReadLine());
                
                SaleProduct sp = new SaleProduct(name, price, sale/100.0);
                saleProducts.Add(sp);
            } 
        }
        public Product EnterProduct()
        {
            System.Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            return p;
        }
        public void SellProduct()
        {
            System.Console.WriteLine("Enter product name: ");
            string name = Console.ReadLine();
            
            foreach(SaleProduct sp in saleProducts)
            {
                if (sp.Name == Name)
                {
                    sp.ShowInfo();
                    System.Console.WriteLine("Product: " + sp.Name + " sold!");
                    return;
                }
            }

            foreach(Product p in products)
            {
                if (p.Name == Name)
                {
                    p.ShowInfo();
                    System.Console.WriteLine("Product: " + p.Name + " sold");
                    return;
                }
            }
            System.Console.WriteLine("Product not found!!!!");
        }
    }
}