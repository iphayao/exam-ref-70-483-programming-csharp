using System;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-36 Using the lock keyword
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            object _lock = new object();

            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock)
                        n++;
                }
            });

            for(int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                    n--;
            }

            up.Wait();

            Console.WriteLine(n);
        }
    }
}
