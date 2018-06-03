using System;
using System.IO;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-81 Forcing a garbage collection
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            GC.Collect();
            GC.WaitForPendingFinalizers();

            File.Delete("temp.dat");
        }
    }
}