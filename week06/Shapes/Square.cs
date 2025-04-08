using System;

public class Square : Shape
{
    private double _squareSide;

    public Square(string _shapeColor, double squareSide) : base(_shapeColor)
    {
        _squareSide = squareSide;
    }

    public override double GetArea()
    {
        return _squareSide * _squareSide;
    }
}