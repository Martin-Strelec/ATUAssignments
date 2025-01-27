namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 7, 6, 78, 4, 5, 2, 4, 5, 2 };

            var outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);
            
            foreach (int n in outputNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
