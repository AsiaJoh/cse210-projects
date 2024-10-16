using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing time!!
        Fraction fractionNone = new Fraction(); // Object 1 instance, using 1st constructor
        Console.WriteLine(fractionNone.GetFractionString());
        Console.WriteLine(fractionNone.GetDecimalValue());

        Fraction fractionOne = new Fraction(5); // Object 2 instance, using 2nd constructor
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());

        Fraction fractionTwo = new Fraction(2, 3); // Object 3 instance, using 3rd constructor
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());

        Fraction fractionThree = new Fraction(5, 6); // Object 4 instance, using 4th constructor

    }
}