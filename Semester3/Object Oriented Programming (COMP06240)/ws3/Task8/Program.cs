/*
 * Name: Task8
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision
 */

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string input;
            List<string> playersName = new List<string>();

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            //Processing
            while (true)
            {
                Console.Write("Enter players name (-1 to exit): ");
                input = Console.ReadLine();
                if (input == "-1")
                {
                    break;
                }
                playersName.Add(input);
            }

            Console.WriteLine("\nThe team:");
            foreach (string s in playersName)
            {
                Console.WriteLine($"{s}");
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}