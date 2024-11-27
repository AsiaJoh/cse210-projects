// Time for the derived/child class MathAssignment!
class WritingAssignment : Assignment
{
    string _title;

    //Constructors (we'll be calling the parent ones for inheritance via "base"!)
    public WritingAssignment() : base()
    {
        // Default values
        _title = "Yiddles Yodles";
    }

    // "Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor."
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    //Methods
    public string GetWritingInformation() {
        string writingInfo = $"The {_title} by {_studentName}";
        return writingInfo;
    }
}