/*
 * Name: Task7
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision - 2D arrays (Jacked Array)
 */

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            int[][] filmReviews = {
                new int[] {3, 4},
                new int[] { 1 ,2, 1, 3 },
                new int[] {5, 4, 2}
            };
            string[] filmTitles = { "Avengers Endgame","Spider-Man: Far From Home","Once Upon A Time in Hollywood" };
            const string DISPLAY_TAB = "{0,-35}{1,-15}{2,-15}{3,-15}{4,-15}";

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            //Output
            int check = filmReviews.GetLength(0);

            //Displaying the 2D array
            Console.WriteLine(DISPLAY_TAB, "Film Title", "Reviewer 1", "Reviewer 2", "Reviewer 3","Reviewer 4");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            for (int i = 0; i < filmReviews.GetLength(0); i++)
            {
                Console.Write($"{filmTitles[i].PadRight(35)}");
                for (int j = 0; j < filmReviews[i].GetLength(0); j++)
                {
                    string write = Convert.ToString(filmReviews[i][j]).PadRight(15);
                    Console.Write(write);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n******End of program******\n");
        }
    }
}