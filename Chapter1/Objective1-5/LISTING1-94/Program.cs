using System;
using System.IO;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-94 Throwing an ArgumentNullException
    /// </summary>
    class Program
    {
        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException("fileName", "Filename is required");

            return File.ReadAllText(fileName);
        }

        static void Main(string[] args)
        {
            OpenAndParse("");
        }
    }
}
