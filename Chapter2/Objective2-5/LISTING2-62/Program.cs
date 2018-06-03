using System;
using System.Diagnostics;

namespace Chapter2
{
    class Program
    {
        [Conditional("Condition1")]
        static void Main(string[] args)
        {
            ConditionalAttribute conditionalAttribute = (ConditionalAttribute)Attribute.GetCustomAttribute(typeof(ConditionalClass), typeof(ConditionalAttribute));

            string conditional = conditionalAttribute.ConditionString;

            Console.WriteLine(conditional);
        }
    }

    class ConditionalClass
    {
    }
}
