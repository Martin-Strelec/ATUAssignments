namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 8, 4, 7, 8 };

            var query = numbers.Select(n => DoubleIt(n));

            Console.WriteLine("Before the foreach loop");

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
        private static int DoubleIt(int value)
        {
            Console.WriteLine("About to double the number " + value.ToString());
            return value * 2;
        }
    }
}
