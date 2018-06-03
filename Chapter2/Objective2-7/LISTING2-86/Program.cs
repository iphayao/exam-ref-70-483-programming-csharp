using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-86 Creating a large number of strings
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;

            for(int i = 0; i < 10000; i++)
            {
                s += "x";
            }

            Console.WriteLine(s);
        }
    }
}
