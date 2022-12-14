using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoRecruitment
{
    public class SaleEmployee : Employee
    {
        public double Products {get;set;}
        public SaleEmployee(string name, int age, double salary, int products) : base(name, age, salary)
        {
            Products = products;
        }
        public override string ToString()
        {
            return string.Format("Saler Name: {0}, Age: {1}, Salary: {2}, Products: {3}", Name, Age, Salary, Products);
        }
    }
}