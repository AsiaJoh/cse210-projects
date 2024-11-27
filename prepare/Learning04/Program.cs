using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing time!
        //Test 1
        Assignment assignmentDefault = new Assignment();
        string summary = assignmentDefault.GetSummary();
        Console.WriteLine(summary);

        Assignment assignmentParams = new Assignment("Larry", "meth");
        summary = assignmentParams.GetSummary();
        Console.WriteLine(summary);

        Console.WriteLine();

        //Test 2
        MathAssignment mathAssignmentDefault = new MathAssignment();
        string hwList = mathAssignmentDefault.GetHomeworkList();
        summary = mathAssignmentDefault.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine(hwList);

        Console.WriteLine("---");

        MathAssignment mathAssignmentParams = new MathAssignment("E", "yiddles", "6", "5-7");
        hwList = mathAssignmentParams.GetHomeworkList();
        summary = mathAssignmentParams.GetSummary();
        Console.WriteLine(summary);
        Console.WriteLine(hwList);

        Console.WriteLine();

        //Test 3
        
    }
}