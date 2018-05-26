using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-19 Scalability versus responsiveness
    /// </summary>
    class Program
    {
        public static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }

        static void Main(string[] args)
        {
            SleepAsyncA(100000000);
            Console.WriteLine("After SleppAsyncA");
            SleepAsyncB(100000000);
        }
    }
}
