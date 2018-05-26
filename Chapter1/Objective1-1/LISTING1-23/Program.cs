using System;
using System.Linq;

namespace LISTING1_23
{
    /// <summary>
    /// LISTING 1-23 Unordered parallel query
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResults = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach(int i in parallelResults)
            {
                Console.WriteLine(i);
            }
        }
    }
}
