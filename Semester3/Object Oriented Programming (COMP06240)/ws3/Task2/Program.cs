/*
 * Name: Task 2
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision 
 */

using System.Diagnostics.Tracing;
using System.Transactions;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string input;
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter the keyword: ");
            input = Console.ReadLine();
            //Processing
            //Output
            Console.WriteLine($"Your item costs: {ItemCost(input):c}");
            Console.WriteLine("\n******End of program******\n");
        }

        static decimal ItemCost(string input)
        {
            string description = input.ToUpper();
            decimal price;

            switch (description)
            {
                case "JEANS":
                    price = 67.99m;
                    break;

                case "JACKET":
                    price = 68.99m;
                    break;

                case "BOOTS":
                    price = 34.99m;
                    break;

                case "SCARVES":
                    price = 10m;
                    break;

                case "BELTS":
                    price = 10m;
                    break;

                case "SOCKS":
                    price = 10m;
                    break;

                default:
                    price = -999m;
                    break;
            }

            return price;
        }
    }
}