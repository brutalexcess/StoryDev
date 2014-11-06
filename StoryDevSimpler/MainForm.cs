using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Helpers;
using Utilities;

namespace StoryDevSimpler
{
    public partial class MainForm : Form
    {
        private Project p;
        private int previousPassage;
        private int previousEvent;
        private int previousType;

        public MainForm()
        {
            InitializeComponent();

            previousPassage = -1;
            previousEvent = -1;
            previousType = -1;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (p != null)
                p.ExportJson();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var process = new ProcessRichText();
            process.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            cmsOptions.Show(PointToScreen(btnOptions.Location));
        }

        private void btnAddPassage_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
                var passage = new Passage();
                p.AddPassage(passage);
                if (cmbType.SelectedIndex == 0)
                    PopulateList("Passages");
                else
                    cmbType.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("There is no active project.");
            }
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveProj = new SaveFileDialog();
            saveProj.Filter = "StoryDev Project|*.sdp";
            saveProj.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (p == null)
            {
                saveProj.ShowDialog();
                p = new Project(saveProj.FileName);
            }
            else
            {
                var response = MessageBox.Show("Do you wish to save the current project?", "Confirm", MessageBoxButtons.YesNoCancel);
                if (response == System.Windows.Forms.DialogResult.Yes)
                    p.Save(p.file);
                else if (response == System.Windows.Forms.DialogResult.No)
                {
                    saveProj.ShowDialog();
                    p = new Project(saveProj.FileName);
                }
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (p != null)
            {
                pnlMain.Controls.Clear();
                if (cmbType.SelectedIndex == 0)
                {
                    pnlMain.Controls.Add(new RichAndCode());
                    PopulateList("Passages");
                }
                else if (cmbType.SelectedIndex == 1)
                {
                    pnlMain.Controls.Add(new CodeWindow());
                    PopulateList("Game Events");
                }
            }
        }

        private void PopulateList(string type, string searchValue = "")
        {
            lbItems.Items.Clear();
            if (type == "Passages")
            {
                foreach (Passage passage in p.passages)
                {
                    if (searchValue == "")
                        lbItems.Items.Add(passage.id + ": " + passage.title);
                    else
                    {
                        if (passage.title.Contains(searchValue))
                        {
                            lbItems.Items.Add(passage.id + ": " + passage.title);
                        }
                    }
                }
            }
            else if (type == "Game Events")
            {
                foreach (GameEvent e in p.events)
                {
                    if (searchValue == "")
                        lbItems.Items.Add(e.id + ": " + e.title);
                    else
                    {
                        if (e.title.Contains(searchValue))
                        {
                            lbItems.Items.Add(e.id + ": " + e.title);
                        }
                    }
                }
            }
        }

