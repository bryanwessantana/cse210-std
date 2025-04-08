using System;

public abstract class Shape
{
    // Variable
    private string _shapeColor;

    // Constructor
    public Shape(string shapeColor)
    {
        this._shapeColor = shapeColor;
    }

    // Getter
    public string GetColor()
    {
        return _shapeColor;
    }

    // Setter
    public void SetColor(string shapeColor)
    {
        this._shapeColor = shapeColor;
    }

    // Virtual method
    public abstract double GetArea();
}
