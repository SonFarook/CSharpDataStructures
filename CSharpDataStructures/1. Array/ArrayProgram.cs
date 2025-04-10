using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructures._1._Array
{
    internal class ArrayProgram
    {
        /*
         * Build a simple program that manages a list of student names in a classroom.
         * Use an array to store the names, allow the user to add a student name,
         * and display all the names. This project demonstrates how to handle fixed-size collections
         * and basic indexing operations.
         */

        public static void Run()
        {
            Console.WriteLine("Array App is running...");

            string[] studentNames = new string[2];

            int count = 0;

            while (true)
            {
                Console.WriteLine("Enter a student name");
                Console.WriteLine("Enter \"Exit\" to exit the Program");

                string? newStudentName = Console.ReadLine()?.Trim(); // Used the Trim() method, to get rid of unnecessary whitespace

                if(string.Equals(newStudentName, "exit", StringComparison.OrdinalIgnoreCase)) // Used OrdinalIgnoreCase to ignore the case of both strings
                {
                    Console.WriteLine("Exiting Program...");

                    if (count == 0) 
                    {
                        Console.WriteLine("No student name was added.");
                    }

                    else
                    {
                        for (int j = 0; j < count; j++)
                        {
                            Console.WriteLine($"{j + 1}. Student: {studentNames[j]}");
                        }
                    }

                    break;
                }

                if (string.IsNullOrEmpty(newStudentName)) 
                {
                    Console.WriteLine("Invalid input. Please enter a valid name.");
                    continue;
                }

                // Resize the Array by twice the size, every time the array cant hold any more items
                if (count == studentNames.Length) 
                {
                    Array.Resize(ref studentNames, studentNames.Length * 2);
                }

                studentNames[count] = newStudentName;
                count++;
            }

            Console.ReadKey();
        }
    }
}
