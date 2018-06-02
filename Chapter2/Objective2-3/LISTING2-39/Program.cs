namespace Chapter2
{
    /// <summary>
    /// LISTING 2-39 Implementing an interface explicitly
    /// </summary>
    interface IInterfaceA
    {
        void MyMethod();
    }

    class Implentation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
