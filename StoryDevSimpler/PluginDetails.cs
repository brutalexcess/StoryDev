using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StoryDev.API;

namespace StoryDev
{
    public partial class PluginDetails : UserControl
    {
        private TextBox txtDetails;
        public Plugin Plugin { get; private set; }

        private void ShowDescription(bool reverse = false)
        {
            this.Size = reverse ? new Size(414, 23) : new Size(414, 81);
            txtDetails.Visible = !reverse;
        }

        private bool showingDetails;

        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Author { get; private set; }
        public bool Checked { get { return chbTitle.Checked; } }

        public PluginDetails(Plugin p)
        {
            InitializeComponent();

            this.Title = p.Title;
            this.Description = p.Description;
            this.Author = p.Author;

            txtDetails = new TextBox();
            txtDetails.Location = new System.Drawing.Point(0, 26);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.Size = new System.Drawing.Size(414, 55);
            txtDetails.TabIndex = 3;
        }

        private void lblShowHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showingDetails = !showingDetails;
            ShowDescription(showingDetails);
        }
    }
}
