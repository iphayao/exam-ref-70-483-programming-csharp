namespace Chapter1
{
    /// <summary>
    /// LISTING 1-88 Parsing an invalid number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Nan";
            int i = int.Parse(s);
        }
    }
}
