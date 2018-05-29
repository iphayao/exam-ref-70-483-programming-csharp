using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-9 Delaring and using a field
    /// </summary>
    public class MyClass
    {
        public string MyInstanceFiled;

        public string Concatenate(string valueToApped)
        {
            return MyInstanceFiled + valueToApped;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyInstanceFiled = "Some New Value";

            Console.WriteLine(instance.Concatenate(" + Concat Value"));
        }
    }
}
