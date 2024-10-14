using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int keepProgramOpen = 0;

        // Create an instance of the necessary classes
        Entry entry = new Entry();
        Journal journal = new Journal();


        while (keepProgramOpen == 0)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices (via number):");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string option = Console.ReadLine();

            

            if (option == "1")
            {
                // Start the process of writing a new entry

                // Call the needed function
                journal.WriteEntry();
            }
            else if (option == "2")
            {
                // Display the entries of the day thus far
                
                // Call the needed function
                journal.DisplayJournal();
            }

            else if (option == "3")
            {
                // Ask for the name of the file to load, and then load it
                
                // Call the needed function
                journal.LoadJournal();

            }
            else if (option == "4")
            {
                // Save current entries to a file 
                // Call the needed function
                journal.SaveJournal();
            }
            else
            {
                // Exit program
                Console.WriteLine("Have a nice day!");
                keepProgramOpen = 1;
            }
        }
    }
}