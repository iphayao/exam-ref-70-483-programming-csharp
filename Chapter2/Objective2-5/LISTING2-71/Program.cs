using System;
using System.Linq;
using System.Reflection;

namespace Chapter2
{
    /// <summary>
    /// LISTING 2-71 Inspecting an assembly for types that implement a custom interface
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
            Assembly pluginAssembly = Assembly.Load("assemblyname");

            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach(Type pluginType in plugins)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;
            }
        }
    }

    public class MyApplication
    {
    }
}
