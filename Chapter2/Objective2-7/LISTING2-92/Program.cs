using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-92 Using StartWith and EndsWith
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string value = "<mycustominpub>";
            if(value.StartsWith("<"))
            {
                Console.WriteLine("Start with <");
            }
            if(value.EndsWith(">"))
            {
                Console.WriteLine("End with >");
            }
        }
    }
}
