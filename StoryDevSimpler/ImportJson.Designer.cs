namespace StoryDev
{
    partial class ImportJson
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
            this.chbJson = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJSON = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbJson
            // 
            this.chbJson.CheckOnClick = true;
            this.chbJson.FormattingEnabled = true;
            this.chbJson.Location = new System.Drawing.Point(12, 48);
            this.chbJson.Name = "chbJson";
            this.chbJson.Size = new System.Drawing.Size(308, 319);
            this.chbJson.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select JSON Objects to import into project:";
            // 
            // lblJSON
            // 
            this.lblJSON.AutoSize = true;
            this.lblJSON.Location = new System.Drawing.Point(12, 11);
            this.lblJSON.Name = "lblJSON";
            this.lblJSON.Size = new System.Drawing.Size(57, 13);
            this.lblJSON.TabIndex = 2;
            this.lblJSON.Text = "JSON File:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(164, 373);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // ImportJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 404);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblJSON);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbJson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportJson";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Json";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImportJson_FormClosing);
            this.Load += new System.EventHandler(this.ImportJson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chbJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJSON;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
    }
}