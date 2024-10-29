/*
 * Name: Task 2 
 * Author: M.Strelec
 * Date: 9/19/24
 * Purpose: Revision - Switch
 */

using System.Transactions;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter your grade (H1-H8): ");
            string input = Console.ReadLine();
            Console.Write($"You have {ReturnPoints(input)} points");
            Console.ReadLine();
            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static int ReturnPoints(string input)
        {
            int value;

            switch (input)
            {
                case "H1": 
                    value = 100;
                    break;
                case "H2": 
                    value = 88;
                    break;
                case "H3": 
                    value = 77;
                    break;
                case "H4":
                    value = 66;
                    break;
                case "H5":
                    value = 56;
                    break;
                case "H6":
                    value = 46;
                    break;
                case "H7":
                    value = 37;
                    break;
                case "H8":
                    value = 0;
                    break;
                default: value = -1;
                    break;
            }
            return value;
        }
    }
}