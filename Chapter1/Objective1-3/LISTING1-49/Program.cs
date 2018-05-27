using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-49 Using the AND operator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int value = 42;
            bool result = (0 < value) && (value < 100);

            Console.WriteLine(result);
        }
    }
}
