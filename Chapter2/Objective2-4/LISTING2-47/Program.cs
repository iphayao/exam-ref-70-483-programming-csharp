namespace Chapter2
{
    /// <summary>
    /// LISTING 2-47 Overriding a virtual method
    /// </summary>
    class Base
    {
        protected virtual void Execute() { }
    }

    class Derived : Base
    {
        protected override void Execute()
        {
            Log("Before executing");
            base.Execute();
            Log("After executing");
        }

        private void Log(string message)
        {
            // DO some logging code
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
