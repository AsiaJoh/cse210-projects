using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int keepProgramOpen = 0;

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
            string stringOption = Console.ReadLine();

            int option = int.Parse(stringOption);

            if (option == 1)
            {
                // Start the process of writing a new entry

                // Create an instance of the necessary class
                Entry entry = new Entry();

                // Call the needed function
                entry.SaveEntry();
            }
            else if (option == 2)
            {
                // Display the entries of the day thus far

                // Create an instance of the necessary class
                Entry entry = new Entry();
                
                // Call the needed function
                entry.GetEntry();
            }

            else if (option == 3)
            {
                // Ask for the name of the file to load, and then load it
                
                // Create an instance of the necessary class
                Journal journal = new Journal();

                // Ask for file name
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                
                // Call the needed function
                // string fileContent = journal.LoadJournal(file);
                journal.LoadJournal(file);

            }
            else if (option == 4)
            {
                // Prompt user for file name, and save current entries to that file 

                // Create an instance of the necessary class
                Journal journal = new Journal();
                
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