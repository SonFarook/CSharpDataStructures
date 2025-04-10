Console.WriteLine("* Welcome to my C# DataStructures App.");
Console.WriteLine("* This is a basic app for educational purposes.");
Console.WriteLine("* Choose a number from 1-5 to start the app for the specific data structure.");
Console.WriteLine("* Feel free to check and use the code :).\n");
Console.WriteLine("=== Choose an Application ===");
Console.WriteLine("1 - Dictionary App");
Console.WriteLine("2 - Queue App");
Console.WriteLine("3 - Stack App");
Console.WriteLine("4 - HashSet App");
Console.WriteLine("5 - Array App");
Console.WriteLine("0 - Exit");

Console.WriteLine("Choose a number from 1-5. ");
int userSelection = int.Parse(Console.ReadLine());

switch (userSelection)
{
    case 0:
        break;

    case 1:
        Console.WriteLine("Dictionary App is running...");
        break;

    case 2:
        Console.WriteLine("Queue App is running...");

        break;

    case 3:
        Console.WriteLine("Stack App is running...");
        break;

    case 4:
        Console.WriteLine("HashSet App is running...");
        break;

    case 5:
        Console.WriteLine("Array App is running...");
        break;

    default:
        Console.WriteLine("Invalid input. Try again.");
        break;
}

Console.ReadKey();

