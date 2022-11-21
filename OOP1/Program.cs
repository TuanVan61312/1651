using System;

namespace OOP1
{
    class Program
    {   
        public static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.Name = "";
            t1.Subject = "";
            t1.Age = 20;

            Console.WriteLine("Name: " + t1.Name);
            Console.WriteLine("Subject: " + t1.Subject);
            Console.WriteLine("Age: " + t1.Age);
        }
    }
}