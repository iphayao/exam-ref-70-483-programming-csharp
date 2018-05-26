using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-6 Using ThreadLocal<T>
    /// </summary>
    class Program
    {
        public static ThreadLocal<int> _filed =
            new ThreadLocal<int>(() =>
            {
                return Thread.CurrentThread.ManagedThreadId;
            });

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < _filed.Value; x++)
                {
                    Console.WriteLine("Thread A: {0}", x);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < _filed.Value; x++)
                {
                    Console.WriteLine("Thread B: {0}", x);
                }
            }).Start();
        }
    }
}
