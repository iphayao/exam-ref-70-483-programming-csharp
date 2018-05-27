using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-66 A for loop with a custom increment
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index += 2)
            {
                Console.WriteLine(values[index]);
            }
        }
    }
}
