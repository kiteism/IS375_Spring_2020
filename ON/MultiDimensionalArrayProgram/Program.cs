using System;

namespace MultiDimensionalArrayProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a;
            Console.WriteLine("Enter size of Array:-");
            a = int.Parse(Console.ReadLine());
            int[] array = new int [a];
            Console.WriteLine("Enter the Elements of the Arrays:-");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("\n The Elements of the Array are:-");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
            
        }
    }
}
