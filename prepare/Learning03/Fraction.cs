using System;
using System.Runtime.ExceptionServices;

class Fraction
{
    // The attributes :)
    int _top; // When you don't specify the attribute as public (by putting the keyword before the statement), the attribute is automatically private
    int _bottom; // However, if you wanted to specify it in code, you would write this-> private int _bottom;
    // Things that are private can only be directly accessed within their class

    // Our constructors!
    // Turns out, constructors are just what help us make objects/instantiations of the class.
    // They can help the object be made with default parameters, and/or optional parameters
    // The constructors specify all the ways the object can be made, and you tell it is an isntructor (instead of a function) because there is no defined return type, not even void
    // Constructors must have the same title as the class(?)

    // We want these constructors to be public(?)
    public Fraction() 
    {
        // Default values
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
    // (Though for some reason, the key doesn't use any of the getters/setters. They did mention that they are useful sometimes, but many other times they are not, as they can undermine the point of making attributes private)
    // However, this means I cannot double-check or validate my code...
    void GetTop() // Methods are also automatically private (I think), so we must specify these to be public
    {
        int top = _top;
        Console.WriteLine($"Here is the top: {top}");
    }

    void SetTop(int top)
    {
        _top = top;
    }

    void GetBottom()
    {
        int bottom = _bottom;
        Console.WriteLine($"Here is the bottom: {bottom}");
    }

    void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // The rest of the methods
    public string GetFractionString()
    {
        // Instead of this being stored as a key member variable or attribute...
        // It is stored as a temporary local variable, that is recomputed every time this method is called
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        // Instead of this being stored as a key member variable or attribute...
        // It is stored as a temporary local variable, that is recomputed every time this method is called
        double decimaal = (double)_top / _bottom; // The (double) ensures that even though we're passing in integers, the decimaal variable remains a double-type variable
        return decimaal;
    }
}