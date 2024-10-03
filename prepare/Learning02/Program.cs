using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 0;
        job1._endYear = 0;

        Console.WriteLine(job1._jobTitle);
    }
}