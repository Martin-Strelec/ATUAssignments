/*
 * Name: 
 * Author: M.Strelec
 * Date:
 * Purpose: 
 */

using System.Numerics;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            int input;

            //Input
            Console.WriteLine("Age range (18-21)");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter your age: ");
            while(!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("> ");
            }

            //Processing
            if (AllowUser(input) == true)
            {
                Console.WriteLine("You are allowed to access the website!");
            }
            else
            {
                Console.WriteLine("You are not allowed to access the website!");
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static bool AllowUser(int age)
        {
            bool result;

            if (age >= 18 && age <= 21)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}