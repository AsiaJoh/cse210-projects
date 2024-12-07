class Activity
{
    string _name;
    string _description = "default description woo";
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
        // time;
    }


    //Methods
    public void BeginningMessage() {
        // Determine specific description
        if (_name == "Breathing Activity") {
            _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        } 
        else if (_name == "Reflection Activity") {
            _description = "This activity will help you reflect on times in your life when you have shwon strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        } 
        else if (_name == "Listing Activity") {
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        } 

        // Put together the beginning message
        string message = $"Welcome to the {_name} Activity. \n\n{_description}";
        Console.Clear();
        Console.WriteLine(message);

        string messageDuration = "How long, in seconds, would you like for your session? ";
        Console.Write(messageDuration);
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndingMessage() {
        // Put together the ending message
        string message = $"Well done!! \n\nYou have completed {_duration} seconds of the {_name}.";
        Console.WriteLine(message);
        
        // Loop this until a mini timer reaches zero
        
        // Little animation
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the prior character, and prep for the next (\b works like the left arrow key)
        Console.Write("x"); // Replace with this character
    }

    public void Pause() {
        // Pause the current activity and display animation
    }

    public void Timer() {
        // Set timer for current activity
    }
}
