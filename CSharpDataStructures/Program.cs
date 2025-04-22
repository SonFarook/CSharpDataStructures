using CSharpDataStructures._1._Array;
using CSharpDataStructures._2._Dictionary;
using CSharpDataStructures._3._HashSet;
using CSharpDataStructures._4._Stack;
using CSharpDataStructures._5._Queue;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            StartMenu();

            Console.Write("\nYour selection: ");
            string input = Console.ReadLine();

            Console.Clear();

            if (int.TryParse(input, out int userSelection))
            {
                switch (userSelection)
                {
                    case 0:
                        Console.WriteLine("Exiting program...");
                        return;

                    case 1:
                        ArrayProgram.Run();
                        break;

                    case 2:
                        DictionaryProgram.Run();
                        break;

                    case 3:
                        HashSetProgram.Run();
                        break;

                    case 4:
                        StackProgram.Run();
                        break;

                    case 5:
                        //QueueProgram.Run();
                        break;

                    default:
                        Console.WriteLine("Invalid input. Choose between 0 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }

            ReturnBack();
        }
    }
    public static void ReturnBack()
    {
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }
    public static void ActionCompleted(string message)
    {
        Console.Clear();
        Console.WriteLine(message);
        Program.ReturnBack();
    }
    private static void StartMenu()
    {
        Console.Clear();
        Console.WriteLine("* Welcome to my C# DataStructures App.");
        Console.WriteLine("* This is a basic app for educational purposes.");
        Console.WriteLine("* Choose a number from 1-5 to start the app for the specific data structure.");
        Console.WriteLine("* Feel free to check and use the code :).\n");

        Console.WriteLine("=== Choose an Application ===");
        Console.WriteLine("1 - Array App");
        Console.WriteLine("2 - Dictionary App");
        Console.WriteLine("3 - HashSet App");
        Console.WriteLine("4 - Stack App");
        Console.WriteLine("5 - Queue App");
        Console.WriteLine("0 - Exit");
    }

}
