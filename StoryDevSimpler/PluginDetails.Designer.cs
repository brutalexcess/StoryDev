namespace StoryDev
{
    partial class PluginDetails
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
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblShowHide = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // chbTitle
            // 
            this.chbTitle.AutoSize = true;
            this.chbTitle.Location = new System.Drawing.Point(3, 3);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(78, 17);
            this.chbTitle.TabIndex = 0;
            this.chbTitle.Text = "Plugin Title";
            this.chbTitle.UseVisualStyleBackColor = true;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(194, 4);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblShowHide
            // 
            this.lblShowHide.AutoSize = true;
            this.lblShowHide.Location = new System.Drawing.Point(342, 4);
            this.lblShowHide.Name = "lblShowHide";
            this.lblShowHide.Size = new System.Drawing.Size(69, 13);
            this.lblShowHide.TabIndex = 2;
            this.lblShowHide.TabStop = true;
            this.lblShowHide.Text = "Show Details";
            this.lblShowHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblShowHide_LinkClicked);
            // 
            // PluginDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblShowHide);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.chbTitle);
            this.Name = "PluginDetails";
            this.Size = new System.Drawing.Size(414, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.LinkLabel lblShowHide;
    }
}
