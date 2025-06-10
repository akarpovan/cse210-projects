using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Shapes Project.");

        //Create a Square instance
        Square square = new Square("red",10);
        string colorSquare = square.GetColor();
        double areaSquare = square.GetArea();
        Console.WriteLine($"Shape: square, Color: {colorSquare}, Area: {areaSquare}.");

        //Create a Rectangle instance
        Rectangle rectangle = new Rectangle("blue",20,10);
        string colorRectangle = rectangle.GetColor();
        double areaRectangle = rectangle.GetArea();
        Console.WriteLine($"Shape: rectangle, Color: {colorRectangle}, Area: {areaRectangle}.");

        //Create a Circle instance
        Circle circle = new Circle("brown",5);
        string colorCircle = circle.GetColor();
        double areaCircle = circle.GetArea();
        Console.WriteLine($"Shape: circle, Color: {colorCircle}, Area: {areaCircle}.");

        List<Shape> listShapes = new List<Shape>();
        listShapes.Add(square);
        listShapes.Add(rectangle);
        listShapes.Add(circle);

        foreach (Shape item in listShapes)
        {
            Console.WriteLine($"Color: {item.GetColor()}, Area: {item.GetArea()}.");
        }

    }
}