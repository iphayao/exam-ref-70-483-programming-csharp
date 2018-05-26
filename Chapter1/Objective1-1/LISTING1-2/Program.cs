using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-2 Using a background thread
    /// </summary>
    class Program
    {
        public static void ThreadMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
        }
    }
}
