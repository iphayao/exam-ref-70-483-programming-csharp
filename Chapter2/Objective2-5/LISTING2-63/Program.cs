namespace Chapter2
{
    /// <summary>
    /// LISTING 2-63 Using a category attribute in xUnit
    /// </summary>
    class Program
    {
        [Fact]
        [Trait("Category", "Unit Test")]
        public void MyUnitTest() { }

        [Fact]
        [Trait("Category", "Integration Test")]
        public void MyIntegrationTest() { }

        static void Main(string[] args)
        {
        }
    }
}
