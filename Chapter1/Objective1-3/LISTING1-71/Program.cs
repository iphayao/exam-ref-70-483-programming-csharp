using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-71 foreach loop
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
        }
    }
}
