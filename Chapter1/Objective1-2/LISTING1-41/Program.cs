using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-41 Compare and exhange as a nonatomic opertion
    /// </summary>
    class Program
    {
        static int value = 1;
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() =>
            {
                if(value == 1)
                {
                    // Reoving the following line will change the output
                    Thread.Sleep(1000);
                    value = 2;
                }
            });

            Task t2 = Task.Run(() =>
            {
                value = 3;
            });

            Task.WaitAll(t1, t2);

            Console.WriteLine(value);
        }
    }
}
