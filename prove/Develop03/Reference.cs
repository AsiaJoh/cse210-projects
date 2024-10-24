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
        _multiVersesUsed = true;
    }

    public Reference(string book, int chapter, int start)
    {
        _multiVersesUsed = false;
    }

    // Actual Methods
    public void DisplayReference()
    {
        if (_multiVersesUsed)
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}-{_verseEnd}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}:{_verseStart}");
        }
    }
}