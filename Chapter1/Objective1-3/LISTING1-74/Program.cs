using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-74 goto statement with label
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3) goto customerLabel;

            Console.WriteLine("Not display");

            customerLabel:
            Console.WriteLine(x);
        }
    }
}
