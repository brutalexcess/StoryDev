using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryDevSimpler
{
    public partial class ProcessRichText : Form
    {
        public ProcessRichText()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcessCopy_Click(object sender, EventArgs e)
        {
            var content = rtbContent.Text;
            content = content.Replace("\n", "\\n");
            content = content.Replace("”", "\\\"");
            content = content.Replace("\"", "\\\"");
            Clipboard.SetText(content);
            Close();
        }
    }
}
