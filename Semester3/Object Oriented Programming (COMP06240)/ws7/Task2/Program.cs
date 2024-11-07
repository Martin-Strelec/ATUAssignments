/*
 * Name: Task 2 - Extension Method
 * Author: M.Strelec
 * Date: 11/7/24
 * Purpose: Word Counter
 */

using System.Runtime.CompilerServices;
using System.Linq;

namespace Task2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string words1 = "And you know what they call a... a... a Quarter Pounder with Cheese in Paris?";
            string words2 = "They don't call it a Quarter Pounder with cheese?";
            //Input
            Console.WriteLine("Extension Method - Word Counter");
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"{words1}");
            Console.WriteLine($"This sentence has {words1.WordCount()} words.");
            Console.WriteLine($"{words2}");
            Console.WriteLine($"This sentence has {words2.WordCount()} words.");
            Console.WriteLine("\n******End of program******\n");
        }
        public static int WordCount(this string text)
        {
            string[] words = text.Split(" ");
            int count = words.Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "")
                {
                    count--;
                }
            }
            return count;
        }
    }
}