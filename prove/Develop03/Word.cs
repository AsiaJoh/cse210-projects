using System;

public class Word
{
    private string _word;
    private bool _isRedacted = false;

    // Constructor
    public Word(string word)
    {
        _word = word;
    }

    // Methods
    public bool GetRedacted()
    {
        return _isRedacted;
    }

    public string GetWord()
    {
        return _word;
    }

    public void RedactWord()
    { // Transform regular word into its redacted form (a series of underscores)
        string result = "";
        foreach (char character in _word)
        {
            if (char.IsLetter(character)) // If the character being examined is a letter...
            { // Add an _ to the result variable
                result += "_";

            }
            else // Otherwise
            {
                result += character; // Add the character you're reading (probably some form of punctuation) to the result variable
            }
        }
        // Assign the result to the word, now making this word "redacted"
        _word = result; 
        // Change the label to "redacted" so the program can detect that, and not re-redact it in the future
        _isRedacted = true;
    }
}