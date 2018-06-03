using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-91 Using IndexOf and LastIndexOf 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Sample Value";
            int indexOfp = value.IndexOf('p');
            int lastIndexOfm = value.LastIndexOf('m');

            Console.WriteLine("IndexOf: {0}", indexOfp);
            Console.WriteLine("LastIndexOf: {0}", lastIndexOfm);
        }
    }
}
