using System;

namespace IPluginDLL
{
    public interface IPlugin
    {
        string Name { get; set; }
        void Action();
    }
}
