namespace StoryDevSimpler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.btnAddPassage = new System.Windows.Forms.Button();
            this.btnAddGameEvent = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTestGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoTutorialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmsItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.cmsOptions.SuspendLayout();
            this.cmsItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 13);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(142, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(675, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to JSON";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(498, 11);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(171, 23);
            this.btnProcess.TabIndex = 6;
            this.btnProcess.Text = "Process Separate Rich Text";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(357, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(135, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(142, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(630, 464);
            this.pnlMain.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbItems);
            this.panel2.Location = new System.Drawing.Point(12, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 439);
            this.panel2.TabIndex = 0;
            // 
            // lbItems
            // 
            this.lbItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(0, 0);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(121, 439);
            this.lbItems.TabIndex = 0;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // btnAddPassage
            // 
            this.btnAddPassage.Location = new System.Drawing.Point(12, 510);
            this.btnAddPassage.Name = "btnAddPassage";
            this.btnAddPassage.Size = new System.Drawing.Size(105, 23);
            this.btnAddPassage.TabIndex = 10;
            this.btnAddPassage.Text = "Add Passage";
            this.btnAddPassage.UseVisualStyleBackColor = true;
            this.btnAddPassage.Click += new System.EventHandler(this.btnAddPassage_Click);
            // 
            // btnAddGameEvent
            // 
            this.btnAddGameEvent.Location = new System.Drawing.Point(123, 510);
            this.btnAddGameEvent.Name = "btnAddGameEvent";
            this.btnAddGameEvent.Size = new System.Drawing.Size(105, 23);
            this.btnAddGameEvent.TabIndex = 11;
            this.btnAddGameEvent.Text = "Add Game Event";
            this.btnAddGameEvent.UseVisualStyleBackColor = true;
            this.btnAddGameEvent.Click += new System.EventHandler(this.btnAddGameEvent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnTestGame
            // 
            this.btnTestGame.Location = new System.Drawing.Point(667, 510);
            this.btnTestGame.Name = "btnTestGame";
            this.btnTestGame.Size = new System.Drawing.Size(105, 23);
            this.btnTestGame.TabIndex = 12;
            this.btnTestGame.Text = "Test Game";
            this.btnTestGame.UseVisualStyleBackColor = true;
            this.btnTestGame.Click += new System.EventHandler(this.btnTestGame_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(567, 510);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(94, 23);
            this.btnOptions.TabIndex = 13;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.videoTutorialsToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.loadProjectToolStripMenuItem,
            this.newProjectToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(158, 114);
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            // 
            // videoTutorialsToolStripMenuItem
            // 
            this.videoTutorialsToolStripMenuItem.Name = "videoTutorialsToolStripMenuItem";
            this.videoTutorialsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.videoTutorialsToolStripMenuItem.Text = "Video Tutorials";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveProjectToolStripMenuItem.Text = "Save Project";
            this.saveProjectToolStripMenuItem.Click += new System.EventHandler(this.saveProjectToolStripMenuItem_Click);
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadProjectToolStripMenuItem.Text = "Load Project";
            this.loadProjectToolStripMenuItem.Click += new System.EventHandler(this.loadProjectToolStripMenuItem_Click);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Passages",
            "Game Events"});
            this.cmbType.Location = new System.Drawing.Point(12, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 0;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmsItems
            // 
            this.cmsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyIDToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsItems.Name = "cmsItems";
            this.cmsItems.Size = new System.Drawing.Size(117, 48);
            // 
            // copyIDToolStripMenuItem
            // 
            this.copyIDToolStripMenuItem.Name = "copyIDToolStripMenuItem";
            this.copyIDToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.copyIDToolStripMenuItem.Text = "Copy ID";
            this.copyIDToolStripMenuItem.Click += new System.EventHandler(this.copyIDToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnTestGame);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddGameEvent);
            this.Controls.Add(this.btnAddPassage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoryDev Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.cmsOptions.ResumeLayout(false);
            this.cmsItems.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.Button btnAddPassage;
        private System.Windows.Forms.Button btnAddGameEvent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTestGame;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoTutorialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ContextMenuStrip cmsItems;
        private System.Windows.Forms.ToolStripMenuItem copyIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
    }
}

