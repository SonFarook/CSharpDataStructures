using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDataStructures._2._Dictionary
{
    internal class DictionaryProgram
    {
        /*
         * Create an application that maps product IDs to product information.
         * Use a Dictionary where each key is a product ID and the value holds details like
         * product name and price. Implement simple search and update functions
         * This project helps you understand key-value pair storage and fast lookup operations.
        */

        static Dictionary<int, string> products = new Dictionary<int, string>();
        static int productID = 1;

        public static void Run()
        {
            // Only add these products if the program runs for the first time
            if (products.Count == 0)
            {
                ManualAddProduct("Product 1");
                ManualAddProduct("Product 2");
                ManualAddProduct("Product 3");
            }

            while (true)
            {
                Console.WriteLine("Current Products:\n");

                foreach (var product in products)
                {
                    Console.WriteLine($"ID: {product.Key}, Description: {product.Value}\n");
                }

                StartMenu();

                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int userSelection))
                {
                    switch (userSelection)
                    {
                        case 0:
                            Console.WriteLine("Exiting program...");
                            Console.Clear();
                            return;

                        case 1:
                            AddProduct();
                            break;

                        case 2:
                            RemoveProduct();
                            break;

                        case 3:
                            UpdateProduct();
                            break;

                        case 4:
                            SearchProduct();
                            break;

                        default:
                            Console.WriteLine("ERROR! Invalid choice. Please select a number from 0 to 4.");
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

        private static void StartMenu()
        {
            Console.WriteLine("=== Product Management Menu ===");
            Console.WriteLine("1 - Add New Product");
            Console.WriteLine("2 - Remove Product");
            Console.WriteLine("3 - Update Product Description");
            Console.WriteLine("4 - Search for Product");
            Console.WriteLine("0 - Exit");
        }

        private static int? GetAndCheckProductID()
        {
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int userSelection) || !products.ContainsKey(userSelection))
            {
                Console.WriteLine("Invalid ID or product not found. Please enter a valid Product ID.");
                return null;
            }

            return userSelection;
        }

        private static string? GetAndCheckProductDescription()
        {
            string? productDescription = Console.ReadLine();

            if (!string.IsNullOrEmpty(productDescription))
            {
                return productDescription;
            }

            Console.WriteLine("ERROR! Invalid description. Please enter a valid product description.");
            return null;
        }

        private static void ManualAddProduct(string productDescription)
        {
            products.Add(productID, productDescription);
            productID++;
        }

        private static void AddProduct()
        {
            while (true)
            {
                Console.Write("Enter the product description: ");
                string? productDescription = GetAndCheckProductDescription();

                if (string.IsNullOrEmpty(productDescription))
                    continue;

                ManualAddProduct(productDescription);
                Program.ActionCompleted("Product added successfully.");
                break;
            }
        }

        private static void RemoveProduct()
        {
            while (true)
            {
                Console.Write("Enter the Product ID to remove: ");
                int? productID = GetAndCheckProductID();

                if (productID == null)
                    continue;

                products.Remove((int)productID);
                Program.ActionCompleted($"Product with ID {productID} removed successfully.");
                break;
            }
        }

        private static void UpdateProduct()
        {
            while (true)
            {
                Console.Write("Enter the Product ID to update: ");
                int? productID = GetAndCheckProductID();

                if (productID == null)
                    continue;

                Console.Write("Enter the new description: ");
                string? productDescription = GetAndCheckProductDescription();

                if (string.IsNullOrEmpty(productDescription))
                    continue;

                products[productID.Value] = productDescription;
                Program.ActionCompleted($"Product with ID {productID} updated to: \"{productDescription}\"");
                break;
            }
        }

        private static void SearchProduct()
        {
            while (true)
            {
                Console.Write("Enter the Product ID to search: ");
                int? productID = GetAndCheckProductID();

                if (productID == null)
                    continue;

                Program.ActionCompleted($"Product Description for ID {productID}: {products[(int)productID]}");
                break;
            }
        }
    }
}