using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shape
{
    public abstract class Shape
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Shape()
        {
            Name = "No Name";
        }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public virtual void ShowInfo()
        {
            System.Console.WriteLine("Name: " + Name);
        }
    }
}