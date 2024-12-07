using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing beginning/ending messages
        Activity activity = new Activity("Breathing Activity");

        activity.BeginningMessage();
        activity.EndingMessage();
    }
}