using System;

public class Journal
{
    public List<string> _prompts = new List<string>(); // The data type is what goes inside the <> for the list
    public List<Entry> _entries = new List<Entry>();

    public Entry GetEntry()
    {
        // Retrieve
    }

    public static List<Entry> LoadJournal(string file)
    {
        Entry entry = new Entry();
        
        file = File.ReadAllText(Entry._fileName);
        Console.WriteLine(file);
    }

    // public void SaveJournal(string fileName)
    // {

    // }
}