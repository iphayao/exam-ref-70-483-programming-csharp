using System;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-9 Using a Task that returns a value.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 42;
            });

            // Display 42;
            Console.WriteLine(t.Result);
        }
    }
}
