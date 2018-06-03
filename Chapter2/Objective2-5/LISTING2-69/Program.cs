namespace Chapter2
{
    /// <summary>
    /// LISTING 2-69 Creating an interface that can be found through reflection
    /// </summary>
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(MyApplication application);
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MyApplication
    {
    }

}
