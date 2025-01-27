namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query = names.Where(n => n.Length > 4).OrderBy(n => n);

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
