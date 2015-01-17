using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Helpers;
using System.Diagnostics;
using System.Text.RegularExpressions;
using StoryDev.API;

namespace StoryDev
{
    public partial class MainForm : Form
    {
        private Project p;
        private int previousPassage;
        private int previousEvent;
        private int previousType;
        private string previousPath;
        private static List<Plugin> initialisedPlugins;

        public static bool checkPlugin(string author, string title)
        {
            foreach (Plugin p in initialisedPlugins)
            {
                if (p.Author == author && p.Title == title)
                    return true;
            }
            return false;
        }

        public static void initialisePlugin(Plugin pl)
        {

        }

        public MainForm()
        {
            InitializeComponent();

            foreach (CodeWindow cw in Controls)
            {
                
            }

            previousPassage = -1;
            previousEvent = -1;
            previousType = -1;

            if (!Properties.Settings.Default.started)
                new InstallHaxe().ShowDialog();
            if (Properties.Settings.Default.previousPath == "")
                previousPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            else
                previousPath = Properties.Settings.Default.previousPath;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var process = new ProcessRichText();
            process.ShowDialog();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            var pt1 = PointToScreen(panel3.Location);
            var pt2 = btnOptions.Location;
            var pt3 = new Point(pt1.X + pt2.X, pt1.Y + pt2.Y);
            cmsOptions.Show(pt3);
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
            saveProj.InitialDirectory = previousPath;
            saveProj.FileOk += saveProj_FileOk;
            saveProj.ShowDialog();
        }

        void saveProj_FileOk(object sender, CancelEventArgs e)
        {
            var saveProj = sender as SaveFileDialog;
            if (!e.Cancel)
            {
                if (p == null)
                {
                    p = new Project(lastDirectory(saveProj.FileName));
                }
                else
                {
                    var response = MessageBox.Show("Do you wish to save the current project?", "Confirm", MessageBoxButtons.YesNoCancel);
                    if (response == System.Windows.Forms.DialogResult.Yes)
                        p.Save(p.file);
                    else if (response == System.Windows.Forms.DialogResult.No)
                    {
                        p = new Project(lastDirectory(saveProj.FileName));
                    }
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
                    previousType = 0;
                    var richCode = new RichAndCode();
                    richCode.onKeyUp += onKeyUp;
                    pnlMain.Controls.Add(richCode);
                    PopulateList("Passages");
                }
                else if (cmbType.SelectedIndex == 1)
                {
                    previousType = 1;
                    var code = new CodeWindow();
                    code.KeyUp += onKeyUp;
                    pnlMain.Controls.Add(code);
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
            else if (type == "Scenes")
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
                    PopulateList("Scenes");
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
            if (p != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (cmbType.SelectedIndex == 0 && txtSearch.Text != "")
                    {
                        PopulateList("Passages", txtSearch.Text);
                    }
                    else if (cmbType.SelectedIndex == 1 && txtSearch.Text != "")
                    {
                        PopulateList("Scenes", txtSearch.Text);
                    }
                    else
                        PopulateList((string)cmbType.SelectedItem);
                }
            }
        }

        private void SaveItem(string type, int selected)
        {
            if ((previousPassage == -1 && type == "Passages") || (previousEvent == -1 && type == "Scenes"))
                return;

            if (!isNumeric(txtID.Text))
            {
                MessageBox.Show("The ID provided is not a valid integer value.");
                return;
            }

            if (type == "Passages" && selected > -1)
            {
                foreach (Passage passage in p.passages)
                {
                    if (passage.id == selected)
                    {
                        var index = p.passages[p.passages.IndexOf(passage)];
                        index.title = txtTitle.Text;
                        if (!conflictID("Passages", Convert.ToInt32(txtID.Text)))
                            index.id = Convert.ToInt32(txtID.Text);
                        var richCode = pnlMain.Controls[0] as RichAndCode;
                        index.htmlText = richCode.RawText;
                        index.text = richCode.CodeText;
                        break;
                    }
                }

            }
            else if (type == "Scenes" && selected > -1)
            {
                foreach (GameEvent ge in p.events)
                {
                    if (ge.id == selected)
                    {
                        var index = p.events[p.events.IndexOf(ge)];
                        if (!conflictID("Scenes", Convert.ToInt32(txtID.Text)))
                            index.id = Convert.ToInt32(txtID.Text);
                        index.title = txtTitle.Text;
                        var code = pnlMain.Controls[0] as CodeWindow;
                        index.code = code.Text;
                        break;
                    }
                }

            }
        }

        private bool conflictID(string type, int id)
        {
            if (type == "Passages")
            {
                var amount = p.passages.Count;
                foreach (Passage passage in p.passages)
                {
                    if (passage.id == id)
                        return true;
                    else if (amount == 1)
                        return false;
                    else
                        amount--;
                }
            }
            else
            {
                var amount = p.events.Count;
                foreach (GameEvent e in p.events)
                {
                    if (e.id == id)
                        return true;
                    else if (amount == 1)
                        return false;
                    else
                        amount--;
                }
            }
            return false;
        }

        private bool isNumeric(string value)
        {
            return Regex.IsMatch(value, @"\d+$");
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                var id = item.Substring(0, item.IndexOf(":"));
                var idc = Convert.ToInt32(id);
                if (previousPassage == idc && previousType != 0) return;
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
                if (previousEvent == idc && previousType != 1) return;
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
            if (p != null)
                p.Save(p.file);
        }

        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "StoryDev Project|*.sdp";
            ofd.InitialDirectory = previousPath;
            ofd.FileOk += ofd_FileOk;
            ofd.ShowDialog();
        }

