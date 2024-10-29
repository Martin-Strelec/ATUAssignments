/*
 * Name: Cash Registers
 * Author: M.Strelec
 * Date: 10/9/24
 * Purpose: Revision - Objects and Classes
 */

using Task4;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            CashRegister cr1 = new CashRegister();
            CashRegister cr2 = new CashRegister();

            //Input
            Console.WriteLine("Test Cash Register");
            Console.WriteLine("\n******Start of program******\n");

            //Processing
            cr1.AddItem(2.7m);
            cr1.AddItem(3.45m);
            cr1.AddItem(5.97m);
            cr2.AddItem(12.52m);
            cr2.AddItem(1.43m);
            cr2.AddItem(15.57m);
            cr2.AddItem(5.15m);

            //Output
            Console.WriteLine($"\nCash Register: {cr1.ID}\n " +
                $"Total: {cr1.TotalForUnit:c} \n " +
                $"Number of items: {cr1.NumberOfItemsUnit}");
            Console.WriteLine($"\nCash Register: {cr2.ID}\n " +
                $"Total: {cr2.TotalForUnit:c} \n " +
                $"Number of items: {cr2.NumberOfItemsUnit}");
            Console.WriteLine($"\nTotal cash: {CashRegister.TotalForAll:c}\n " +
                $"Total Items: {CashRegister.NumberOfItemsAll} \n ");

        }
    }
}