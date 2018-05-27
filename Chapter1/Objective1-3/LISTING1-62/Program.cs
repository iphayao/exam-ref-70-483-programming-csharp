using System;

namespace Chapter1
{
    /// <summary>
    /// LISTING 1-62 A switch statement
    /// </summary>
    class Program
    {
        static void CheckWithSwitch(char input)
        {
            switch(input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    {
                        Console.WriteLine("Input is a vowel");
                        break;
                    }
                case 'y':
                    {
                        Console.WriteLine("Input is sometimes a vowel.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input is a consonant");
                        break;
                    }
            }
        }

        static void Main(string[] args)
        {
            CheckWithSwitch('e');
            CheckWithSwitch('y');
            CheckWithSwitch('z');
        }
    }
}
