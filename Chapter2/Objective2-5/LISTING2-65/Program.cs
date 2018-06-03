namespace Chapter2
{
    /// <summary>
    /// LISTING 2-65 Using a custom attribute
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
        [Fact]
        [UnitTest]
        public void MySecoundUnitTest() { }
        static void Main(string[] args)
        {
        }
    }
}
