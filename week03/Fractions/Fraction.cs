using System;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    // Defining the top number and bottom number when initiates the program
    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    // Function saying that the number at the top will the whole one
    public Fraction(int wholeNumber)
    {
        _topNumber = wholeNumber;
        _bottomNumber = 1;
    }

    // Function that defines if the top or bottom number will be the numerator or denominator
    public Fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }

    // Function that gives fraction with the "/" between the numbers
    public string GetFractionString()
    {
        string fraction = $"{_topNumber}/{_bottomNumber}";
        return fraction;
    }

    // Function that gives the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_topNumber/(double)_bottomNumber;
    }
}