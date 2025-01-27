using System.IO;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] files = new DirectoryInfo(@"c:\windows").GetFiles();

            var query = from item in files
                        where item.Length > 10000
                        orderby item.Length descending, item.Name
                        select new
                        {
                            Name = item.Name,
                            Length = item.Length,
                            CreationTime = item.CreationTime,
                        };

            Console.WriteLine("{0,-50}{1,6} MB {2}", "FileName", "Size", "Creation Date");

            foreach (var file in query)
            {
                Console.WriteLine("{0,-50}{1,6} MB {2}", file.Name, file.Length, file.CreationTime.ToShortDateString());
            }

            Console.ReadLine();
        }
    }
}
