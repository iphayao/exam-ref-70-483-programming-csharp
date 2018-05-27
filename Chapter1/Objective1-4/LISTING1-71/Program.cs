using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-75 Using a delegate
    /// </summary>
    class Program
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y) { return x + y; }
        public static int Multiply(int x, int y) { return x * y; }

        static void Main(string[] args)
        {
            // User deledate
            Calculate calc = Add;
            Console.WriteLine(calc(3, 4));

            calc = Multiply;
            Console.WriteLine(calc(3, 4));
        }
    }
}
