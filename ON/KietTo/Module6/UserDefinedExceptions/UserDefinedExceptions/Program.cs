﻿using System;

namespace UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();

            try
            {
                temp.showTemp();
            }

            catch (TemptIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
        }
    }
}

public class TemptIsZeroException : Exception
{
    public TemptIsZeroException(string message) : base(message)
    {

    }
}

public class Temperature
{
    int temperature = 0;

    public void showTemp()
    {
        if (temperature == -0)
        {
            throw (new TemptIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}
