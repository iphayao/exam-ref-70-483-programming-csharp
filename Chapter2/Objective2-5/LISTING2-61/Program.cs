using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-61 Seeing whether an attribute is defined
    /// </summary>
    [Serializable]
    class Person
    {
        
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute))) { }
        }
    }
}
