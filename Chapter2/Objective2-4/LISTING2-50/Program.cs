using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-50 A Rectangle class with an Area calculation
    /// </summary>
    class Rectangle
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Height { get; set; }
        public int Width { get; set; }

        public int Area
        {
            get 
            {
                return Height * Width;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 6);
            Console.WriteLine(r.Area);
        }
    }
}
