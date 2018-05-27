using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-69 while loop
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            {
                int index = 0;
                while(index < values.Length)
                {
                    Console.WriteLine(values[index]);
                    index++;
                }
            }
        }
    }
}
