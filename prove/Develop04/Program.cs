using System;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\n1. Start breathing activity");
            Console.WriteLine("\n2. Start reflecting activity");
            Console.WriteLine("\n3. Start listing activity");
            Console.WriteLine("\n4. Quit");

            Console.Write("Select a choice from the menu: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                Breathing breathingActivity = new Breathing();
                breathingActivity.SetName("Breathing Activity");

                breathingActivity.BreathingActivity();
            }
        }   
    }
}