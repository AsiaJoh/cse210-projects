using System;

public class Scripture
{   // The private piece is unnecessary, but for the sake of remembering syntax/format I'm going to write it this time
    private Reference _reference; 
    private List<Word> _wordList = new List<Word>
        {
        new Word("Behold,"), new Word("this"), new Word("is"), new Word("my"), new Word("work"), new Word("and"), new Word("my"), new Word("glory--"), 
        new Word("to"), new Word("bring"), new Word("to"), new Word("pass"), new Word("the"), new Word("immortality"), new Word("and"), new Word("eternal"), 
        new Word("live"), new Word("of"), new Word("man.")
        };

    public void DisplayScripture()
    {
        // Construct the reference class, then put the scripture reference in there
        _reference = new Reference("Moses", 1, 39);
        
        // Display the reference
        _reference.DisplayReference();

        // Display the scripture via printing out the funky list...
        foreach (Word wordObject in _wordList)
        {
            Console.Write($"{wordObject.GetWord()} ");
        }
    }

    public void RedactScripture()
    { // Choose a random Word, check if it is redacted, then redact said word if not. (And choose a random amount of words to redact)
        
        // Instance random class
        Random random = new Random();

        // Choosing a random word...
        // Find the length of the word list that is the scripture (index-wise)
        int listLength = _wordList.Count;

        // Generate a random integer within that list (according to it's indexes)
        int randomNumber = random.Next(0, listLength); // The first number is inclusive, the second exclusive, so the highest number shoulD be the max index

        // Assign the chosen word to a variable
        Word word = _wordList[randomNumber];

        // While the chosen word has already been redacted
        while (word.GetRedacted())
        {
            // Pick a new random number
            randomNumber = random.Next(0, listLength);

            // Pick a new word
            word = _wordList[randomNumber];
        }

        // Call the redact word method
        word.RedactWord();
    }
}