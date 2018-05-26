using System;
using System.Collections.Concurrent;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-32 Using a ConcurrentStack
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(42);

            if (stack.TryPop(out int result))
            {
                Console.WriteLine("Popped: {0}", result);
            }
            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
                
        }
    }
}
