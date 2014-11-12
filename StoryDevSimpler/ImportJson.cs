using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Helpers;
using System.IO;

namespace StoryDev
{
    public partial class ImportJson : Form
    {
        private Project p;
        private Project tempProj;
        private bool isImporting;

        private string _file;
        public string FileName
        {
            get { return _file; }
            set { _file = value; lblJSON.Text = "JSON File: " + _file; }
        }
        public string FullPath;

        public ImportJson(Project p)
        {
            InitializeComponent();

            this.p = p;
            tempProj = new Project();
        }

        private void ImportJson_Load(object sender, EventArgs e)
        {
            if (FileName == "passages.json")
            {
                tempProj.passages = Json.Decode<List<Passage>>(File.ReadAllText(FullPath));
                foreach (Passage passage in tempProj.passages)
                {
                    chbJson.Items.Add(passage.id + ": " + passage.title);
                }
            }
            else if (FileName == "events.json")
            {
                tempProj.events = Json.Decode<List<GameEvent>>(File.ReadAllText(FullPath));
                foreach (GameEvent ev in tempProj.events)
                {
                    chbJson.Items.Add(ev.id + ": " + ev.title);
                }
            }
        }

        private void ImportJson_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isImporting)
            {
                if (FileName == "passages.json")
                {
                    foreach (int obj in chbJson.CheckedIndices)
                    {
                        var item = chbJson.Items[obj].ToString();
                        var id = item.Substring(0, item.IndexOf(":"));
                        var idc = Convert.ToInt32(id);
                        for (var i = 0; i < tempProj.passages.Count; i++)
                        {
                            if (obj == i)
                            {
                                p.AddPassage(tempProj.passages[i]);
                            }
                        }
                    }
                }
                else if (FileName == "events.json")
                {
                    foreach (int obj in chbJson.CheckedIndices)
                    {
                        var item = chbJson.Items[obj].ToString();
                        var id = item.Substring(0, item.IndexOf(":"));
                        var idc = Convert.ToInt32(id);
                        for (var i = 0; i < tempProj.events.Count; i++)
                        {
                            if (obj == i)
                            {
                                p.AddGameEvent(tempProj.events[i]);
                            }
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            isImporting = true;
            Close();
        }
    }
}
