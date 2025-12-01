using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Squares squares = new Squares(5, "red");
        Rectangle rectangle = new Rectangle(5, 6, "blue");
        Circle circle = new Circle(5, "yellow");
        
        List<Shape> ShapesList = new List<Shape>();
        ShapesList.Add(new Squares(5, "red"));
        ShapesList.Add(new Circle(6, "blue"));
        ShapesList.Add(new Rectangle(7, 8, "yellow"));

        foreach (Shape s in ShapesList)
        {
            Console.WriteLine($"{s.GetType().Name} Color: {s.GetColor()}");
            Console.WriteLine($"Area: {s.GetArea()}");
        }

        
        // squares.GetArea();
        // squares.GetColor();
        // Console.WriteLine($"{squares.GetArea()}, {squares.GetColor()}");

        // rectangle.GetArea();
        // rectangle.GetColor();
        // Console.WriteLine($"Recetangle : {rectangle.GetArea()}, {rectangle.GetColor()}");

        // Console.WriteLine($"Circle : {circle.GetArea()}, {circle.GetColor()}");


    }
}
