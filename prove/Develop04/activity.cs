class Activity
{
    string _name;
    string _description = "default description woo";
    int _duration;
    // string _endMessage;

    //Constructor(s)
    public Activity()
    {
        
    }
    // public Activity(string name, string time)
    // {
    //     // Assigning the values
    //     _name = name;
    //     // time;
    // }


    //Methods
    public void BeginningMessage() 
    {
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

    public void EndingMessage() 
    {
        // Put together the ending message
        string message = $"Well done!! \n\nYou have completed {_duration} seconds of the {_name}.";
        Console.WriteLine(message);
        
        bool finished = false;

        // Loop the little animation until a mini timer reaches zero
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        Thread.Sleep(300);

        DateTime currentTime = DateTime.Now;
        while (!finished)
        {
            if (currentTime < futureTime)
            {
                // Little animation
                Console.Write("+");
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the prior character, and prep for the next (\b works like the left arrow key)
                Console.Write("x"); // Replace with this character
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the prior character, and prep for the next (\b works like the left arrow key)
            }
            else
            {
                finished = true;
            }
            currentTime = DateTime.Now;
        }
    }

    public void PauseDisplay() 
    {
        // Pause for a moment and display a little animation
        bool finished = false;

        // Loop the little animation until a mini timer reaches zero
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        Thread.Sleep(300);

        DateTime currentTime = DateTime.Now;
        while (!finished)
        {
            if (currentTime < futureTime)
            {
                // Little animation
                Console.Write("+");
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the prior character, and prep for the next (\b works like the left arrow key)
                Console.Write("x"); // Replace with this character
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the prior character, and prep for the next (\b works like the left arrow key)
            }
            else
            {
                finished = true;
            }
            currentTime = DateTime.Now;
        }
    }

    public bool Timer() 
    {
        // Set timer for current activity
        bool finished = false;

        int placeholder = 0;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Thread.Sleep(300);

        DateTime currentTime = DateTime.Now;
        while (!finished)
        {
            if (currentTime < futureTime)
            {
                placeholder = 0;
            }
            else
            {
                finished = true;
            }
            currentTime = DateTime.Now;
        }


        // Return true, indicating the timer is finished
        return true;
    }

    // Getters/Setters
    public string GetName()
    {
        return _name;
    }


    public void SetName(string name)
    {
        _name = name;
    }
}
