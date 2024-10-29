/*
 * Name: Task 5 - Complete program
 * Author: M.Strelec
 * Date: 23/9/24
 * Purpose: Arrays - revision
 */

using System.Numerics;
using System.Reflection;
using QValidation;

namespace Task5
{
    internal class Program
    {

        static string[] studentInfo = new string[2];
        static string[] studentInfoText = { "Student name", "Student number" };
        static string[] subjects = new string[2];
        static int[] grade = new int[subjects.Length];
        static char[] level = new char[subjects.Length];
        static int[] subjectPoints = new int[subjects.Length];

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Header
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            //User input
            UserInput();

            //Processing
            CalculatePoints();

            //Output
            DisplayStats(studentInfo, subjectPoints, subjects);
            WriteToFile(@"../../../results.txt", subjects, subjectPoints);
            Console.WriteLine("\n******End of program******\n");           
        }
        static void CalculatePoints()
        {
            int[] higherPoints = { 100, 88, 77, 66, 56, 46, 37, 0 };
            int[] ordinaryPoints = { 56, 46, 37, 28, 20, 12, 0, 0 };

            int points = 0;

            for (int i = 0; i < subjects.Length; i++)
            {
                subjectPoints[i] = (level[i] == 'H' ? higherPoints[grade[i]] : ordinaryPoints[grade[i]]);
            }
            
        } //Calculates Point 
        static int CalculateTotalPoints(int[] points)
        {
            int totalPoints = 0;

            foreach (int i in points)
            {
                totalPoints += i;
            }

            return totalPoints;
        } //Calculates the total amount of points gained by student
        static void DisplayStats(string[] studentInfo, int[] subjectPoints, string[] subjects)
        {
            Console.WriteLine("\n******************************************************");
           
            for (int i = 0; i < studentInfoText.Length; i++)
            {
                Console.WriteLine($"{studentInfoText[i]}: {studentInfo[i]}");
            }

            Console.WriteLine("");

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"Subject {subjects[i]}: {subjectPoints[i]} points (Level: {level[i]}, Grade: {grade[i]+1})"); //Incrementation done to achieve better readability
            }
            Console.WriteLine($"\nTotal Points: {CalculateTotalPoints(subjectPoints).ToString()}");
            Console.WriteLine("******************************************************\n");
        } //Displays all information about student and detail description of gained points as well as sum of all subjects
        static void WriteToFile(string pathToFile, string[] subjects, int[] subjectPoints)
        {
            File.AppendAllText(pathToFile, Environment.NewLine + "\n******************************************************");

            for (int i = 0; i < studentInfoText.Length; i++)
            {
                File.AppendAllText(pathToFile, Environment.NewLine + $"{studentInfoText[i]}: {studentInfo[i]}");      
            }

            File.AppendAllText(pathToFile, Environment.NewLine + "");

            for (int i = 0; i < subjects.Length; i++)
            {
                File.AppendAllText(pathToFile, Environment.NewLine + $"Subject {subjects[i]}: {subjectPoints[i]} points (Level: {level[i]}, Grade: {grade[i]+1})"); //Incrementation done to achieve better readability
            }
            File.AppendAllText(pathToFile, Environment.NewLine + $"\nTotal Points: {CalculateTotalPoints(subjectPoints).ToString()}");
            File.AppendAllText(pathToFile, Environment.NewLine + "******************************************************\n");
        } //Writes data to a file
        static void UserInput()
        {
            Validation userInput = new Validation();

            studentInfo[0] = userInput.TestStringSpecific(3, 0, 0, true, "Enter your name");
            studentInfo[1] = userInput.TestStringSpecific(9, 9, 0, true, "Enter your student number");

            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine("");
                subjects[i] = userInput.TestStringSpecific(0, 0, 0, true, $"Enter name of subject No. {i + 1}");
                level[i] = userInput.TestSpecificChars(0, "What level? (H/O)", 'H', 'O');
                grade[i] = userInput.TestIntRange(1, 8, "What grade? (1-8)") - 1; //User is prompted to enter values from 1-8. Decrement of 1 ensures flawless calculation when using the grade as an integer
            }
        } //Handles user input
    }
}