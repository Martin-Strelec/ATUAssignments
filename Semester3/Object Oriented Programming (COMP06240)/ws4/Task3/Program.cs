/*
 * Name: Task 3 
 * Author: M.Strelec
 * Date: 10/9/24
 * Purpose: Task 3 - Objects and Classes Revision
 */

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            BankAccount acc1 = new BankAccount("45576703", "Tom Smith", 1000);
            BankAccount acc2 = new BankAccount("45576754", "Marry Mills", 2000);

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            //Processing
            Console.WriteLine(acc1.DisplayInfo());
            Console.WriteLine(acc2.DisplayInfo());
            acc1.Deposit(1000m);
            Console.WriteLine(acc1.DisplayInfo());
            acc2.Whitdraw(500m);
            Console.WriteLine(acc2.DisplayInfo());

            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}