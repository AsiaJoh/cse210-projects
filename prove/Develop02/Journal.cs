using System;
using System.IO;
public class Journal
{
    public List<string> _prompts = new List<string>() {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"}; // The data type is what goes inside the <> for the list
    public List<Entry> _entries = new List<Entry>();

    public string DisplayPrompt() // (Public?) Class functions (or methods) like this use TitleCase for their names
    {
        // Create a random object? This must be a built-in or easy-access class
        Random random = new Random();

        // Create a random index within the list's range
        int randomIndex = random.Next(_prompts.Count);

        // Retrieve whatever is at that random index
        string randomPrompt = _prompts[randomIndex];

        // Print said random prompt to the console
        Console.WriteLine(randomPrompt);

        // Return the prompt, so it can also be stored in the file (as that is a different location)
        return randomPrompt;
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal() // No need for this to have the filename parameter, it asks for a name within the function
    {
        // Goal: Save the user's journal entries to a file
        // Prompt for the file name
        Console.WriteLine("What will the name of your file be? ");
        string fileName = Console.ReadLine(); 

        // Instance the streamwriter class(?) in a "using" block so that things close once we're done.
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._content}"); // Save the journal's pieces to the file nicely, and setting it up for LoadJournal's later usage(?)
            }
        }
    }

    public void LoadJournal()
    {
        // Goal: Display a previously saved text file
        // The file path is specified by the file name

        List<Entry> loadedJournal = new List<Entry>(); // Making a new instance of the entries list(?)
        
        // Ask for file name
        Console.Write("What is the filename? ");
        string file = Console.ReadLine();

        // Read the lines from the file into a string array
        string[] fileArray = System.IO.File.ReadAllLines(file);

        // Output the content
        foreach (string line in fileArray)
        {
            // Instance the Entry class
            Entry entry = new Entry();

            // The file should have been stored as a funky string split by |. Now we're going to split the pieces between the "|" into a list whose parts we can use.
            string[] parts = line.Split("|"); //That is, if it would ever worK
            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];

            entry._date = date;
            entry._prompt = prompt;
            entry._content = answer;

            loadedJournal.Add(entry); // Adding the entry class to the new list for future use(?)
        }
        
        _entries = loadedJournal;
    }
}