        void ofd_FileOk(object sender, CancelEventArgs e)
        {
            var ofd = sender as OpenFileDialog;
            if (!e.Cancel)
            {
                if (p != null)
                {
                    var response = MessageBox.Show("Do you wish to save the current project?", "Confirm", MessageBoxButtons.YesNoCancel);
                    if (response == System.Windows.Forms.DialogResult.Yes)
                        p.Save(p.file);
                    else if (response == System.Windows.Forms.DialogResult.No)
                    {
                        if (ofd.FileName != "")
                            p.Load(lastDirectory(ofd.FileName));
                    }
                }
                else
                {
                    if (ofd.FileName != "")
                    {
                        p = new Project();
                        p.Load(lastDirectory(ofd.FileName));
                    }
                }
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
                    var id = item.Substring(0, item.IndexOf(":"));
                    var idc = Convert.ToInt32(id);
                    p.RemovePassage(idc);
                    PopulateList("Passages");
                }
                else if (cmbType.SelectedIndex == 1)
                {
                    var item = lbItems.Items[lbItems.SelectedIndex].ToString();
                    var id = item.Substring(0, item.IndexOf(":"));
                    var idc = Convert.ToInt32(id);
                    p.RemoveGameEvent(idc);
                    PopulateList("Scenes");
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
                SaveItem("Scenes", previousEvent != -1 ? previousEvent : idc);
        }

        private void onKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/brutalexcess/StoryDev-Engine/wiki");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            if (p != null)
            {
                var response = MessageBox.Show("Do you wish to save before closing?", "Confirm", MessageBoxButtons.YesNoCancel);
                if (response == System.Windows.Forms.DialogResult.Cancel)
                    e.Cancel = true;
                else if (response == System.Windows.Forms.DialogResult.Yes)
                    p.Save(p.file);
            }
        }

        private void videoTutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/playlist?list=PLvi6G1HrMyFLUGFOhEX5qu0C5lil0Jntn");
        }

        private void importJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofdImport = new OpenFileDialog();
            ofdImport.Filter = "JSON Files|*.json";
            ofdImport.InitialDirectory = previousPath;
            ofdImport.FileOk += ofdImport_FileOk;
            if (p == null)
            {
                var response = MessageBox.Show("A project has not yet been created, create one now?", "Confirm", MessageBoxButtons.YesNoCancel);
                if (response == System.Windows.Forms.DialogResult.Yes)
                {
                    var saveProj = new SaveFileDialog();
                    saveProj.Filter = "StoryDev Project|*.sdp";
                    saveProj.InitialDirectory = previousPath;
                    saveProj.FileOk += saveProj_FileOk;
                    saveProj.ShowDialog();
                }
                else
                    return;

                if (p != null)
                    ofdImport.ShowDialog();
            }
            else
                ofdImport.ShowDialog();
        }

        void ofdImport_FileOk(object sender, CancelEventArgs e)
        {
            var ofdImport = sender as OpenFileDialog;
            if (!e.Cancel)
            {
                var file = ofdImport.FileName;
                var import = new ImportJson(p);
                import.FullPath = file;
                if (file.EndsWith("passages.json"))
                {
                    import.FileName = "passages.json";
                    import.ShowDialog();
                }
                else if (file.EndsWith("scenes.json"))
                {
                    import.FileName = "scenes.json";
                    import.ShowDialog();
                }
            }
        }

        private string lastDirectory(string file)
        {
            previousPath = file.Substring(0, file.LastIndexOf("\\"));
            Properties.Settings.Default.previousPath = previousPath;
            return file;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (p != null)
            {
                if (previousType == 0)
                    PopulateList("Passages");
                else
                    PopulateList("Scenes");
            }
        }

    }
}
