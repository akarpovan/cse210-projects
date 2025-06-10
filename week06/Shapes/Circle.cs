using System;

public class Circle : Shape
{
    private double _radius;

    public Circle (string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double numero = Math.PI;
        double redondiado = Math.Round(numero, 2);
        return redondiado * _radius * _radius;
    }
}
