namespace Chapter2
{
    /// <summary>
    /// LISTING 2-36 Encapsulating a field with custom methods
    /// </summary>
    class Program
    {
        private int _field;
        public void SetValue(int value)
        {
            _field = value;
        }
        public int GetValue()
        {
            return _field;
        }

        static void Main(string[] args)
        {
        }
    }
}
