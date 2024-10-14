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

        // No need to "save" these guys anywhere, I think that's done in the other functions(?)
    }

    // public void SaveEntry(string fileName)
    // {
    //     // New Goal: Save the entry list to a file

    //     // Instance the Journal Class to use what it contains
    //     Journal journal = new Journal();
        
    //     // Instance the streamwriter class(?) in a "using" block so that things close once we're done.
    //     using (StreamWriter outputFile = new StreamWriter(fileName))
    //     {
    //         foreach (string line in journal._entries)
    //         {
    //             outputFile.WriteLine(line);
    //             outputFile.WriteLine("|");
    //         }
    //     }
    // }
}