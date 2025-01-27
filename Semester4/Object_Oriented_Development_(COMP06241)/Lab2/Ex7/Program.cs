namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 5, 8, 4, 7, 8 };

            //var query1 = numbers.OrderByDescending(n => n);
            //var query2 = numbers.Where(n => n < 8);
            //var query3 = numbers.Select(n => DoubleIt(n));

            var query1 = from number in numbers
                         orderby number descending
                         select number;

            var query2 = from number in query1
                         where number < 8
                         select number;

            var query3 = from number in query2
                         select DoubleIt(number);

            foreach (var item in query3)
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
