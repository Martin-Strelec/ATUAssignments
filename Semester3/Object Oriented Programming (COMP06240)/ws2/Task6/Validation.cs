/*
*Made by Martin Strelec
*This class is used to validate specific data types. Work in progress..
*Fucntions: Test for data type > string, int, double, decimal
*/

using System.ComponentModel;

namespace QValidation
{
    public class Validation
    {
        //Tests ints. Modifiers: Range, Prompt message
        public int TestIntRange(int init, int end, string message)
        {
            int result;
            Console.Write($"{message}: ");

            if (init == 0 && end == 0)
            {
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
            else
            {
                while (!int.TryParse(Console.ReadLine(), out result) && !(result <= init && result >= end))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
        }

        //Tests strings. Modifiers: Matching string, Prompt message
        public string TestStringMatch(string match, string message)
        {
            bool exit = false;
            string result = "0";

            Console.Write($"{message}: ");
            while (exit == false)
            {
                result = Console.ReadLine();

                if (result != match)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                else
                {
                    exit = true;

                }
            }
            return result;
        }

        //Tests strings. Modifiers: Min and Max Length, lower or UPPER case, Checks if the string isn't a number only,Prompt message

        public string TestStringSpecific(int minLength, int maxLength, int modify, bool isText, string message)
        {
            string validOutput = "0";
            Console.Write($"{message}: ");
            string input = Console.ReadLine();

            if (modify != 0)
            {
                input = modify == 1 ? validOutput.ToUpper() : validOutput.ToLower();
            }

            if (minLength == 0 && maxLength == 0 && isText == true)
            {
                int result;
                while (int.TryParse(input, out result))
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }
                validOutput = input;
            }
            else
            {
                while (true)
                {
                    if (input.Length >= minLength && (input.Length <= maxLength || maxLength == 0))
                    {
                        validOutput = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.Write("> ");
                        input = Console.ReadLine();
                    }
                }
            }

            return validOutput;
        }

        //Tests characters. Modifiers: lower or UPPER case, prompt message, array of valid characters

        public char TestSpecificChars(int modify, string message, params char[] validCharacters)
        {
            try
            {
                char validOutput = 'E';
                int count = 0;
                bool exit = false;
                char input;

                Console.Write($"{message}: ");
                while (!char.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }

                if (modify != 0)
                {
                    input = modify == 1 ? Char.ToUpper(input) : Char.ToLower(input);
                }

                while (exit == false)
                {
                    count = 0;
                    foreach (char c in validCharacters)
                    {
                        if (input == validCharacters[count])
                        {
                            validOutput = input;
                            exit = true;
                            break;
                        }
                        count++;
                    }
                    if (exit == false)
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.Write("> ");
                        while (!char.TryParse(Console.ReadLine(), out input))
                        {
                            Console.Write("> ");
                        }
                    }
                }

                return validOutput;
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return '0';
            
        }

        //Tests double. Modifiers: Range, prompt message
        public double TestDoubleRange(int init, int end, string message)
        {
            double result;
            Console.Write($"{message}: ");

            if (init == 0 && end == 0)
            {
                while (!double.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
            else
            {
                while (!double.TryParse(Console.ReadLine(), out result) && !(result <= init && result >= end))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
        }

        //Test decimal. Modifiers: Range, Prompt Message
        public decimal TestDecimalRange(int init, int end, string message)
        {
            decimal result;
            Console.Write($"{message}: ");

            if (init == 0 && end == 0)
            {
                while (!decimal.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
            else
            {
                while (!decimal.TryParse(Console.ReadLine(), out result) && !(result <= init && result >= end))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
        }
    }
}
