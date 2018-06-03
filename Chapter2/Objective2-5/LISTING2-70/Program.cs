namespace Chapter2
{
    /// <summary>
    /// LISTING 2-70 Creating a custom plug-in class
    /// </summary>
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(MyApplication application);
    }

    public class MyPlugin : IPlugin
    {
        public string Name
        {
            get { return "MyPlugin"; }
        }

        public string Description
        {
            get { return "My Sample Plugin"; }
        }

        public bool Load(MyApplication application)
        {
            return true;
        }
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
