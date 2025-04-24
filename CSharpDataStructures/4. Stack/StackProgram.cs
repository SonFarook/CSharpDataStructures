using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructures._4._Stack
{
    internal class StackProgram
    {
        /*
         * Develop a program that reverses a text string provided by the user.
         * Use a Stack to push each character of the input string and then pop them to produce
         * the reversed string. This project will help you learn about the Last-In-First-Out (LIFO) concept.
        */

        public static void Run() 
        {
            Stack<char> stack = new Stack<char>();

            Console.Write("Enter a String: ");
            string? userInput = Console.ReadLine();

            foreach (char c in userInput) 
            {
                stack.Push(c);
            }

            //optional: use StringBuilder

            string reversedString = "";

            while (stack.Count > 0) 
            {
                reversedString += stack.Pop();
            }
           
            Console.WriteLine($"{userInput} in reverse is : {reversedString}");
        }
    }
}
