using System;
using System.IO;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-23 Explicitly casting a base type to a derived type
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Object stream = new MemoryStream();
            MemoryStream memoryStream = (MemoryStream)stream;
        }
    }
}
