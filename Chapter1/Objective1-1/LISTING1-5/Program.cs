using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-5 Using the ThreadStaticAttribute 
    /// </summary>
    class Program
    {
        [ThreadStatic]
        public static int _field;

        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            //Console.ReadKey();
        }
    }
}
