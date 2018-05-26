using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-45 Setting a timeout on a task
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });

            int index = Task.WaitAny(new[] { longRunning }, 1000);

            if (index == -1)
                Console.WriteLine("Task timed out");
        }
    }
}
