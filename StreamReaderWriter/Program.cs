using System;
using System.IO;   

namespace StreamReaderWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "StreamReader and STreamWriter";
            WriteToFile();
            ReadFromFile();
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ReadFromFile()
        {
            using (StreamReader sr = File.OpenText(@"D:\table.tbl"))
            {
                string tables = null;

                while ((tables = sr.ReadLine()) != null)
                {
                    Console.WriteLine("{0}", tables);
                }
                Console.WriteLine("Table Printed.");
            }
        }

        public static void WriteToFile()
        {
            using (StreamWriter sw = File.CreateText(@"D:\Table.tbl"))
            {
                sw.WriteLine("Please find the below generated table of 1 to 10");
                sw.WriteLine("");
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        sw.WriteLine("{0}x{1}= {2}", i, j, (i * j));
                    }
                    sw.WriteLine("==============");
                }
                Console.WriteLine("Table successfully written on file.");
            }
        }
    }
}
