using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private bool _multiVersesUsed = false;

    // Constructorssss
    public Reference(string book, int chapter, int start, int end)
    {
        // If you use this constructor, set _multiVersesUsed to true
        _multiVersesUsed = true;
    }

    public Reference(string book, int chapter, int start)
    {
        // If you use this constructor, set _multiVersesUsed to false
        _multiVersesUsed = false;
    }

    // Actual Methods
    public void DisplayReference()
    {
        if (_multiVersesUsed) // If there were multiple verses used, include the - in the print statement, between the verses
        {
            Console.Write($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
        else // Otherwise, don't print the - or the end-verse (because there is none)
        {
            Console.Write($"{_book} {_chapter}:{_verseStart}");
        }
    }
}