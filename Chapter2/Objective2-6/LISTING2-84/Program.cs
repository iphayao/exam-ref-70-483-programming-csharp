using System;
using System.IO;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-84 Implementing IDisposable and finalizer
    /// </summary>
    class UnmangeWrapper : IDisposable
    {
        public FileStream Stream { get; private set; }

        public UnmangeWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }

        ~UnmangeWrapper()
        {
            Dispose(false);
        }

        public void Close()
        {
            Dispose();
        }

        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(Stream != null)
                {
                    Stream.Close();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
