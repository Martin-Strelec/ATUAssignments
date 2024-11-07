/*
 * Name: Task 5
 * Author: M.Strelec
 * Date: 9/19/24
 * Purpose: Task 5 - While loop
 */

using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration

            int grade = 0, pointsSum = 0, counter = 1; ;

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            while (true)
            {
                string level;

                Console.WriteLine("Enter -1 to exit...");
                Console.Write($"Enter your grade (0% - 100%) for subject No.{counter}: "); // Grade input * +1 because of styling
                grade = int.Parse(Console.ReadLine());

                if (grade != -1)
                {
                    Console.Write("Was it Higher(H) / Ordinary(O)?: "); // Level input
                    level = Console.ReadLine().ToUpper();
                }
                else
                {
                    break;
                }

                pointsSum += CalculatePoints(grade, level);
                counter++;
            }

            //Output
            Console.WriteLine($"\nYou have {pointsSum} in total.");
            Console.WriteLine("Exiting...");
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
            else if (grade < 70 && grade >= 60) // H4/04
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