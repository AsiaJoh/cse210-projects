using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }
}

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