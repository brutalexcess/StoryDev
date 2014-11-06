using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryDevSimpler
{
    public partial class RichAndCode : UserControl
    {
        private CodeWindow cw;

        public RichAndCode()
        {
            InitializeComponent();

            cw = new CodeWindow();
            cw.Dock = DockStyle.Fill;
            tpCodeEdit.Controls.Add(cw);
        }

        public string RawText
        {
            get { return txtTextEditor.Text; }
            internal set { txtTextEditor.Text = value; }
        }

        public string CodeText
        {
            get { return cw.Text; }
            internal set { cw.Text = value; }
        }
    }
}
