using System;

public class Entry
{
    public string _date; // I believe (public?) class variables (or attributes) like this have an _ in front of their names
    public string _prompt;
    public string _content;

    // Now for the Class's functions (or the methods)

    public void DisplayEntry() // (Public?) Class functions (or methods) like this use TitleCase for their names
    {
        
        
        // Display the user's journal entries of the past and present(?) Or just display what you want to write now?
        Console.Write("> ");
        string journalEntry = Console.ReadLine();
    }

    public void SaveEntry()
    {
        // Save the user's journal entry to a file

        // Prompt for the file name
        // Save to that file
    }
}