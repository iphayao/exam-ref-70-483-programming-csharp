using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-2 Creating a custom struct
    /// </summary>
    public struct Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(2, 3);

            Console.WriteLine("x: {0}, y: {1}", point.x, point.y);

        }
    }
}
