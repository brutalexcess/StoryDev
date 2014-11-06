namespace StoryDevSimpler
{
    partial class JsonResult
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
            this.rtbJson = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbJson
            // 
            this.rtbJson.Location = new System.Drawing.Point(12, 12);
            this.rtbJson.Name = "rtbJson";
            this.rtbJson.Size = new System.Drawing.Size(386, 327);
            this.rtbJson.TabIndex = 0;
            this.rtbJson.Text = "";
            // 
            // JsonResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 350);
            this.Controls.Add(this.rtbJson);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JsonResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resulting Json";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbJson;
    }
}