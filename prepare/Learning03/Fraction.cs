using System;

public class Fraction
{
    private int _first;
    private int _second;

    public Fraction()
    {
        _first = 1;
        _second = 1;
    }

    public Fraction(int first)
    {
        _first = first;
        _second = 1;
    }

    public Fraction(int first, int second)
    {
        _first = first;
        _second = second;
    }

    public string GetFractionString()
    {
        string text = $"{_first}/{_second}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_first /(double) _second;
    }
}