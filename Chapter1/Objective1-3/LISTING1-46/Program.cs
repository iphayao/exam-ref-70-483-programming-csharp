using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-46 A better readable nested if statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y); // Displays false
            Console.WriteLine(x == z); // Displays true
        }
    }
}
