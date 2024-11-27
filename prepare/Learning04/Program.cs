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
        // Console.WriteLine(summary);
        Console.WriteLine(hwList);

        MathAssignment mathAssignmentParams = new MathAssignment("Larry", "meth", "6", "5-7");
        hwList = mathAssignmentParams.GetHomeworkList();
        // Console.WriteLine(summary);
        Console.WriteLine(hwList);
    }
}