using System.Linq;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-22 Using AsParallel
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();
        }
    }
}
