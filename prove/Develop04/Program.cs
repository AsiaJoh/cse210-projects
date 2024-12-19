using System;
using System.ComponentModel;

// I decided to show creativity by adding an additional option to the menu - a log of how many times you've run each activity.

class Program
{
    static void Main(string[] args)
    {

        int breathingCounter = 0;
        int reflectingCounter = 0;
        int listingCounter = 0;

        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. View activity log");
            Console.WriteLine("\t5. Quit");

            Console.Write("Select a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                breathingCounter += 1;
                Breathing breathingActivity = new Breathing();
                breathingActivity.SetName("Breathing Activity");

                breathingActivity.BreathingActivity();
            }
            else if (userInput == 2)
            {
                reflectingCounter += 1;
                Reflection reflectingActivity = new Reflection();
                reflectingActivity.SetName("Breathing Activity");

                reflectingActivity.ReflectingActivity();
            }
            else if (userInput == 3)
            {
                listingCounter += 1;
                Listing listingActivity = new Listing();
                listingActivity.SetName("Breathing Activity");

                listingActivity.ListingActivity();
            }
            else if (userInput == 4)
            {
                Console.Clear();
                Console.WriteLine("Here is a log of how many times you've done each activity: ");
                Console.WriteLine($"Breathing Activity: {breathingCounter} times");
                Console.WriteLine($"Reflection Activity: {breathingCounter} times");
                Console.WriteLine($"Listing Activity: {breathingCounter} times");
                
                Activity activity = new Activity();
                activity.PauseDisplay();
            }
            else
            {
                quit = true;
            }
        }   
    }
}