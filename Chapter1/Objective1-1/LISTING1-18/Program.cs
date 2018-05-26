using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-18 async and await
    /// </summary>
    class Program
    {
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com");
                return result;
            }
        }

        static void Main(string[] args)
        {
            string result = DownloadContent().Result;
            Console.WriteLine(result);
        }
    }
}
