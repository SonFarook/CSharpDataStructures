using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructures._5._Queue
{
    internal class QueueProgram
    {
        /*
         * Design a simulation of a customer service ticketing system.
         * Use a Queue to manage the order in which customer tickets are processed.
         * Allow the user to enqueue new tickets and dequeue the next ticket.
         * This project illustrates the First-In-First-Out (FIFO) principle.
        */

        static Queue<string> tickets = new Queue<string>();
        static int i;

        public static void Run()
        {
            while (true) 
            {
                if (tickets.Count == 0)
                    Console.WriteLine("Currently no tickets enqueued.\n");
                
                else 
                {
                    Console.WriteLine("Current ticket queue:");
                    i = 1;
                    foreach(var ticket in tickets)
                    {
                        Console.WriteLine($"{i}. {ticket}\n");
                        i++;
                    }
                }

                ShowMenu();

                Console.Write("Select an option:  ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out int userSelection))
                {
                    switch (userSelection)
                    {
                        case 0:
                            Console.WriteLine("Exiting program...");
                            Console.Clear();
                            return;

                        case 1:
                            EnqueueTicket();
                            break;

                        case 2:
                            DequeueTicket();
                            break;

                        default:
                            Console.WriteLine("ERROR! Invalid choice. Please select a number from 0 to 2.");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("ERROR! Invalid input. Please enter a number.");

                }

                Console.Clear();
            }
        }

        private static void ShowMenu()
        {
            Console.WriteLine("=== Ticket Management Menu ===");
            Console.WriteLine("1 - Enqueue Ticket");
            Console.WriteLine("2 - Dequeue Ticket");
            Console.WriteLine("0 - Exit");
        }

        private static void EnqueueTicket()
        {
            while (true)
            {
                Console.Write("Enter ticket name you want to enqueue: ");

                string inputTicket = Console.ReadLine();

                if (string.IsNullOrEmpty(inputTicket))
                {
                    Console.WriteLine("ERROR! Please enter a valid ticket name!");
                    continue;
                }

                tickets.Enqueue(inputTicket);
                break;
            }
            Program.ActionCompleted($"Enqueued ticket named: \"{tickets.Last()}\"");
        }

        private static void DequeueTicket()
        {
            if (tickets.Count > 0) 
            {
                Program.ActionCompleted($"\"{tickets.Dequeue()}\" got dequeued.");
            }

            else 
            {
                Console.Write("No tickets enqueued. Try again. ");
                Console.ReadKey();
            }
        }
    }
}
