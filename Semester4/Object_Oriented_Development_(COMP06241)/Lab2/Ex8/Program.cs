namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query = names.Where(n => n.Length > 4);

            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }
    }
}
