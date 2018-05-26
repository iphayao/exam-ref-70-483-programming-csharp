using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-30 Using a ConcurrentBag
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;
            if(bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if(bag.TryPeek(out result))
            {
                Console.WriteLine("There is a next item {0}", result);
            }
        }
    }
}
