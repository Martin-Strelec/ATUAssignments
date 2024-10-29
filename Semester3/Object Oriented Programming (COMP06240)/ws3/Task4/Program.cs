/*
 * Name: Task 4
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision
 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            int n1, n2;
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            
            //First number
            Console.Write("Enter the first number: ");
            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Invalid Input!");
                Console.Write("> ");
            }
            
            //Second number
            Console.Write("Enter the second number: ");
            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Invalid Input!");
                Console.Write("> ");
            
            }

            //Output
            Console.WriteLine($"Sum bewtween number {n1} and {n2} is: {Sum(n1,n2)}");
            Console.WriteLine("\n******End of program******\n");
        }

        static int Sum(int n1, int n2)
        {
            int result = 0;

            for (int i = n1; i <= n2; i++)
            {
                result += i;
            }

            return result;
        }
    }
}