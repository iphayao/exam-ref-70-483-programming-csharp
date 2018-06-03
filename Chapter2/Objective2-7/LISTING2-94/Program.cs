using System;
using System.Text.RegularExpressions;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-94 Changing a string with a regular expression
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.?)";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };

            foreach(string name in names)
            {
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
            }
        }
    }
}
