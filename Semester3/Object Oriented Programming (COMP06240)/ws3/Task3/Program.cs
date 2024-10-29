/*
 * Name: Task 3
 * Author: M.Strelec
 * Date10/3/24
 * Purpose: Revision
 */

using System.Buffers;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            int[] values = {1,2,6,4,7,4};

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Array before: ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]}, ");
            }
            //Processing
            Zero(values);

            //Output
            Console.Write("\nArray after: ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write($"{values[i]}, ");
            }
            Console.WriteLine("\n******End of program******\n");
        }

        static void Zero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
    }
}