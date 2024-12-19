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

        Thread.Sleep(3000);

        Console.Clear();

        bool timerFinished = Timer();

        // Activity should continue until duration decided is over.
        while (!timerFinished)
        {
            // Show a series of messages alternating between "Breathe in..." and "Breathe out..."
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("1");
            Thread.Sleep(1000);
            
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);

            Console.Clear();
        }

        // End with standard ending message
        EndingMessage();
    }
}