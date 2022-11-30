using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shape
{
    public class Circle : Shape
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle()
        {
            radius = 1;
        }
        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public override double GetPerimeter() // Chu vi
        {
            return Math.PI * radius * 2;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("Radius: " + radius); //ban kinh
            System.Console.WriteLine("Area: " + GetArea()); //S
            System.Console.WriteLine("Perimeter: " + GetPerimeter()); // CHu vi
        }
    }
}

