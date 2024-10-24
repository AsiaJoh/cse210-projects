using System;

public class Scripture
{   // The private piece is unnecessary, but for the sake of remembering syntax/format I'm going to write it this time
    private Reference _reference; 
    private List<Word> _wordList;

    public void DisplayScripture()
    {
        _wordList = new List<Word>
        {
            new Word("Behold,"), new Word("this"), new Word("is"), new Word("my"), new Word("work"), new Word("and"), new Word("my"), new Word("glory--"), 
        new Word("to"), new Word("bring"), new Word("to"), new Word("pass"), new Word("the"), new Word("immortality"), new Word("and"), new Word("eternal"), 
        new Word("live"), new Word("of"), new Word("man.")
        };

        // Construct the reference class, then put the scripture reference in there
        _reference = new Reference("Moses", 1, 39);
        
        // Display the reference
        _reference.DisplayReference();
        // Console.WriteLine();

        // Display the scripture via printing out the funky list...
        foreach (Word word in _wordList)
        {
            Console.Write(word );
        }
    }

    public void RedactScripture()
    { // Choose a random Word, check if it is redacted, then redact said word if not. (And choose a random amount of words to redact)
        
        // Instance random class
        Random random = new Random();
        // Get a random number between 1 and 3 (including these)
        int randomCounter = random.Next(0, 4);
        
        while (randomCounter > 0)
        {
            // Choosing a random word...
            // Find the length of the word list that is the scripture (index-wise)
            int listLength = _wordList.Count;

            // Generate a random integer within that list (according to it's indexes)
            int randomNumber = random.Next(0, listLength); // The first number is inclusive, the second exclusive, so the highest number shoulD be the max index

            // Check if the related word is redacted
            if (!_wordList[randomNumber].GetRedacted()) // Check if redacted status is false
            {
                // Call the redact word method
                _wordList[randomNumber].RedactWord();
            }
            else // If the redacted status is true
            { 
                RedactScripture();
            }

            // Subtract 1 from the counter, so that it counts down from whatever random number it chose
            // If it chose 3, it goes down to 2 and runs 2 more times, if it chose 1 it ends, etc.
            randomCounter -= 1;
        }
    }
}