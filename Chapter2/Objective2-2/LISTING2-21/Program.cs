using System;
using System.Net.Http;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-21 Implicitly converting an object to a base type
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable d = client;
        }
    }
}
