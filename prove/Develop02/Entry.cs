using System;
using System.Runtime.CompilerServices;
using System.IO;

public class Entry
{
    public string _date; // I believe (public?) class variables (or attributes) like this have an _ in front of their names
    public string _prompt;
    public string _content;

    public string _fileName;

    // Now for the Class's functions (or the methods)

    public void DisplayEntry()
        {
            // Display the entries you've made in this session thus far (the list)
            
            // Make an instance of the Journal Class to use the entries list within it
            Journal journal = new Journal();

            // Print the entries list (edit fanciness later?)
            foreach (string segment in journal._entries)
            {
                Console.WriteLine(segment);
            }
        }


    public void WriteEntry()
    {
        // Goal: Start a new entry, and save the user's entry to the list of entries
        // New Goal: Start a new entry, and save it to a file

        // Instance the Journal Class to use what it contains
        Journal journal = new Journal();

        // Display the user's prompt to the console
        string randomPrompt = journal.DisplayPrompt();
        Console.Write("> ");
  
        // Retrieve the user's entry
        _content = Console.ReadLine();

        // Now store these things (and the date) into a list
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        journal._entries.Add(dateText);
        journal._entries.Add(randomPrompt);
        journal._entries.Add(_content);
    }

    public void SaveEntry(string fileName)
    {
        // New Goal: Save the entry list to a file

        // Instance the Journal Class to use what it contains
        Journal journal = new Journal();
        
        // Instance the streamwriter class(?) in a "using" block so that things close once we're done.
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string line in journal._entries)
            {
                outputFile.WriteLine(line);
                outputFile.WriteLine("|");
            }
        }
    }
}