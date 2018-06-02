namespace Chapter2
{
    /// <summary>
    /// LISTING 2-38 The IObjectContextAdapter interface
    /// </summary>
    public interface IObjectContextAdapter
    {
        ObjectContext ObjectContext { get; }
    }

    public class ObjectContext
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
