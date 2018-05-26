using System;
using System.Linq;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-24 Ordered parallel query
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach(int i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}
