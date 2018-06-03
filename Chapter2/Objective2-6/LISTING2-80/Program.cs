using System.IO;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-80 Not closing a file will throw an error
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");

            File.Delete("temp.dat"); // Throw an IOException because the file is already open.
        }
    }
}
