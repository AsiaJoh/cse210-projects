using System;

class Program
{
    static void Main(string[] args)
    {
        // Guessing Number Game
       
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);

        Console.WriteLine("A magic secret number has been generated.");

        string strGuessNum = "";
        int guessNum = 0;

        while (magicNum != guessNum)
        {
            Console.Write("What is your guess? ");
            strGuessNum = Console.ReadLine();
            guessNum = int.Parse(strGuessNum);

            if (magicNum > guessNum)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNum < guessNum)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        } 
    }
}