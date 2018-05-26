using System;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-8 Starting a new Task
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int x = 0; x < 100; x++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            });
            
            t.Wait();
        }
    }
}
