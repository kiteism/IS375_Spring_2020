﻿using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 8, 17, 24, 5, 25 };
            int[] divisor = { 2, 0, 0, 5 };
            for (int j = 0; j <number.Length; j++)
            {
                try
                {
                    Console.WriteLine("Number: " + number[j]);
                    Console.WriteLine("Divisor: " + divisor[j]);
                    Console.WriteLine("Quotient: " + number[j] / divisor[j]);
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Not possible to divide by zero");
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is Out of Range");
                }
            }
        }
    }
}
