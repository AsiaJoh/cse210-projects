using System;
// For exceeding requirements, I caused the program to only redact words that haven't been redacted yet, and I set it up to not redact punctuation characters, 
// in the hopes that if the user wanted to count the underscores for a hint, the punctuation wouldn't mislead them.

class Program
{
    static void Main(string[] args)
    {
        // bool scriptureFullyRedacted = false;
        int totalWordsRedacted = 0;

        // Instance the scripture class
        Scripture scripture = new Scripture();

        while (totalWordsRedacted < 19) // 19 is the total number of words in the scripture
        {   
            // Display the scripture
            scripture.DisplayScripture();
            
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");

            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            { // If the user pressed enter (or typed anything other than quit)
                // Remove more words from the scripture

                // Clear the console
                Console.Clear();

                // Generate a random number, to redact a random number of words (1-4)

                // Instance random class
                Random random = new Random();

                // Get a random number between 1 and 4 (including these)
                int randomCounter = random.Next(1, 5);

                while (randomCounter > 0 && totalWordsRedacted < 19)
                {
                // Call the RedactScripture function to erase a random number of words in random spots
                // Add the number returned in the RedactScripture to a different variable, as this will count how many of the total words have been redacted.
                scripture.RedactScripture();

                randomCounter -= 1;
                totalWordsRedacted += 1;
                }
            }
            else
            { // If the user typed quit
                // // Leave a nice message and end the program
                Console.WriteLine("Have a happy day, and good luck memorizing!");
                // scriptureFullyRedacted = true;
                
                totalWordsRedacted = 19;
            }
            if (totalWordsRedacted > 19)
            {
            totalWordsRedacted = 19;
            }
        }
        // Display the scripture
        scripture.DisplayScripture();
        
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        Console.ReadLine();
    }
}