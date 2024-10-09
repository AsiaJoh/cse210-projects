using System;

public class Journal
{
    public List<string> _prompts = new List<string>() {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"}; // The data type is what goes inside the <> for the list
    public List<string> _entries = new List<string>();

    public void DisplayEntry() // (Public?) Class functions (or methods) like this use TitleCase for their names
    {
        // Display a random prompt?? (Otherwise this would be redundant)

        // Create a random object? This must be a built-in or easy-access class
        Random random = new Random();

        // Create a random index within the list's range
        int randomIndex = random.Next(_prompts.Count);

        // Retrieve whatever is at that random index
        string randomPrompt = _prompts[randomIndex];

        // Print said random prompt
        Console.WriteLine(randomPrompt);
        
    }

    // public static List<string> LoadJournal(string file)
    public void LoadJournal(string file)
    {
        // Goal: Display a previously saved text file
        // The file path is specified by the file name, the parameter

        // Read the lines from the file into a string array
        string[] fileArray = File.ReadAllLines(file);

        // Convert the string array to a list
        List<string> fileContent = fileArray.ToList();

        // Print the content
        foreach (string line in fileContent)
        {
            Console.WriteLine(line);
        }
        // Not sure if I'll be needing this but here it is
        // return fileContent; 
    }

    public void SaveJournal() // No need for this to have the filename parameter, it asks for a name within the function
    {
        // Goal: Save the user's journal entries to a file

        // Prompt for the file name
        Console.WriteLine("What will the name of your file be? ");
        string fileName = Console.ReadLine(); 

        // Save to the content to the file
        // Format for the below is (path, content) 
        File.WriteAllLines(fileName, _entries); // <-- Somehow I doubt this'll actually work...
    }
}