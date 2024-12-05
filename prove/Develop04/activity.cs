class Activity
{
    string _name;
    string _description;
    int _duration;
    string _endMessage;

    //Constructor(s)
    public Activity(string name)
    {
        // Assigning the values
        _name = name;
    }
    public Activity(string name, string time)
    {
        // Assigning the values
        _name = name;
        time;
    }


    //Methods
    public void BeginningMessage() {
        // Put together the beginning message
        string message = $"Welcome to the {_name} Activity. \n\n{_description}";
        Console.WriteLine(message);

        string messageDuration = "How long, in seconds, would you like for your session? ";
        Console.Write(messageDuration);
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndingMessage() {
        // Put together the ending message
        string message = $"Well done!! \n\nYou have completed {_duration} seconds of the {_name}.";
        Console.WriteLine(message);
        
    }

    public void Pause() {
        // Pause the current activity and display animation
    }

    public void Timer() {
        // Set timer for current activity
    }
}
