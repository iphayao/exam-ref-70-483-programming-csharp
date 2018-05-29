namespace Chapter2
{
    /// <summary>
    /// LISTING 2-14 Using a where clause on a class defination
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyClass<T> where T : class, new ()
    {
        public MyClass()
        {
            MyProperty = new T();
        }

        T MyProperty { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
