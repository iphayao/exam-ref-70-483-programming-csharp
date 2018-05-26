using System;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-17 Using Parallel.Break
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });
        }
    }
}
