using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-95 Iterating over a string
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Custom Value";
            foreach(char c in value)
            {
                Console.WriteLine(c);
            }
        }
    }
}
