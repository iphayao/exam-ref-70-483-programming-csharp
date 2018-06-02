using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-29 Boxing an integer value
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            object o = i;
            int x = (int)o;

            Console.WriteLine(x);
        }
    }
}
