using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-68 A for loop with a continue statement
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for(int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) continue;

                Console.WriteLine(values[index]);
            }
        }
    }
}
