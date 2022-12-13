using System;
using FigureSystem;
using System.Collections.Generic;

List<Figure> figures = new List<Figure>();

figures.Add(new Rectangle(5, 3));
figures.Add(new Triangle(5));
figures.Add(new TextFigure("Hello Word"));

foreach (Figure figure in figures)
{
    figure.Draw();
    System.Console.WriteLine("===================================");
}
