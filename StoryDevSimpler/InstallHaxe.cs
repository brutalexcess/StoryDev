using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StoryDev
{
    public partial class InstallHaxe : Form
    {
        public InstallHaxe()
        {
            InitializeComponent();
        }

        private void llHaxeToolkit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://haxe.org/download/");
        }

        private void llLaunchCMD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.started = true;
            this.Close();
        }
    }
}
