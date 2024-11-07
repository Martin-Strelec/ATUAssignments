/*
 * Name: Task 9
 * Author: M.Strelec
 * Date: 10/3/24
 * Purpose: Revision
 */

using System.Xml.Linq;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string outputFilePath = @"../../../salesReport.txt";
;            FileRead data = new FileRead(@"../../../sales.txt", 2, ',');
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            SalesReport(data.Database,outputFilePath);
            //Output
            Console.WriteLine($"Data written into {outputFilePath}");
            Console.WriteLine("\n******End of program******\n");
        }
        
        static void SalesReport(List<string[]> data, string outputFilePath)
        {
            string announcement;
            try
            {
                for (int i = 0; i < data.Count; i++)
                {
                    int value = Convert.ToInt32(data[i][1]);

                    if (value > 0 && value < 1000)
                    {
                        announcement = "Needs attention!";
                    }
                    else if (value >= 1000 && value <= 1999)
                    {
                        announcement = "Moderate!";
                    }
                    else if (value > 2000)
                    {
                        announcement = "Very Good!";
                    }
                    else
                    {
                        announcement = "Wrong data!";
                    }

                    //Output To File
                    File.AppendAllText(outputFilePath, Environment.NewLine + "\n******************************************************");
                    File.AppendAllText(outputFilePath, Environment.NewLine + $"Store ID: {data[i][0]}");
                    File.AppendAllText(outputFilePath, Environment.NewLine + $"Sale summarization: {announcement}");
                    File.AppendAllText(outputFilePath, Environment.NewLine + "======================================================\n");
                    
                    /*
                    *   Output To Console
                    *
                    *Console.WriteLine($"\nStore ID: {data[i][0]}");
                    *Console.WriteLine($"Sale summarization: {announcement}\n");
                    *
                    */
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            
        } 
    }
}