using System;

public class Fraction
{
    private int _topNumbers;
    private int _bottomNumbers;

    public Fraction()
    {
        _topNumbers = 1;
        _bottomNumbers = 1;
    }

    public Fraction(int wholeNumber)
    {
        _topNumbers = wholeNumber;
        _bottomNumbers = 1;   
    }

    public Fraction(int top, int bottom)
    {
        _topNumbers = top;
        _bottomNumbers = bottom;
    }

    public string GetFractionString()
    {   
        string fraction = ($"{_topNumbers}/{_bottomNumbers}");
        return fraction;
    }

    public double GetDecimalValue()
    {
        double top = _topNumbers;
        double bottom = _bottomNumbers;
        double decimalValue = top / bottom;
        return decimalValue;
    }
}