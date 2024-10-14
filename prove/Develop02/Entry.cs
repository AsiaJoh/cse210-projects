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
            // Display the entries you've made in this session thus far
            
            Console.WriteLine($"{_date}");
            Console.WriteLine($"{_prompt}");
            Console.WriteLine($"{_content}");
        }


    public void WriteEntry()
    {
        // Goal: Start a new entry, and save the user's entry to the list of entries
        // New Goal: Start a new entry, and save it to a file

        // Instance the Journal Class to use what it contains
        Journal journal = new Journal();

        // Display the user's prompt to the console
        _prompt = journal.DisplayPrompt();
        Console.Write("> ");
  
        // Retrieve the date
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        // Prompt was already retrieved upon display

        // Retrieve the user's entry
        _content = Console.ReadLine();

        // Go ahead and add these three things as one to the entries list
        // Entry stringCombined = $"{_date}|{_prompt}|{_content}";
        // journal._entries.Add(stringCombined)
    }
}