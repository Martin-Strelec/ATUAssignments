/*
 * Name: Task 6 
 * Author: M.Strelec
 * Date: 25/9/24
 * Purpose: Task 6 - Classes and Objects Revision
 */

using QValidation;

namespace Task6
{
    internal class Program
    {

        static List<Student> classroom = new List<Student>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            UserInput();
            //Output
            for (int i = 0; i < classroom.Count; i++)
            {
                classroom[i].DisplayAllSubjectsDetails();
                classroom[i].PrintToFile(@"../../../studentReport.txt");
            }
            Console.WriteLine("\n******End of program******\n");
        }
        static void UserInput()
        {
            Validation userInput = new Validation();

            string[] studentInfo = new string[2];
            bool exit = false;
            int count = 1;

            while (true)
            {
                List<Subject> curriculum = new List<Subject>();

                if (count != 1)
                {
                    if (userInput.TestSpecificChars(1, "Add another Student? (Y / N)", 'Y', 'N') == 'N')
                    {
                        break;
                    }
                    else
                    {
                        count = 1;
                    }
                }

                studentInfo[0] = userInput.TestStringSpecific(3, 0, 0, true, "Enter your name");
                studentInfo[1] = userInput.TestStringSpecific(9, 9, 0, true, "Enter your student number");

                while (true)
                {
                    string subjectName;
                    char subjectLevel;
                    int subjectGrade;

                    Console.WriteLine("");
                    subjectName = userInput.TestStringSpecific(0, 0, 0, true, $"Enter name of subject No. {count}");
                    subjectLevel = userInput.TestSpecificChars(1, "What level? (H/O)", 'H', 'O');
                    subjectGrade = userInput.TestIntRange(0, 100, "What grade? (in %)"); //User is prompted to enter values from 1-8. Decrement of 1 ensures flawless calculation when using the grade as an integer

                    curriculum.Add(new Subject(subjectName, subjectGrade, subjectLevel));

                    Console.WriteLine("");
                    if (userInput.TestSpecificChars(1, "Add another subject? (Y / N)", 'Y', 'N') == 'N')
                    {
                        count++;
                        break;
                    }
                    count++;
                }

                classroom.Add(new Student(studentInfo[0], studentInfo[1], curriculum));
            }
            
            
        } //Handles user input
    }
}