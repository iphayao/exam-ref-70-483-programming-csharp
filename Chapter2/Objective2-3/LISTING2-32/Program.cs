namespace Chapter2
{
    /// <summary>
    /// LISTING 2-32 Using the private access modifier
    /// </summary>
    public class Accessibility
    {
        private string _myField;

        public string MyProperties
        {
            get { return _myField; }
            set { _myField = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
