using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-93 Reading a substring
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";
            string subString = value.Substring(3, 6);

            Console.WriteLine(subString);
        }
    }
}
