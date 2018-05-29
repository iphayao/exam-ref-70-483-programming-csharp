namespace Chapter2
{
    /// <summary>
    /// LISTING 2-12 Chaining constructors
    /// </summary>
    class ConstructorChaining
    {
        private int _p;

        public ConstructorChaining() : this(3) { }
        public ConstructorChaining(int p)
        {
            this._p = p;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
