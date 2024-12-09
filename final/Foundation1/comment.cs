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