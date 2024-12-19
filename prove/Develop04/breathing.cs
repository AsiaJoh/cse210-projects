class Breathing : Activity
{
    // Constructor
    public Breathing()
    {
        
    }

    // Method(s)
    public void BreathingActivity() 
    {
        Console.Clear();

        // Start with standard beginning message
        BeginningMessage();

        Thread.Sleep(1000);

        Console.Clear();

        // bool timerFinished = false;

        // Timer();

        // Activity should continue until duration decided is over.
        // Set timer for current activity
        bool finished = false;

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        Thread.Sleep(300);

        DateTime currentTime = DateTime.Now;
        while (!finished)
        {
            if (currentTime < futureTime)
            {
                Console.WriteLine("Breathe in...");
                Thread.Sleep(500);
                Console.Write("3");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.WriteLine("1");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                
                Console.WriteLine("Breathe out...");
                Thread.Sleep(500);
                Console.Write("3");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.Write("2");
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.WriteLine("1");
                Thread.Sleep(1000);
                Console.Write("\b \b");

                Console.Clear();
            }
            else
            {
                finished = true;
            }
            currentTime = DateTime.Now;
        }

        
        // while (!timerFinished)
        // {
            // Show a series of messages alternating between "Breathe in..." and "Breathe out..."
            
        // }

        // End with standard ending message
        EndingMessage();
    }
}