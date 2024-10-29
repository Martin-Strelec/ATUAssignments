

/*
 * Name: Task4 
 * Author: M.Strelec
 * Date: 10/9/24
 * Purpose: Revision - Objects and Classes
 */

namespace Task4
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
                $"Total: {cr1.Total:c} \n " +
                $"Number of items: {cr1.NumberOfItems}");
            Console.WriteLine($"\nCash Register: {cr2.ID}\n " +
                $"Total: {cr2.Total:c} \n " +
                $"Number of items: {cr2.NumberOfItems}");

            Console.WriteLine("\n******End of program******\n");
        }
    }
}
