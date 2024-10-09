using System;

class Program
{
    static void Main(string[] args)
    {
        int keepProgramOpen = 0;

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

        while (keepProgramOpen == 0)
        {
            if (option == 1)
            {
                // Start the process of writing a new entry

                // First create an instance of the necessary class
                Entry entry = new Entry();

                // Call the needed function
                entry.SaveEntry()
            }
            else if (option == 2)
            {
                // Display the entries of the day thus far
            }
            else if (option == 3)
            {
                // Ask for the name of the file to load, and then load it
            }
            else if (option == 4)
            {
                // Prompt user for fiel name, and save current entries to that file 
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