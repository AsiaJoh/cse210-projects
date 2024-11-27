using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing time!
        //Test 1
        Assignment assignmentDefault = new Assignment(); // Declaration using empty parameters
        string summary = assignmentDefault.GetSummary(); // Set a variable equal to the summary within the assignment class
        Console.WriteLine(summary); // Print it

        // Repeat the above, but with the alt. declaration - using parameters
        Assignment assignmentParams = new Assignment("Larry", "meth"); // Declaration w/parameters
        summary = assignmentParams.GetSummary();
        Console.WriteLine(summary);

        Console.WriteLine();

        //Test 2
        MathAssignment mathAssignmentDefault = new MathAssignment(); // Declaration of math child class without parameters
        summary = mathAssignmentDefault.GetSummary(); // Access Assignment's function using the child class
        string hwList = mathAssignmentDefault.GetHomeworkList(); // Use MathAssignment's normal function
        Console.WriteLine(summary); // Print results
        Console.WriteLine(hwList);

        Console.WriteLine("---");

        // Repeat the above, but with the alt. declaration - using parameters
        MathAssignment mathAssignmentParams = new MathAssignment("E", "yiddles", "6", "5-7");
        summary = mathAssignmentParams.GetSummary();
        hwList = mathAssignmentParams.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(hwList);

        Console.WriteLine();

        //Test 3
        WritingAssignment writingAssignmentDefault = new WritingAssignment(); // Declaration of the other child class - without using parameters
        summary = writingAssignmentDefault.GetSummary(); // Again access Assignment's method from the child class
        string paperTitle = writingAssignmentDefault.GetWritingInformation(); // Use the Writing class's method
        Console.WriteLine(summary); // Print for testing
        Console.WriteLine(paperTitle);

        Console.WriteLine("---");

        // Repeat the above, but with the alt. declaration - using parameters
        WritingAssignment writingAssignmentParams = new WritingAssignment("Whoha", "whoami", "We Three Kings");
        summary = writingAssignmentParams.GetSummary();
        paperTitle = writingAssignmentParams.GetWritingInformation();
        Console.WriteLine(summary);
        Console.WriteLine(paperTitle);
    }
}