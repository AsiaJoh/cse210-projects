class Listing : Activity
{
    List<string> _promptList = new List<string>
    {
        "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
    };

    // Constructor
    public Listing()
    {
        
    }

    // Method(s)
    public void ListingActivity() 
    {
        Console.Clear();

        // Start with standard beginning message
        BeginningMessage();

        Thread.Sleep(1000);

        Console.Clear();

        // Activity should continue until duration decided is over.
        // Set timer for current activity
        bool finished = false;
        int itemCounter = 0;

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        Thread.Sleep(300);

        // select a random prompt to show the user
        Random random = new Random();

        int randomIndex = random.Next(_promptList.Count);

        string randomPrompt = _promptList[randomIndex];
        Thread.Sleep(300);
        // After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine(randomPrompt);
        PauseDisplay();

        Console.WriteLine("You may begin in: ");
        Thread.Sleep(300);
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");

        DateTime currentTime = DateTime.Now;
        while (!finished)
        {
            if (currentTime < futureTime)
            {
                Console.ReadLine();
                itemCounter += 1;
            }
            else
            {
                finished = true;
            }
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"You wrote {itemCounter} item(s)");
        PauseDisplay();

        // End with standard ending message
        EndingMessage();
    }
}