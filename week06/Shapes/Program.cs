using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("red", 5));
        shapes.Add(new Rectangle("blue", 10, 3));
        shapes.Add(new Circle("green", 4));

        Console.WriteLine("Welcome to the Shapes Program!\n");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} {shape.GetType().Name.ToLower()} has an area of: {shape.GetArea():F2}");
        }
    }
}