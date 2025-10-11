using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n--- Eternal Quest Menu ---");
                Console.WriteLine("1. Create Simple Goal");
                Console.WriteLine("2. Create Eternal Goal");
                Console.WriteLine("3. Create Checklist Goal");
                Console.WriteLine("4. List Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Show Score");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid option.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateSimpleGoal(manager);
                        break;
                    case 2:
                        CreateEternalGoal(manager);
                        break;
                    case 3:
                        CreateChecklistGoal(manager);
                        break;
                    case 4:
                        manager.ListGoals();
                        break;
                    case 5:
                        RecordEvent(manager);
                        break;
                    case 6:
                        Console.WriteLine($"Total score: {manager.Score}");
                        break;
                    case 7:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void CreateSimpleGoal(GoalManager manager)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points: ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal goal = new SimpleGoal(name, desc, points);
            manager.AddGoal(goal);
        }

        static void CreateEternalGoal(GoalManager manager)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points per event: ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal goal = new EternalGoal(name, desc, points);
            manager.AddGoal(goal);
        }

        static void CreateChecklistGoal(GoalManager manager)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Description: ");
            string desc = Console.ReadLine();
            Console.Write("Points per event: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Target Count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus Points: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, desc, points, target, bonus);
            manager.AddGoal(goal);
        }

        static void RecordEvent(GoalManager manager)
        {
            manager.ListGoals();
            Console.Write("Select goal number to record event: ");
            string input = Console.ReadLine();
            int goalNumber;

            if (!int.TryParse(input, out goalNumber) || goalNumber < 1 || goalNumber > manager.GoalsCount)
            {
                Console.WriteLine("Invalid goal number.");
                return;
            }

            manager.RecordEvent(goalNumber - 1);
        }
    }
}
