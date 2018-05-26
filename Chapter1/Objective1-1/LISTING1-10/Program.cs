using System;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-10 Adding a continuation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            // Display 84
            Console.WriteLine(t.Result);
        }
    }
}
