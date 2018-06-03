using System.IO;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-83 Calling Dispose to free unmange resources
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            stream.Dispose();
            File.Delete("temp.dat");
        }
    }
}
