using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int usernumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.:");
        while (usernumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            usernumber = int.Parse(userResponse);
            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

        // Extra: Calculate the minimum and the smallest positive number, also handle the case when there are no positive numbers
        int min = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
        }
        Console.WriteLine($"The min is: {min}");

        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive == int.MaxValue)
        {
            // Extra: Added by me to handle case when there are no positive numbers
            Console.WriteLine("There are no positive numbers.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}