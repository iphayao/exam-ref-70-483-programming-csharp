using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-81 Using the Action delegate
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };

            calc(3, 4);
        }
    }
}
