using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoComposite
{
    public class Member
    {
        public string Name {get;set;}
        public int Products {get;set;}
        protected const double PRICE = 100.0;
        public static double COMMISION = 0.3;
        public Member(string name, int products)
        {
            Name = name;
            Products = products; 
        }
        public abstract double GetSalary();
        public virtual void Show()
        {
            Console.WriteLine("Member: {0} sells: {1} products", Name, Products);
        }
    }
}