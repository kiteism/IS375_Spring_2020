using System;
using System.IO;

namespace ReadingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("test.txt");
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
