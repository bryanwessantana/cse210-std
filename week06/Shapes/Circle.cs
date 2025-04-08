using System;

public class Circle : Shape
{
    private double _circleRadius;

    public Circle(string _shapeColor, double circleRadius) : base(_shapeColor)
    {
        _circleRadius = circleRadius;
    }

    public override double GetArea()
    {
        return Math.PI * _circleRadius * _circleRadius;
    }
}