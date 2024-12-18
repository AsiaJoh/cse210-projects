using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that creates at least one activity of each type. Put each of these activities in the same list. 

        // Create the activities list
        List<Activity> activitiesList = new List<Activity>();


        // Create the Running Activity
        Running running = new Running();

        // Set the variables
        running.SetDate("03 Dec 2003");
        running.SetDistance(2.2f);
        running.SetTime(2.5f);

        // Add the activity to the list
        activitiesList.Add(running);


        // Create the Cycling Activity
        Cycling cycling = new Cycling();

        // Set the variables
        cycling.SetDate("07 June 2018");
        cycling.SetDistance(15);
        cycling.SetTime(5.50f);

        // Add the activity to the list
        activitiesList.Add(cycling);


        // Create the Swimming Activity
        Swimming swimming = new Swimming();

        // Set the variables
        swimming.SetDate("10 Oct 2013");
        swimming.SetDistance(10.01f);
        swimming.SetTime(1.34f);

        // Add the activity to the list
        activitiesList.Add(swimming);


        // Then iterate through this list and call the GetSummary method on each item and display the results.
        foreach (Activity activity in activitiesList)
        {
            string summaryString = activity.GetSummary();

            Console.WriteLine(summaryString);
            Console.WriteLine();
        }
    
    }
}