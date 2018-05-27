using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-76 A multiple delegate
    /// </summary>
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        static void Main(string[] args)
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
    }
}
