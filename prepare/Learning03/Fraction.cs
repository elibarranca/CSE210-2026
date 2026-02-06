using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1; //top
        _denominator = 1; //bottom
    }
    public Fraction(int top)
    {
        _numerator = top; //top
        _denominator = 1; //bottom
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }
    public int GetNumerator()
}
