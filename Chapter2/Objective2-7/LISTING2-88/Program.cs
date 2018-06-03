using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-88 Using a StringBuilder in a loop
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder(string.Empty);

            for(int i = 0; i < 10000; i++)
            {
                sb.Append("x");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
