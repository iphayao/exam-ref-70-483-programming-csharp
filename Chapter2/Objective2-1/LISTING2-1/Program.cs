using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-1 Using the FlagAttribute of an enum
    /// </summary>
    class Program
    {
        enum Days
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }

        static void Main(string[] args)
        {
            Days readingDays = Days.Monday | Days.Saturday;

            Console.WriteLine(readingDays.ToString());
        }
    }
}
