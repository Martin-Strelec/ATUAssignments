namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            var query1 = names.Where(n => n.Length > 4).OrderBy(n => n);
            var query2 = query1.Where(n => n[0] == 'M'); 

            foreach (var name in query2)
            {
                Console.WriteLine(name);
            }
        }
    }
}
