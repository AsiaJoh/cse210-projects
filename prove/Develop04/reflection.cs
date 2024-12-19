class Reflection : Activity
{
    List<string> _promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
    };
    List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
    };

    // Constructor
    public Reflection()
    {
        
    }

    // Method(s)
    public void ReflectingActivity() 
    {
        Console.Clear();

        // Start with standard beginning message
        BeginningMessage();

        Thread.Sleep(1000);

        Console.Clear();

        // Activity should continue until duration decided is over.
        // Set timer for current activity
        bool finished = false;

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        Thread.Sleep(300);

        // select a random prompt to show the user
        Random random = new Random();

        int randomIndex = random.Next(_promptList.Count);

        string randomPrompt = _promptList[randomIndex];
        Thread.Sleep(300);
        Console.WriteLine(randomPrompt);
        Thread.Sleep(300);

        // After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. These questions should be pulled from a list
        Console.WriteLine("Reflect on these questions in relation to the prompt");


        DateTime currentTime = DateTime.Now;
        while (!finished)
        {
            if (currentTime < futureTime)
            {
                Random random2 = new Random();

                int randomIndex2 = random.Next(_questionList.Count);

                string randomPrompt2 = _questionList[randomIndex2];
                Thread.Sleep(300);
                Console.WriteLine(randomPrompt2);

                // After each question the program should pause for several seconds before continuing to the next one. While the program is paused it should display a kind of spinner.
                PauseDisplay();
            }
            else
            {
                finished = true;
            }
            currentTime = DateTime.Now;
        }

        // End with standard ending message
        EndingMessage();
    }
}