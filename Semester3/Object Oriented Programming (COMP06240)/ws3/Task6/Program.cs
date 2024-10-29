/*
 * Name: Task6
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision
 */

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string[,] filmReviews = { { "Avengers Endgame", "3", "4", "5" }, { "Spider-Man: Far From Home", "1", "2", "1" }, { "Once Upon A Time in Hollywood", "5", "4", "2" } };
            const string DISPLAY_TAB = "{0,-35}{1,-15}{2,-15}{3,-15}"

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            //Output

            //Displaying the 2D array
            Console.WriteLine(DISPLAY_TAB, "Film Title", "Reviewer 1", "Reviewer 2", "Reviewer 3");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            for (int i = 0; i < filmReviews.GetLength(0); i++)
            {
                Console.Write(DISPLAY_TAB, $"{filmReviews[i, 0]}", $"{filmReviews[i, 1]}", $"{filmReviews[i, 2]}", $"{filmReviews[i, 3]}");
                Console.WriteLine();
            }

            Console.WriteLine("\n******End of program******\n");
        }
    }
}