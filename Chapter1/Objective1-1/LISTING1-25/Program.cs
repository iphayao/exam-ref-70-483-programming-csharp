using System;
using System.Linq;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-25 Making a parallel query sequential
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i % 2 == 0).AsSequential();

            foreach(int i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }

        }
    }
}
