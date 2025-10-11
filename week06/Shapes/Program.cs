using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add shapes
        shapes.Add(new Square("Red", 4));
        shapes.Add(new Rectangle("Blue", 5, 3));
        shapes.Add(new Circle("Green", 2.5));

        // Display color and area for each shape
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Shape Area: {shape.GetArea():F2}\n");
        }
    }
}
