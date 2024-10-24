using System;

public class Scripture
{
    private Reference _reference; // The private is unnecessary, but for the sake of remembering syntax/format I'm going to write it this time
    private List<Word> _text;

    public void DisplayScripture()
    {

    }

    public void RedactScripture()
    { // Choose a random Word, check if it is redacted, then redact said word if not

        // Choosing a random word...
        // Find the length of the word list that is the scripture (index-wise)
        // Generate a random integer within that list (according to it's indexes)
        // Check if the related word is redacted
        if ()
        {

        }
        else{
            // Instance the word class
            Word word = new Word(word);

            // Call the redact word method
            word.RedactWord();
        }
    }
}