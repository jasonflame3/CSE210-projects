using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        List <Shape> jcShapes = new List<Shape>();
        jcShapes.Add(new Square("red", 5));
        jcShapes.Add(new Rectangle("blue", 5,10));
        jcShapes.Add(new Circle("yellow", 3));

        foreach (Shape shape in jcShapes){

        Console.WriteLine($"{shape.jcGetColor()} {shape.jcGetArea()}");
        }

        Square square = new Square("red", 5);
        Console.WriteLine($"Square: {square.jcGetColor()} {square.jcGetArea()}");
        Rectangle rectangle = new Rectangle("blue", 5,10);
        Console.WriteLine($"Rectangle: {rectangle.jcGetColor()} {rectangle.jcGetArea()}");
        Circle circle = new Circle("yellow", 3);
        Console.WriteLine($"Circle: {circle.jcGetColor()} {circle.jcGetArea()}");
    }
}