using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-1 Creating a thread with the Thread class
    /// </summary>
    class Program
    {
        public static void ThreadMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main( string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work");
                Thread.Sleep(0);
            }

            t.Join();
        }
    }
}
