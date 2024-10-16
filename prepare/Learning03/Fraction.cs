using System;
using System.Runtime.ExceptionServices;

class Fraction
{
    int _top; // When you don't specify the variable as public (by putting the keyword before the statement), the variable is automatically private
    int _bottom; // However, if you wanted to specify in in code, you would write this-> private int _bottom;
    // Things that are private can only be directly accessed within their class

    // Our constructors!
    // Turns out, constructors are just what help us make objects/instantiations of the class.
    // They can help the object be made with default parameters, and/or optional parameters
    // The constructors specify all the ways the object can be made, and you tell it is an isntructor (instead of a function) because there is no defined return type, not even void
    // Constructors must have the same title as the class(?)

    // We want these constructors to be public(?)
    public Fraction() 
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) 
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) 
    {
        _top = top;
        _bottom = bottom;
    }

    // Now for the methods (specifically the getters and setters)
    public void GetTop() // Methods are also automatically private (I think), so we must specify these to be public
    {
        int top = _top;
        Console.WriteLine($"Here is the top: {top}");
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void GetBottom()
    {
        int bottom = _bottom;
        Console.WriteLine($"Here is the bottom: {bottom}");
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // The rest of the methods
    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double decimaal = (double)_top / _bottom; // The (double) ensures that even though we're passing in integers, the decimaal variable remains a double-type variable
        return decimaal;
    }
}