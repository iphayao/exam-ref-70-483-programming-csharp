using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-52 Using the Square class
    /// </summary>
    class Rectangle
    {
        public Rectangle() { }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int Area
        {
            get
            {
                return Height * Width;
            }
        }
    }

    class Square : Rectangle
    {
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 10;
            rectangle.Height = 5;

            Console.WriteLine(rectangle.Area);
        }
    }
}
