namespace Chapter2
{
    /// <summary>
    /// LISTING 2-42 Adding a set accessor to an implemented interface property
    /// </summary>
    interface IReadOnlyInterface
    {
        int Value { get; }
    }

    struct ReadAndWriteImplementation : IReadOnlyInterface
    {
        public int Value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
