/*
 * Name: Lunch Demo (Task 6 - Revision)
 * Author: M.Strelec
 * Date: 10/9/24
 * Purpose: Objects and Classes - Revision
 *          Use of PARAMS keyword
 */

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            Lunch l1, l2, l3, l4, l5;
            l1 = new Lunch();
            l2 = new Lunch();
            l3 = new Lunch();
            l4 = new Lunch();
            l5 = new Lunch();

            //Input
            Console.WriteLine("Lunch Demo");
            Console.WriteLine("\n******Start of program******\n");

            //Processing
            l1.Entree = "Hamburger";
            l1.Side = "Fries";
            l1.Drink = "Cola";

            l2.Entree = "Hot Dog";
            l2.Side = "Chips";
            l2.Drink = "Lemonade";

            l3.Entree = "Pizza";
            l3.Side = "Salad";
            l3.Drink = "Iced Tea";

            l4.Entree = "Tuna sandwich";
            l4.Side = "Fruit Cup";
            l4.Drink = "Water";

            l5.Entree = "PBJ";
            l5.Side = "Cookie";
            l5.Drink = "Milk";

            //Output
            DisplayMenu(l1, l2, l3);
            DisplayMenu(l1, l2, l3, l4);
            DisplayMenu(l1, l2, l3, l4, l5);

            Console.WriteLine("\n******End of program******\n");
        }

        static void DisplayMenu(params Lunch[] lunches) 
        {
            const string OUTPUT_TAB = "{0,-30}{1,-20}{2,-20}";

            Console.WriteLine();
            Console.WriteLine(OUTPUT_TAB,"Entree","Side","Drink");
            
            foreach (Lunch l in lunches)
            {
                Console.WriteLine(OUTPUT_TAB,$"{l.Entree}",$"{l.Side}",$"{l.Drink}");
            }
        }
    }
}