using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-51 Using the XOR operator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a);   // Displays False
            Console.WriteLine(a ^ b);   // Displays True
            Console.WriteLine(b ^ b);   // Displays False
        }
    }
}
