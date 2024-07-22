using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the color for the square: ");
        Console.WriteLine("Enter the value for the square side: ");
        double side = Convert.ToDouble(Console.ReadLine());
        Square square = new Square(side);
        Console.WriteLine($"The area value is {square.GetArea()}");
        Console.WriteLine($"The color of the shape is {square.GetColor()}");

        Console.WriteLine("Enter the color for the rectangle: ");
        Console.WriteLine("Enter the value for the rectangle length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the value for the rectangle width: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(length, width);
        Console.WriteLine($"The area value is {rectangle.GetArea()}");
        Console.WriteLine($"The color of the shape is {rectangle.GetColor()}");

        Console.WriteLine("Enter the color for the circle: ");
        Console.WriteLine("Enter the value for the circle radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine($"The area value is {square.GetArea()}");
        Console.WriteLine($"The color of the shape is {circle.GetColor()}");



        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
    }
}