using System;

class Program
{
    static void Main(string[] args)
    {
        // Call welcome function
        DisplayWelcomeMessage();

        // Call user name function
        string name = PromptUserName();

        // Call user fav number function
        int number = PromptUserNumber();

        //Call squaring function
        int squaredNumber = SquareNumber(number);

        // Call Accept/Display the results function
        DisplayResult(name, squaredNumber);
        
    }

    // Display welcome function
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Prompt for user name function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine(); // With C# we seem to not need to pre-define variables from loops?? Maybe maybe not
        
        return userName;
    }

    // Prompt for user fav number function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine()); // A smaller way to change the string to an integer
        
        return userNumber;
    }

    // Function that accepts an integer for a parameter, and returns that same number squared (as an integer)
    static int SquareNumber(int number) //It appears we probably can use the same characters for the parameters, as variables outside the function... (I think I use both the same and different names, I guess as an example)
    {
        int numberSquared = number * number;
        
        return numberSquared;
    }

    // Accept/Display the results function
    static void DisplayResult(string userName, int userNumberSquared)
    {
        Console.Write($"{userName}, the square of your number is {userNumberSquared}");    
    }



    
}

// Notes belowwwww

/* 
General structure of a function: 
returnType FunctionName(dataType parameter1, dataType parameter2)
{
    // function_body
}

function w/out parameters or return type (this is the "void")
void DisplayMessage()
{
    // function_body
}

function with 1 parameter
void DisplayPersonalMessage(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

The next example shows a function that accepts two integers as parameters. It adds them together and returns the result. Notice that the function specifies a return 
value of int at the beginning of the definition.

int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}

In C#, because the language is so dedicated to the principles of Programming with Classes, the default case for all functions is to be methods, which must be called 
in the context of an object. (Again, more on this later!) But this has an important ramification for you now. If you want to define "regular" standalone function, you 
need to use the static keyword. This tells C# that you want your functions to be able to be called without any other context.

static int AddNumbers(int first, int second)
{
    int sum = first + second;
    return sum;
}
*/


// This is a single-line comment

/* This is
a multi-line comment*/