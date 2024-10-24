using System;

public class Word
{
    private string _word;
    private bool _isRedacted = false;

    // Constructor
    public Word(string word)
    {

    }

    // Methods

    public bool GetRedacted()
    {
        return _isRedacted;
    }
    public void RedactWord()
    { // Transform regular word into its redacted form (a series of underscores)
        string result = "";
        foreach (char character in _word)
        {
            if (char.IsLetter(character))
            {
                result += "_ ";
            }
            else
            {
                result += character;
            }

        }
        _word = result;
        _isRedacted = true;
    }
}