using System;

public class Rectangle : Shape
{
    private double _rectangleLength;
    private double _rectangleWidth;

    public Rectangle(string _shapeColor, double rectangleLength, double rectangleWidth) : base(_shapeColor)
    {
        _rectangleLength = rectangleLength;
        _rectangleWidth = rectangleWidth;
    }

    public override double GetArea()
    {
        return _rectangleLength * _rectangleWidth;
    }
}