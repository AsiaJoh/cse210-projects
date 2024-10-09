using System;
using System.Runtime.CompilerServices;

public class Entry
{
    public string _date; // I believe (public?) class variables (or attributes) like this have an _ in front of their names
    public string _prompt;
    public string _content;

    public string _fileName;

    // Now for the Class's functions (or the methods)

    public void GetEntry()
        {
            // Display the entries you've made in this session thus far (the list), OR retrieve a specific entry from the list? But that would require paramaters so probably not.
            
            // Make an instance of the Journal Class to use the entries list within it
            Journal journal = new Journal();

            // Print the entries list (edit fanciness later?)
            foreach (string entry in journal._entries)
            {
                Console.WriteLine(entry);
            }
        }

    public void SaveEntry()
    {
        // Goal: Start a new entry, and save the user's entry to the list of entries? (Perhaps the above function just tries to show the gathered entries, not add or save them?)

        // Instance the Journal Class to use what it contains
        Journal journal = new Journal();

        // Call the repurposed prompt function
        journal.DisplayPrompt();

        Console.Write("> ");
            string _content = Console.ReadLine();

            // Append the new entry to the entries list within Journal
            journal._entries.Add(_content);
    }
}