using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-28 Using BlockingCollection<T>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine("> {0}", col.Take());
                }
            });

            Task write = Task.Run(() =>
            {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) break;
                    col.Add(s);
                }
            });
            write.Wait();
        }
    }
}
