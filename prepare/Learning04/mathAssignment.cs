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

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
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