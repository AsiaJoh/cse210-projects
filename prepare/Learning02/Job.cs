using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear; // We don't need to give the variable data to declare it

    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses. Idk what it does (nor if its necessary here) but we learn about it later.
    public Job()
    {
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}