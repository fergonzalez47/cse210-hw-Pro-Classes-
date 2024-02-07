using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*******");

        Square  square = new Square("blue", 2);
        // square.GetColor();
        // square.GetArea();
        Console.WriteLine($"{square.GetColor()}");
        Console.WriteLine($"{square.GetArea()}");
        Circle circle = new Circle("red", 3);
        Rectangle rectangle = new Rectangle("black", 2, 4);



        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);


        foreach (var shape in shapes)
        {

            Console.WriteLine($"{shape.GetColor()}");
            Console.WriteLine($"{shape.GetArea()}");
        }
    }


}