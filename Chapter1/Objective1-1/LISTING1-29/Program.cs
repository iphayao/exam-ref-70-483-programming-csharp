using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-29 Using GetConsumingEnumurable on a BlockingCollection
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine("> {0}", v);
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
