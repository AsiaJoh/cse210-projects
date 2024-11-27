using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing time!
        Assignment assignmentDefault = new Assignment();
        string summary = assignmentDefault.GetSummary();
        Console.WriteLine(summary);

        Assignment assignmentParams = new Assignment("Larry", "meth");
        summary = assignmentParams.GetSummary();
        Console.WriteLine(summary);
    }
}