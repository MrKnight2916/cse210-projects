using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("====================");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit\n");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.DisplayStartingMessage();
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("\nGoodbye! Take care of yourself.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}
