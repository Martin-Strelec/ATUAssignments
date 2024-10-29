/*
 * Name: Task 1 - File Read
 * Author: M.Strelec
 * Date: 23/9/24
 * Purpose: File Reading - revision
 */

using System.Reflection;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string pathToFile = @"../../../results.txt";
            string[] fileContent;
            
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            
            //Processing
            try
            {
                int totalPoints = 0, mark, points = 0;

                fileContent = File.ReadAllLines(pathToFile);
                foreach (string s in fileContent)
                {
                    mark = Convert.ToInt32(s);

                    if (mark >= 90)
                    {
                        points = 100;
                    }
                    else if (mark >= 80)
                    {
                        points = 88;
                    }
                    else if (mark >= 70)
                    {
                        points = 77;
                    }
                    else if (mark >= 60)
                    {
                        points = 66;
                    }
                    else if (mark >= 50)
                    {
                        points = 56;
                    }
                    else if (mark >= 40)
                    {
                        points = 46;
                    }
                    else if (mark >= 30)
                    {
                        points = 37;
                    }
                    else
                    {
                        points = 0;
                    }

                    totalPoints += points;
                }

                File.AppendAllText(pathToFile, Environment.NewLine + $"Total Points: {totalPoints.ToString()}");

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
        }
    }
}