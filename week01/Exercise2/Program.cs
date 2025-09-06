using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
            if (percentage >= 97)
            {
                letter += "+";
            }
            else if (percentage <= 93)
            {
                letter += "-";
            }
        }
        else if (percentage >= 80)
        {
            letter = "B";
            if (percentage >= 87)
            {
                letter += "+";
            }
            else if (percentage <= 83)
            {
                letter += "-";
            }
        }
        else if (percentage >= 70)
        {
            letter = "C";
            if (percentage >= 77)
            {
                letter += "+";
            }
            else if (percentage <= 73)
            {
                letter += "-";
            }
        }
        else if (percentage >= 60)
        {
            letter = "D";
            if (percentage >= 67)
            {
                letter += "+";
            }
            else if (percentage <= 63)
            {
                letter += "-";
            }
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Better luck next time!"); 
        }
    }
}