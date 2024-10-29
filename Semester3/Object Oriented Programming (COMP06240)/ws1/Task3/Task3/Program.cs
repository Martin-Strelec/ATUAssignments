/*
 * Name: Task 3
 * Author: M.Strelec
 * Date: 9/19/24
 * Purpose: Revision - Nested if
 */

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("Task 3 - Nested if");
            Console.WriteLine("\n******Start of program******\n");

            Console.Write("Enter your grade (0% - 100%): "); // Grade input
            int grade = int.Parse(Console.ReadLine());

            Console.Write("Was it Higher(H) / Ordinary(O)?: "); // Level input
            string level = Console.ReadLine().ToUpper();

            Console.Write($"You have {CalculatePoints(grade, level)} points...");
            Console.ReadLine();

            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static int CalculatePoints(int grade, string level)
        {

            bool isHigher = level == "H" ? true : false;

            if (grade <= 100 && grade >= 90) // H1/01
            {
                return isHigher == true ? 100 : 56;
            }
            else if (grade < 90 && grade >= 80) // H2/02
            {
                return isHigher == true ? 88 : 46;
            }
            else if (grade < 80 && grade >= 70) // H3/03
            {
                return isHigher == true ? 77 : 37;
            }
            else if (grade <70 && grade >= 60) // H4/04
            {
                return isHigher == true ? 66 : 28;
            }
            else if (grade < 60 && grade >= 50) // H5/05
            {
                return isHigher == true ? 56 : 20;
            }
            else if (grade < 50 && grade >= 40) // H6/06
            {
                return isHigher == true ? 46 : 12;
            }
            else if (grade < 40 && grade >= 30) // H7/07
            {
                return isHigher == true ? 37 : 0;
            }
            else if (grade < 30 && grade >= 0) // H8/08
            {
                return isHigher == true ? 0 : 0;
            }
            else
            {
                return -1;
            }
        }
    }
}