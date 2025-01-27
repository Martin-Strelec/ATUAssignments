using System.IO;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] files = new DirectoryInfo(@"c:\windows").GetFiles();

            var query = files
                .Where(n => n.Length > 10000)
                .OrderBy(n => n.Length).ThenBy(n => n.Name)
                .Select(n => new
                {
                    Name = n.Name,
                    Length = n.Length,
                    CreationTime = n.CreationTime,
                });

            Console.WriteLine("{0,-50}{1,6} MB {2}", "FileName", "Size", "Creation Date");

            foreach (var file in query)
            {
                Console.WriteLine("{0,-50}{1,6} MB {2}", file.Name, file.Length, file.CreationTime.ToShortDateString());
            }

            Console.ReadLine();
        }
    }
}
