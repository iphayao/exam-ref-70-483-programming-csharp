using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-7 Queuing some work to the thread pool
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread form threadpool");
            });
        }
    }
}
