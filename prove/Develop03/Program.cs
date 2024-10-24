using System;

class Program
{
    static void Main(string[] args)
    {
        bool scriptureFullyRedacted = false;

        // Instance the scripture class
        Scripture scripture = new Scripture();

        while (!scriptureFullyRedacted)
        {
            // Display the scripture
            scripture.DisplayScripture();
            
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                // Clear the console
                Console.Clear();

                // Call the RedactScripture function to erase a random number of words in random spots
                scripture.RedactScripture();
            }
            else
            {
                Console.WriteLine("Have a happy day, and good luck memorizing!");
            }
        }

        // If no input but not scripture fully redacted (get fully redacted ) rldr rnf
        // If times redacted = word count, set scripture fully redacted boolean to true
    }
}