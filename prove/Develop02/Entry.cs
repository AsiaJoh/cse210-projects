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
        // New Goal: Start a new entry, and save it to a file

        // Instance the Journal Class to use what it contains
        Journal journal = new Journal();
        
        // Give a value/title to the variable holding the file we'll save to
        _fileName = "myFile.txt";

        // Instance the streamwriter class(?) in a "using" block so that things close once we're done.
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // Paste in the date, for the file's sake
            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();

            // Call the repurposed prompt function
            string randomPrompt = journal.DisplayPrompt();

            // Put the prompt into the file
            outputFile.WriteLine(randomPrompt);
            
            outputFile.Write("> ");
            _content = Console.ReadLine(); // This goes to the console, but the rest goes to the file
        }
    }
}