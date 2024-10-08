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

    public void SaveEntry(string journalEntry)
    {
        // Goal: Save the user's journal entry to a file

        // Prompt for the file name
        Console.WriteLine("What will the name of your file be? ");
        string journalName = Console.ReadLine();

        // string path = "C://"; 

        // Save to the content to the file
        // Format for the below is (path, content) 
        File.WriteAllText(journalName, journalEntry); // <-- Somehow I doubt this'll actually work...
    }
}