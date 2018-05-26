using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-33 Using a ConcurrentQueue.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            if(queue.TryDequeue(out int result))
            {
                Console.WriteLine("Dequeued: {0}", result);
            }
        }
    }
}
