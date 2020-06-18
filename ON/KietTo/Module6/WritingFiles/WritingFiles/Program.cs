﻿using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace WritingFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "C Sharp", "Working with Files" };

            using (StreamWriter sw = new StreamWriter("writer.txt"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);

                }
            }

            string line = "";            
            using (StreamReader sr = new StreamReader("writer.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);

                }
            }
        }
    }
}
