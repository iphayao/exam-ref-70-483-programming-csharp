using System.IO;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-77 Covariance with delegates
    /// </summary>
    class Program
    {
        public delegate TextWriter ConverianceDel();

        public static StreamWriter MethodStream() { return null; }
        public static StreamWriter MethodString() { return null; }

        static void Main(string[] args)
        {
            ConverianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
