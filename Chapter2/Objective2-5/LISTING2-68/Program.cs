using System;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-68 Adding properties to a custom attribue
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    class CompleteCustomAttribute : Attribute
    {
        public CompleteCustomAttribute(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
