using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-61 A complex if statement
    /// </summary>
    class Program
    {
        static void Check(char input)
        {
            if(input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }

        static void Main(string[] args)
        {
            Check('e');
            Check('k');
        }
    }
}
