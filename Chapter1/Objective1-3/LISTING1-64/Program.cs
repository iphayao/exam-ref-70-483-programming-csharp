using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-64 A basic for loop
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                Console.WriteLine(values[index]);
            }
        }
    }
}
