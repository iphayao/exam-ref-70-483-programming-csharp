using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-80 Creating a lambda expression with multiple statements
    /// </summary>
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate calc = (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };

            int result = calc(3, 4);
        }
    }
}
