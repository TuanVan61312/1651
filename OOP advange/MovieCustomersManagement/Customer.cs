using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCustomersManagement
{
    public abstract class Customer
    {
        protected string name;
        protected string email;
        protected int id;
        protected static int count = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int ID
        {
            get { return id; }
        }
        public Customer()
        {
            Name = "No name";
            Email = "NoEmail@123.111";
            id = ++count;
        }
        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            id = ++count;
        }  
        public void ShowInfo()
        {
            System.Console.WriteLine("ID: " + id + ", Name: " + name + ", Email: " + email);
        }
        public abstract double GetPayment();  
    }
}