namespace Chapter2
{
    /// <summary>
    /// LISTING 2-34 Using the protected access modifier with inheritance
    /// </summary>
    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;

        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            //_privateField = 41; // Not OK, this will generate a compile error
            _protectedField = 43; // OK, protected fields can be accessed

            // MyPrivateMethod(); // Not OK, this will generate a compiler error
            MyProtectedMethod(); // OK, protected methods can be accessed
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
