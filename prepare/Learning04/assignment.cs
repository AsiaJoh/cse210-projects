using System;
class Assignment
{
    protected string _studentName; // The "protected" status means child classes can access it, but other outside things still cannot
    string _topic;

    //Constructors
    public Assignment() 
    {
        // Default values
        _studentName = "John";
        _topic = "learning";
    }

    public Assignment(string studentName, string topic) 
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Methods
    public string GetSummary() {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}