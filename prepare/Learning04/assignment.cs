using System;
class Assignment
{
    string _studentName;
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

// Time for the derived/child class MathAssignment!
class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    //Constructors (we'll be calling the parent ones for inheritance via "base"!)
    public MathAssignment() : base()
    {
        // Default values
        _textbookSection = "3";
        _problems = "1-10";
    }

    public MathAssignment(string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Methods
    public string GetHomeworkList() {
        string homeworkList = $"Section #{_textbookSection}, problem(s): {_problems}";
        return homeworkList;
    }
}