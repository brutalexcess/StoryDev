using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using StoryDev.API;

namespace StoryDev
{
    public partial class PluginManager : Form
    {
        private List<Plugin> plugins;
        private List<bool> checkedItems;

        public PluginManager()
        {
            InitializeComponent();

            plugins = new List<Plugin>();
            checkedItems = new List<bool>();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (PluginDetails p in pnlPluginList.Controls)
            {
                if (p.GetType() == typeof(PluginDetails))
                {
                    plugins.Add(p.Plugin);
                    checkedItems.Add(p.Checked);
                }
            }

            for (var i = 0; i < plugins.Count; i++)
            {
                if (checkedItems[i])
                {

                }
            }
        }
    }
}
