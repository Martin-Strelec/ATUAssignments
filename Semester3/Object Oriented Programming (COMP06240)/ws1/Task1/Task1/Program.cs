/*
 * Name: Task 1
 * Author: M.Strelec
 * Date: 9/19/24
 * Purpose: Revision - If statements
 */

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("If - revision");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter a grade in percentage: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Your mark: {ReturnMark(input)}");
            Console.ReadLine();
            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static string ReturnMark(string input)
        {
            int percentage = int.Parse(input);

            if (percentage <= 100 && percentage >= 90)
            {
                return "H1/01";
            }
            else if (percentage < 90 && percentage >= 80)
            {
                return "H2/02";
            }
            else if (percentage < 80 && percentage >= 70)
            {
                return "H3/03";
            }
            else if (percentage <= 70 && percentage >= 60)
            {
                return "H4/04";
            }
            else if (percentage <= 60 && percentage >= 50)
            {
                return "H5/05";
            }
            else if (percentage <= 50 && percentage >= 40)
            {
                return "H6/06";
            }
            else if (percentage <= 40 && percentage >= 30)
            {
                return "H7/07";
            }
            else if (percentage <= 30 && percentage >= 0)
            {
                return "H8/08";
            }
            else
            {
                return "Invalid percentage!";
            }
        }
    }
}