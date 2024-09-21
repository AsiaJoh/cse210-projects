using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage for your class? ");
        
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter = "";

        if (grade >= 90)
        {
            Console.WriteLine();
            Console.WriteLine("You passed!");
            letter = "A";
        }
        else if (grade >= 80)
        {
            Console.WriteLine();
            Console.WriteLine("You passed!");
            letter = "B";
        }
        else if (grade >= 70)
        {
            Console.WriteLine();
            Console.WriteLine("You passed!");
            letter = "C";
        }
        else if (grade >= 60)
        {
            Console.WriteLine();
            Console.WriteLine("You passed!");
            letter = "D";
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry, better luck next time!");
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is a {letter}.");
    }
}