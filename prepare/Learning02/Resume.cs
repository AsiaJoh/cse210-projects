using System;

public class Resume
{
    public string _name; // We don't need to give the variable data to declare it
    public List<Job> _jobs = new List<Job>(); // The data type is what goes inside the <> for the list

    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses. Idk what it does (nor if its necessary here) but we learn about it later.
    public Resume()
    {
    }

    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");

        // Notice the use of the custom data time "Job" (our other class) in this loop
        foreach (Job job in _jobs)
        {
            // This calls the job's display method on each job in resume's list
            job.DisplayJobDetails();
        }
    }
}