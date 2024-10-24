using System;

public class Scripture
{   // The private piece is unnecessary, but for the sake of remembering syntax/format I'm going to write it this time
    private Reference _reference; 
    private List<Word> _wordsList;

    public void DisplayScripture()
    {
        _wordsList = new List<Word>
        {
            new Word("Behold,"), new Word("this"), new Word("is"), new Word("my"), new Word("work"), new Word("and"), new Word("my"), new Word("glory--"), 
        new Word("to"), new Word("bring"), new Word("to"), new Word("pass"), new Word("the"), new Word("immortality"), new Word("and"), new Word("eternal"), 
        new Word("live"), new Word("of"), new Word("man.")
        };

        // Construct the reference class, then put the scripture reference in there
        _reference = new Reference("Moses", 1, 39);
        
        _reference.DisplayReference();
        Console.WriteLine();
        
    }

    public void RedactScripture()
    { // Choose a random Word, check if it is redacted, then redact said word if not
        // Choosing a random word...
        // Instance random class
        Random random = new Random();

        // Find the length of the word list that is the scripture (index-wise)
        int listLength = _wordsList.Count;

        // Generate a random integer within that list (according to it's indexes)
        int randomNumber = random.Next(0, listLength); // The first number is inclusive, the second exclusive, so the highest number shoulD be the max index

        // Check if the related word is redacted
        if (!_wordsList[randomNumber].GetRedacted()) // Check if redacted status is false
        {
            // Call the redact word method
            _wordsList[randomNumber].RedactWord();
        }
        else // If the redacted status is true
        { 
            RedactScripture();
        }
    }
}