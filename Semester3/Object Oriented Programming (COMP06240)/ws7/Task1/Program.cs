/*
 * Name: Task 1 - 7
 * Author: M.Strelec
 * Date: 7/11/24
 * Purpose: Objects and classes (Advanced)
 */

using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("Objects and classes (Advanced)");
            Console.WriteLine("\n******Start of program******\n");
            //Processing

            //Objetcs for Task1
            ComputerGames game1 = new ComputerGames("Forza", 59.99m, DateTime.Now);
            ComputerGames game2 = new ComputerGames("Forza", 59.99m);
            ComputerGames game3 = new ComputerGames();

            //Objetcs for Task3
            BoardGame game4 = new BoardGame("Monopoly", 19.99m, new DateTime(1970, 01, 31));
            //Task3
            BoardGame game5 = new BoardGame() {ReleaseDate = new DateTime(2000, 6, 15) };

            //Objects for Task6
            ComputerGames game6 = new ComputerGames("Skyrim", 59.99m, DateTime.Now);
            game6.GetDiscountPrice();
            game6.UpdatePrice(0.2m);

            //Objects for Task7
            BoardGame game7 = new BoardGame("Ladders and Slides", 16.99m, DateTime.Now);
            BoardGame game8 = new BoardGame("Chess", 10.99m);

            ComputerGames game9 = new ComputerGames("Skyrim", 59.99m, DateTime.Now);
            ComputerGames game10 = new ComputerGames("Fallout", 59.99m, DateTime.Now);

            //Output
            Console.WriteLine("Task1");
            Console.WriteLine(game1.ToString());
            Console.WriteLine(game2.ToString());
            Console.WriteLine(game3.ToString());
            Console.WriteLine("Task3");
            Console.WriteLine(game4.ToString());
            Console.WriteLine(game5.ToString());
            Console.WriteLine("Task6");
            Console.WriteLine(game6.ToString());
            Console.WriteLine("Task7");
            Console.WriteLine(game7.ToString());
            Console.WriteLine(game8.ToString());
            Console.WriteLine(game9.ToString());
            Console.WriteLine(game10.ToString());

            Console.WriteLine("Task7");
            DisplayGame(game7);
            DisplayGame(game8);
            DisplayGame(game9);
            DisplayGame(game10);
            Console.WriteLine("\n******End of program******\n");
        }
        //Task 7
        static void DisplayGame(Game game)
        {
            Console.WriteLine("");
        }
    }
}