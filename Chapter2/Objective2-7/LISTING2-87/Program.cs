using System;
using System.Text;

namespace LISTING2_87
{
    /// <summary>
    /// LISTING 2-87 Changing a character with StringBuilder
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("A initial value");
            sb[0] = 'B';

            Console.WriteLine(sb.ToString());
        }
    }
}
