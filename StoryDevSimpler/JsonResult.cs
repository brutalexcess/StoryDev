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
    public partial class JsonResult : Form
    {
        public JsonResult()
        {
            InitializeComponent();
        }

        public string JSON
        {
            get { return rtbJson.Text; }
            set { rtbJson.Text = value; }
        }
    }
}
