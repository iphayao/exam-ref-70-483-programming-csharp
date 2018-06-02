using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-20 Implicity converting an integer to a double
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            double d = i;

            Console.WriteLine(d);
        }
    }
}
