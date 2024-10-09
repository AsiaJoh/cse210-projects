using System;

public class Journal
{
    public List<string> _prompts = new List<string>(); // The data type is what goes inside the <> for the list
    public List<string> _entries = new List<string>();

    public void DisplayEntry() // (Public?) Class functions (or methods) like this use TitleCase for their names
    {
        // Display the user's journal entries of the past (said entries which are saved to a list)
        
    }

    public static List<string> LoadJournal(string file)
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

        return fileContent; // Not sure if I'll be needing this but here it is
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