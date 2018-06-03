namespace Chapter2
{
    /// <summary>
    /// LISTING 2-51 A Square class inherits from Rectangle
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

    class Square : Rectangle
    {
        public Square(int width, int height) : base(width, height) { }
        
        public new int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public new int Height
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
        }
    }
}
