using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-54 Code blocks and scoping
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            if(b)
            {
                int r = 42;
                b = false;
            }
            Console.WriteLine(b);
        }
    }
}
