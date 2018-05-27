using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-57 A more readable nested if statement
    /// </summary>
    class Program
    {
        public static void F()
        {
            Console.WriteLine("F function invoked");
        }

        public static void G()
        {
            Console.WriteLine("G function invoked");
        }

        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;

            if(x)
            {
                if(y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }
        }
    }
}
