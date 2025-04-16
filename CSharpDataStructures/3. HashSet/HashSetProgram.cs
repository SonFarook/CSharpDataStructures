using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructures._3._HashSet
{
    internal class HashSetProgram
    {
        /*
         * Implement an application that tracks unique tags for blog posts.
         * Use a HashSet to store tags, ensuring that each tag is unique.
         * Provide functionality for adding new tags and displaying all stored tags.
         * This project demonstrates how to use HashSets for quickly checking membership without duplicates.
        */

        static HashSet<string> Tags = new HashSet<string>();
        static int counter = 0;
        public static void Run()
        {
            while (true)
            {
                ShowTags();

                ShowMenu();

                Console.Write("Select an option: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int userSelection))
                {
                    switch (userSelection)
                    {
                        case 0:
                            Console.Clear();
                            return;

                        case 1:
                            AddTag();
                            break;

                        case 2:
                            SearchTag();
                            break;

                        default:
                            Console.WriteLine("ERROR! Invalid choice. Please select a number from 0 to 2.\n");
                            break;
                    }
                }
                Console.Clear();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("=== Select an option ===");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Add Tag");
            Console.WriteLine("2 - Search Tag");
        }
        private static bool CheckTag(string tag)
        {
            if (string.IsNullOrWhiteSpace(tag))
            {
                Console.WriteLine("ERROR! Invalid input. Please try again.\n");
                return false;
            }

            return true;
        }
        private static void ShowTags()
        {
            if (Tags.Count > 0)
            {
                Console.WriteLine($"Current Tags ({Tags.Count}): \n");
                foreach (var tag in Tags)
                {
                    counter++;
                    Console.WriteLine($"{counter}. Tag: {tag}\n");
                }
            }

            else
            {
                Console.WriteLine("Currently no Tags inserted.\n");
            }

            counter = 0;
        }
        private static string? GetTag()
        {
            string? input = Console.ReadLine();

            if (!CheckTag(input))
                return null;
            
            
            if (Tags.Contains((string)input))
            {
                Console.Clear();
                Console.WriteLine("ERROR! Tag is already saved. Try again. \n");
                return null;
            }

            char c = input[0];

            if (char.Equals(c, '#'))
                return input;

            else
                return "#" + input;
            
        }
        private static void AddTag()
        {
            while (true) 
            {
                Console.Write("Enter a tag you want to add: ");
                string? tag = GetTag();
                if (tag == null)
                    return;

                Tags.Add(tag);
                Program.ActionCompleted("Tag successfully added.");
                break;
            }
        }
        private static void SearchTag()
        {
            Console.Clear();
            while (true)
            {
                Console.Write("Enter the tag you want to search: ");
                string? input = Console.ReadLine();

                if (!CheckTag(input))
                    return;

                else
                {
                    if (Tags.Contains((string)input))
                        Console.WriteLine("Tag found.");

                    else
                        Console.WriteLine("Tag not found.");

                    Console.Write("Press any Key to return...");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
