using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-59 Nesting the null-coalescing operator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int? z = null;
            int y = x ??
                    z ??
                    -1;

            Console.WriteLine(y);
        }
    }
}
