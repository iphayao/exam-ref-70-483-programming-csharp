using System.IO;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-78 Contravariance with delegates
    /// </summary>
    class Program
    {
        static void DoSomething(TextWriter tw) { }

        public delegate void ConTravarianceDel(StreamWriter tw);

        static void Main(string[] args)
        {
            ConTravarianceDel del = DoSomething;
        }
    }
}