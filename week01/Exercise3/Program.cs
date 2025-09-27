using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int attempts = 0;
        Console.WriteLine("Welcome to the Number Guessing Game!");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! It took you {attempts} guesses.");

            }
        }
        Console.WriteLine("do you want to play again? (y/n)");
        string playAgain = Console.ReadLine().ToLower();
        if (playAgain == "y")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Thanks for playing!");
        }

    }
}