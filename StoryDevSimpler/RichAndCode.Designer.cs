namespace StoryDev
{
    partial class RichAndCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpTextEdit = new System.Windows.Forms.TabPage();
            this.txtTextEditor = new System.Windows.Forms.TextBox();
            this.tpCodeEdit = new System.Windows.Forms.TabPage();
            this.tcMain.SuspendLayout();
            this.tpTextEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpTextEdit);
            this.tcMain.Controls.Add(this.tpCodeEdit);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(630, 465);
            this.tcMain.TabIndex = 0;
            // 
            // tpTextEdit
            // 
            this.tpTextEdit.Controls.Add(this.txtTextEditor);
            this.tpTextEdit.Location = new System.Drawing.Point(4, 22);
            this.tpTextEdit.Name = "tpTextEdit";
            this.tpTextEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpTextEdit.Size = new System.Drawing.Size(622, 439);
            this.tpTextEdit.TabIndex = 0;
            this.tpTextEdit.Text = "Text Editor";
            this.tpTextEdit.UseVisualStyleBackColor = true;
            // 
            // txtTextEditor
            // 
            this.txtTextEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextEditor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextEditor.Location = new System.Drawing.Point(3, 3);
            this.txtTextEditor.Multiline = true;
            this.txtTextEditor.Name = "txtTextEditor";
            this.txtTextEditor.Size = new System.Drawing.Size(616, 433);
            this.txtTextEditor.TabIndex = 0;
            // 
            // tpCodeEdit
            // 
            this.tpCodeEdit.Location = new System.Drawing.Point(4, 22);
            this.tpCodeEdit.Name = "tpCodeEdit";
            this.tpCodeEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpCodeEdit.Size = new System.Drawing.Size(622, 439);
            this.tpCodeEdit.TabIndex = 1;
            this.tpCodeEdit.Text = "Code Editor";
            this.tpCodeEdit.UseVisualStyleBackColor = true;
            // 
            // RichAndCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcMain);
            this.Name = "RichAndCode";
            this.Size = new System.Drawing.Size(630, 465);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RichAndCode_KeyUp);
            this.tcMain.ResumeLayout(false);
            this.tpTextEdit.ResumeLayout(false);
            this.tpTextEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpTextEdit;
        private System.Windows.Forms.TabPage tpCodeEdit;
        private System.Windows.Forms.TextBox txtTextEditor;
    }
}
