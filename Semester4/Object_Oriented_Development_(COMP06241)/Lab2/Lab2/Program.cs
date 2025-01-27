namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 7, 6, 78, 4, 5, 2, 4, 5, 2 };

            var outputNumbers = from number in numbers
                                where number > 5
                                orderby number 
                                select number;
            foreach (int n in outputNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
