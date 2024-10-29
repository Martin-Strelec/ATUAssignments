/*
 * Name: Task5
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision
 */

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            ////Declaration
            //int n1, n2;
            ////Input
            //Console.WriteLine(/*Name of the project or its purpose*/);
            //Console.WriteLine("\n******Start of program******\n");

            //Console.Write("Enter stock on hand figure: ");
            //while (!int.TryParse(Console.ReadLine(), out n1))
            //{
            //    Console.WriteLine("Invalid input!");
            //    Console.Write("> ");
            //}

            //Console.Write("Enter sales figure: ");
            //while (!int.TryParse(Console.ReadLine(), out n2))
            //{
            //    Console.WriteLine("Invalid input!");
            //    Console.Write("> ");
            //}

            ////Processing
            ////Output
            //Console.WriteLine($"Updated?: {Business(n1, n2)}");
            //Console.WriteLine("\n******End of program******\n");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Sulinek");
            }
        }

        static bool Business(int stockOnHand, int sales)
        {
            if (sales <= stockOnHand)
            {
                stockOnHand -= sales;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}