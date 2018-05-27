using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-79 Lambda expression to create a delegate
    /// </summary>
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4)); // Display 7

            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4)); // Display 12
        }
    }
}
