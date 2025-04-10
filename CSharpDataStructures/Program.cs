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
        Console.Write("\nChoose a number from 1-5: ");

        if (int.TryParse(Console.ReadLine(), out int userSelection))
        {
            switch (userSelection)
            {
                case 0:
                    Console.WriteLine("Exiting Application...");
                    break;

                case 1:
                    // Starte das Array-Projekt
                    ArrayProgram.Run();
                    break;

                case 2:
                    // Starte das Dictionary-Projekt
                    //DictionaryProgram.Run();
                    break;

                case 3:
                    // Starte das HashSet-Projekt
                    //HashSetProgram.Run();
                    break;

                case 4:
                    // Starte das Stack-Projekt
                    //StackProgram.Run();
                    break;

                case 5:
                    // Starte das Queue-Projekt
                    //QueueProgram.Run();
                    break;

                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        Console.ReadKey();
    }
}
