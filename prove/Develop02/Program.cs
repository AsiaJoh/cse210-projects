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
                entry.WriteEntry();
            }
            else if (option == "2")
            {
                // Display the entries of the day thus far
                
                // Call the needed function
                entry.DisplayEntry();
            }

            else if (option == "3")
            {
                // Ask for the name of the file to load, and then load it
                // Ask for file name
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                
                // Call the needed function
                // string fileContent = journal.LoadJournal(file);
                journal.LoadJournal(file);

            }
            else if (option == "4")
            {
                // Prompt user for file name, and save current entries to that file 
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                // Call the needed function
                entry.SaveEntry(file);
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