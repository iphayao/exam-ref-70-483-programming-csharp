namespace Chapter2
{
    /// <summary>
    /// LISTING 2-63 Creating a custom attribute
    /// </summary>
    public class CategoryAttribute : TraitAttribute
    {
        public CategoryAttribute(string value) 
            : base("Category", value)
        { }
    }

    public class UnitTestAttribute : CategoryAttribute
    {
        public UnitTestAttribute()
            : base("Unit Test")
        { }
    }

    class Program
    {


        static void Main(string[] args)
        {
        }
    }
}
