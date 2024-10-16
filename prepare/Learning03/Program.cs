using System;

class Program
{
    static void Main(string[] args)
    {
        // Test-instancing time! 
        Fraction fractionNone = new Fraction(); // Object 1 instance
        Fraction fractionOne = new Fraction(5); // Object 2 instance
        Fraction fractionTwo = new Fraction(2, 3); // Object 3 instance

        int done = 0;
        while (done != 1)
        {
            Console.WriteLine("0, 1, or 2 numbers?");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Gimme a number ");
                int numberGiven = int.Parse(Console.ReadLine());
                fractionNone.SetTop(numberGiven);
                fractionNone.GetTop();

                Console.WriteLine("Gimme a number ");
                int numberGiven2 = int.Parse(Console.ReadLine());
                fractionNone.SetBottom(numberGiven2);
                fractionNone.GetBottom();

                Console.WriteLine();
                Console.WriteLine("A fraction and decimal: ");
                Console.WriteLine(fractionNone.GetFractionString());
                Console.WriteLine(fractionNone.GetDecimalValue());

                Console.WriteLine();
                Console.WriteLine("Done (0=no/1=yes)? ");
                done = int.Parse(Console.ReadLine());

            }
            else if (number == 2)
            {
                Console.WriteLine("Gimme a number ");
                int numberGiven = int.Parse(Console.ReadLine());
                fractionOne.SetTop(numberGiven);
                fractionOne.GetTop();

                Console.WriteLine("Gimme a number ");
                int numberGiven2 = int.Parse(Console.ReadLine());
                fractionOne.SetBottom(numberGiven2);
                fractionOne.GetBottom();

                Console.WriteLine();
                Console.WriteLine("A fraction and decimal: ");
                Console.WriteLine(fractionOne.GetFractionString());
                Console.WriteLine(fractionOne.GetDecimalValue());

                Console.WriteLine();
                Console.WriteLine("Done (0=no/1=yes)? ");
                done = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Gimme a number ");
                int numberGiven = int.Parse(Console.ReadLine());
                fractionTwo.SetTop(numberGiven);
                fractionTwo.GetTop();

                Console.WriteLine("Gimme a number ");
                int numberGiven2 = int.Parse(Console.ReadLine());
                fractionTwo.SetBottom(numberGiven2);
                fractionTwo.GetBottom();

                Console.WriteLine();
                Console.WriteLine("A fraction and decimal: ");
                Console.WriteLine(fractionTwo.GetFractionString());
                Console.WriteLine(fractionTwo.GetDecimalValue());

                Console.WriteLine();
                Console.WriteLine("Done (0=no/1=yes)? ");
                done = int.Parse(Console.ReadLine());
            }
        }
    }
}