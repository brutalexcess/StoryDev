using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StoryDev
{
    public partial class RichAndCode : UserControl
    {
        private CodeWindow cw;

        public RichAndCode()
        {
            InitializeComponent();

            cw = new CodeWindow();
            cw.Dock = DockStyle.Fill;
            txtTextEditor.KeyUp += RichAndCode_KeyUp;
            cw.KeyUp += RichAndCode_KeyUp;
            tcMain.KeyUp += RichAndCode_KeyUp;
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

        public delegate void keyUp(object sender, KeyEventArgs e);
        public event keyUp onKeyUp;

        private void RichAndCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (onKeyUp != null)
                onKeyUp(sender, e);
        }
    }
}
