namespace Chapter2
{
    /// <summary>
    /// LISTING 2-33 Changing a private field without outside user noticing
    /// </summary>
    public class Accessibility
    {
        // initialization code and error checking omitted
        private string[] _myField;

        public string MyProperty
        {
            get { return _myField[0]; }
            set { _myField[0] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
