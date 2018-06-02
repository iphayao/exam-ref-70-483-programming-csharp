using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-22 Casting a double to an initt
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int)x;

            Console.WriteLine(a);
        }
    }
}
