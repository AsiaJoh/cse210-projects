class Activity
{
    string _name;
    string _description;
    int _duration;
    string _endMessage;

    //Constructor(s)
    public Activity(string name, string description, int duration, string endMessage)
    {
        // Assigning the values
        _name = name;
        _description = description;
        _duration = duration;
        _endMessage = endMessage;
    }
    public Activity(string name, string description, int duration, string endMessage, string time)
    {
        // Assigning the values
        _name = name;
        _description = description;
        _duration = duration;
        _endMessage = endMessage;
        time;
    }


    //Methods
    public void BeginningMessage() {
        // Put together the beginning message
        string message = $"{}";
    }

    public void Pause() {
        // Pause the current activity and display animation
    }

    public void Timer() {
        // Set timer for current activity
    }
}
