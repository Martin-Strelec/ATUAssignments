/*
 * Name: Task 2 - Arrays
 * Author: M.Strelec
 * Date: 23/9/24
 * Purpose: Arrays - revision
 * This Task2 includes Tasks 3 & 4
 */

using System.Numerics;
using System.Reflection;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string pathToFile = @"../../../results.txt";
            string[] fileContent = Array.Empty<string>();
            int[] boundaries = { 90, 80, 70, 60, 50, 40, 30 };
            int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37 };

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            try
            {
                fileContent = File.ReadAllLines(pathToFile);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) //Extra line after apending for the first time results in error when reading for the second time
            {
                Console.WriteLine(e.Message);
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
            File.AppendAllText(pathToFile, Environment.NewLine + $"Total Points: {CalculatePoints(boundaries, higherPoints, fileContent).ToString()}");
        }

        static int CalculatePoints(int[] boundaries, int[] points, string[] values)
        {

            int totalPoints = 0, mark;

            foreach (string s in values)
            {
                mark = Convert.ToInt32(s);

                for (int i = 0; i < boundaries.Length; i++)
                {
                    if (mark >= boundaries[i])
                    {
                        totalPoints += points[i];
                        break;
                    }
                }
            }

            return totalPoints;
        }
    }
}