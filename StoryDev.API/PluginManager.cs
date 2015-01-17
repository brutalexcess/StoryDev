using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace StoryDev.API
{
    public class PluginManager
    {
        private List<Plugin> Plugins { get; set; }
        private bool inited;
        public static PluginManager Manager;

        private void Init()
        {
            if (!inited)
            {
                Plugins = new List<Plugin>();
                inited = true;
            }
        }

        public void AddPlugin(Plugin p)
        {
            Plugins.Add(p);
        }

        public PluginManager()
        {
            
        }

    }
}
