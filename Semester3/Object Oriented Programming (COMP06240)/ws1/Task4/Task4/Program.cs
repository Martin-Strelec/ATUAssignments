/*
 * Name: Task 4
 * Author: M.Strelec
 * Date: 9/19/24
 * Purpose: Revision - For loop
 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration

            const int NUMBER_OF_SUBJECTS = 7;
            int pointsSum = 0;
            int[] subjectPoints = new int[NUMBER_OF_SUBJECTS];

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            
            for (int i = 0; i < NUMBER_OF_SUBJECTS; i++) 
            {
                Console.Write($"Enter your grade (0% - 100%) for subject No.{i+1}: "); // Grade input * +1 because of styling
                int grade = int.Parse(Console.ReadLine());

                Console.Write("Was it Higher(H) / Ordinary(O)?: "); // Level input
                string level = Console.ReadLine().ToUpper();

                subjectPoints[i] = CalculatePoints(grade, level);
                pointsSum += CalculatePoints(grade, level);
            }

            //Processing
            //Output

            Console.WriteLine();
            for (int i = 0; i < NUMBER_OF_SUBJECTS; i++) 
            {
                Console.WriteLine($"Subject No.{i}: {subjectPoints[i]} points");
            }
            Console.Write($"\nYou have {pointsSum - LowestGradedSubject(subjectPoints)} points in total...");
            Console.ReadLine();
            Console.WriteLine("\n******End of program******\n");
        }

        static int LowestGradedSubject(int[] array)
        {
            int lowestPoints = array[0];
            foreach (var b in array)
            {
                if (b < lowestPoints)
                {
                    lowestPoints = b;
                }
            }
            return lowestPoints;
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