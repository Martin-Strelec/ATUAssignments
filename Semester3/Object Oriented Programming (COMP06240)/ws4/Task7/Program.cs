/*
 * Name: Schools Demo - Task 7
 * Author: M.Strelec
 * Date: 10/9/24
 * Purpose: Objects and Classes Revision
 */

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            List<School> education = new List<School>();
            Validation input = new Validation();

            //Input
            Console.WriteLine("Schools Demo");
            Console.WriteLine("\n******Start of program******\n");
            for (int i = 0; i < 3; i++)
            {
                education.Add(new School(input.ModifyStringSpecific(0, 0, 0, true, "Enter school name"), input.ModifyIntRange(0, 0, "Enter enrollment")));
            }

            //Processing
            education.Sort();

            //Output
            foreach (School s in education)
            {
                Console.Write($"\n{s.SchoolName}: {s.NumberOfStudents}");
            }

            if (input.TestSpecificChars("\n\nDisplay Minimum Enrolment(Y)",'Y'))
            {
                Console.WriteLine($"Minimum Enrolment: {education[0].NumberOfStudents}");
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}