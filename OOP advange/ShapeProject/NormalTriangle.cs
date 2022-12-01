using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class NormalTriangle : Shape
    {
        public double SideA { get; set;}
        public double SideB { get; set;}
        public double SideC { get; set;}

        public NormalTriangle() : base("NormalTriangle")
        {
            SideA = 3.0;
            SideB = 4.0;
            SideC = 5.0;
        }
        public NormalTriangle(string name, double sideA, double sideB, double sideC) : base(name)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            type = "NormalTriangle";
        }
        public override double GetArea()
        {
            double p =GetPerimeter();
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }
        public override double GetPerimeter()
        {
            
            return (SideA + SideB + SideC)/2;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("SideA: " + SideA);
            Console.WriteLine("SideB: " + SideB);
            Console.WriteLine("SideC: " + SideB);
        }
    }
}