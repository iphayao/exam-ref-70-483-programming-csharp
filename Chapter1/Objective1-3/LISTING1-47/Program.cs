using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-47 Boolean OR operator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;

            bool result = x || y;
            Console.WriteLine(result); // Display true
        }
    }
}
