using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); // New instance of a class
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1); // Huh. This is adding the Job class's instance/object above to the list. Is this now a list of classes? Or a list? No...? (see below)
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();

        // We add the job objects to resume list, then call resume's display function. This function displays through things, then iterates through the above list, and for each item in the list, calls Job's display function. Interesting.
    }
}