using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-58 The null-coalescing operator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
