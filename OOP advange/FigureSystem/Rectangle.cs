using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FigureSystem
{
    public class Rectangle : Figure
    {
        private int width;
        private int height;
        public int Width
        {
            get {return width;}
            set {width = value;}
        }
        public int Height
        {
            get {return height;}
            set {height = value;}
        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override void Draw()
        {
            for (int i = 0; i <= Height; i++)
            {
                DrawLine(Width);
            }
        }
    }
}