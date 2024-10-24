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

        do // Using a do-while loop in this scenario to hopefully get the code to still fully print out a fully-redacted scripture verse at least once, before ending automatically
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

                // Call the RedactScripture function to erase a random number of words in random spots
                // Add the number returned in the RedactScripture to a different variable, as this will count how many of the total words have been redacted.
                int wordsRedacted = scripture.RedactScripture();

                totalWordsRedacted += wordsRedacted;
            }
            else
            { // If the user typed quit
                // // Leave a nice message and end the program
                Console.WriteLine("Have a happy day, and good luck memorizing!");
                // scriptureFullyRedacted = true;
                
                totalWordsRedacted = 19;
            }
        }
        while (totalWordsRedacted != 19); // 19 is the total number of words in the scripture

        // If no input but not scripture fully redacted (get fully redacted ) rldr rnf
        // If times redacted = word count, set scripture fully redacted boolean to true
    }
}