        private void btnAddGameEvent_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
                var ge = new GameEvent();
                p.AddGameEvent(ge);
                if (cmbType.SelectedIndex == 1)
                    PopulateList("Game Events");
                else
                    cmbType.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("There is no active project.");
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbType.SelectedIndex == 0 && txtSearch.Text != "")
                {
                    PopulateList("Passages", txtSearch.Text);
                }
                else if (cmbType.SelectedIndex == 1 && txtSearch.Text != "")
                {
                    PopulateList("Game Events", txtSearch.Text);
                }
                else
                    PopulateList((string)cmbType.SelectedItem);
            }
        }

        private void SaveItem(string type, int selected)
        {
            if ((previousPassage == -1 && type == "Passages") || (previousEvent == -1 && type == "Game Events"))
                return;

            if (type == "Passages" && selected > -1)
            {
                foreach (Passage passage in p.passages)
                {
                    if (passage.id == selected)
                    {
                        var index = p.passages[selected];
                        index.title = txtTitle.Text;
                        index.id = Convert.ToInt32(txtID.Text);
                        var richCode = pnlMain.Controls[0] as RichAndCode;
                        index.htmlText = richCode.RawText;
                        index.text = richCode.CodeText;
                        break;
                    }
                }

            }
            else if (type == "Game Events" && selected > -1)
            {
                foreach (GameEvent ge in p.events)
                {
                    if (ge.id == selected)
                    {
                        var index = p.events[selected];
                        index.title = txtTitle.Text;
                        var code = pnlMain.Controls[0] as CodeWindow;
                        index.code = code.Text;
                        break;
                    }
                }

            }
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                var id = item.Substring(0, item.IndexOf(":"));
                var idc = Convert.ToInt32(id);
                previousPassage = idc;
                foreach (Passage passage in p.passages)
                {
                    if (passage.id == idc)
                    {
                        txtID.Text = id;
                        txtTitle.Text = passage.title;
                        var richCode = pnlMain.Controls[0] as RichAndCode;
                        richCode.CodeText = passage.text;
                        richCode.RawText = passage.htmlText;
                        break;
                    }
                }
            }
            else
            {
                var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                var id = item.Substring(0, item.IndexOf(":"));
                var idc = Convert.ToInt32(id);
                previousEvent = idc;
                foreach (GameEvent ge in p.events)
                {
                    if (ge.id == idc)
                    {
                        txtID.Text = id;
                        txtTitle.Text = ge.title;
                        var code = pnlMain.Controls[0] as CodeWindow;
                        code.Text = ge.code;
                        break;
                    }
                }
            }

        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p.Save(p.file);
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "StoryDev Project|*.sdp";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (p != null)
            {
                var response = MessageBox.Show("Do you wish to save the current project?", "Confirm", MessageBoxButtons.YesNoCancel);
                if (response == System.Windows.Forms.DialogResult.Yes)
                    p.Save(p.file);
                else if (response == System.Windows.Forms.DialogResult.No)
                {
                    ofd.ShowDialog();
                    p.Load(ofd.FileName);
                }
            }
            else
            {
                p = new Project();
                ofd.ShowDialog();
                p.Load(ofd.FileName);
            }
        }

        private void btnTestGame_Click(object sender, EventArgs e)
        {
            if (p != null)
                p.BuildAndTest(Project.FLASH);
        }

        private void copyIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex > -1)
            {
                var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                var id = item.Substring(0, item.IndexOf(":") - 1);
                Clipboard.SetText(id);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex > -1 && cmbType.SelectedIndex > -1)
            {
                if (cmbType.SelectedIndex == 0)
                {
                    var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                    var id = item.Substring(0, item.IndexOf(":") - 1);
                    var idc = Convert.ToInt32(id);
                    p.RemovePassage(idc);
                    PopulateList("Passages");
                }
                else if (cmbType.SelectedIndex == 1)
                {
                    var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                    var id = item.Substring(0, item.IndexOf(":") - 1);
                    var idc = Convert.ToInt32(id);
                    p.RemoveGameEvent(idc);
                    PopulateList("Game Events");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var idc = -1;
            if (lbItems.SelectedIndex > -1)
            {
                var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                var id = item.Substring(0, item.IndexOf(":"));
                idc = Convert.ToInt32(id);
            }

            if (cmbType.SelectedIndex == 0)
                SaveItem("Passages", previousPassage != -1 ? previousPassage : idc);
            else
                SaveItem("Game Events", previousEvent != -1 ? previousEvent : idc);
        }

        private globalKeyboardHook gkh = new globalKeyboardHook();
        private bool ControlDown = false;
        private bool ControlS = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            gkh.HookedKeys.Add(Keys.S);
            gkh.HookedKeys.Add(Keys.Control);
            gkh.KeyUp += gkh_KeyUp;
            gkh.KeyDown += gkh_KeyDown;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.LControlKey) || (e.KeyCode == System.Windows.Forms.Keys.RControlKey))
            {
                ControlDown = true;
            }
            else
            {
                if (ControlDown == true && e.KeyCode == Keys.S)
                {
                    ControlS = true;
                }
            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.LControlKey) || (e.KeyCode == System.Windows.Forms.Keys.RControlKey))
            {
                if (ControlS == true)
                {
                    btnSave.PerformClick();
                    ControlS = false;
                }
                ControlDown = false;
            }
            else
            {
                if (ControlS == true && e.KeyCode == Keys.S)
                {
                    btnSave.PerformClick();
                    ControlS = false;
                }
            }
        }


    }
}
