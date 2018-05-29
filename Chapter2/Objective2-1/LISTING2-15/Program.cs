namespace Chapter2
{
    /// <summary>
    /// LISTING 2-15 Using default(T) with a generic parameter
    /// </summary>

    class Program
    {
        public void MyGenericMethod<T>()
        {
            T defaultValue = default(T);
        }

        static void Main(string[] args)
        {
        }
    }
}
