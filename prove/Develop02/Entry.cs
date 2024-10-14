using System;
using System.IO;

public class Entry
{
    public string _date; // I believe (public?) class variables (or attributes) like this have an _ in front of their names
    public string _prompt;
    public string _content;

    // public string _fileName;

    // Now for the Class's functions (or the methods)

    public void DisplayEntry()
        {
            // Display the entries list in a nice manner
            
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
            Console.WriteLine($"{_content}");
            Console.WriteLine();
        }
}