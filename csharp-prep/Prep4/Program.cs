using System;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Collections.Generic; //Need to use this when using lists and similar things

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        List<int> numbers = new List<int>(); //Technically this can also be done in two rows
        int total = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            
            string strNumber = Console.ReadLine();
            number = int.Parse(strNumber);
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Find the sum
        foreach (int num in numbers) // Apparently, unlike python, you cannot use the same variable name for your index as with any external variable. Declaring it properly causes problems, and so does trying to just use it.
        {
            total += num;
        }

        // Find the average
        float numbersLength = numbers.Count; //There's no () after "Count" because it's a property.
        float average = ((float)total) / numbersLength; //This little float buisness is how we get it to print out a decimal
        
        // Find the max
        int max = numbers.Max(); //Alternatively, I could take each number (in the foreach loop above), compare it to the last, and if it's larger declare it the max. But this is easier. (Also this .Max() is a method/function from another Class b/c of the parentheses and dot (I think).

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}