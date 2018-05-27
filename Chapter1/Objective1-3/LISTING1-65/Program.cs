using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-65 A for loop with multiple loop variables
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for(int x =0, y = values.Length - 1;((x < values.Length) && (y >= 0)); x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }
        }
    }
}
