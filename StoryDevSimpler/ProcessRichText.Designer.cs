namespace StoryDevSimpler
{
    partial class ProcessRichText
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProcessCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text to Process:";
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(12, 25);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(459, 258);
            this.rtbContent.TabIndex = 1;
            this.rtbContent.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProcessCopy
            // 
            this.btnProcessCopy.Location = new System.Drawing.Point(277, 289);
            this.btnProcessCopy.Name = "btnProcessCopy";
            this.btnProcessCopy.Size = new System.Drawing.Size(113, 23);
            this.btnProcessCopy.TabIndex = 3;
            this.btnProcessCopy.Text = "Process and Copy";
            this.btnProcessCopy.UseVisualStyleBackColor = true;
            this.btnProcessCopy.Click += new System.EventHandler(this.btnProcessCopy_Click);
            // 
            // ProcessRichText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 317);
            this.Controls.Add(this.btnProcessCopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessRichText";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Rich Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProcessCopy;
    }
}