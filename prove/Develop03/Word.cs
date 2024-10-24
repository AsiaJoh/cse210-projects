using System;

public class Word
{
    private string _word;
    private bool _isRedacted = false;

    // Constructor
    public Word(string word)
    {

    }

    // Method
    public void RedactWord()
    { // Transform regular word into it's redacted form (a series of underscores)
        string result = "";
        foreach (var letter in _word)
        {
            result += "_ ";

        }
        _word = result;
    }
}