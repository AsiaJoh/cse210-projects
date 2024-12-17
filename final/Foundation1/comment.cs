class Comment
{
    string _name;
    string _text;

    // Constructor(s)
    public Comment()
    {
        // Assigning the default values
        _name = "Jane Doe";
        _text = "This is a generic comment text.";
    }

    // Method(s)
    public void DisplayComment() {
        // Display name and text in a comment-like fashion  
        string comment = $"@{_name} \n{_text}\n";
        Console.WriteLine(comment);
    }

    // Getters/Setters
    public string GetName() {
        return _name;
    }
    public string GetText() {
        return _text;
    }


    public void SetName(string name) {
        _name = name;
    }
    public void SetText(string text) {
        _text = text;
    }
}