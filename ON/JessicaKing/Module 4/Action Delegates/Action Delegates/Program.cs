using System;

namespace Action_Delegates
{
    class Program
    {
        public static void myfun(int p, int q)
        {
            Console.WriteLine(p - q);
        }

        //Main method
        static public void Main()
        {

            //using action delegate
            //here, action delegate
            //contains two input parameters
            Action<int, int> val = myfun;
            val(20, 5);
        }
    }
}
