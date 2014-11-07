namespace StoryDev
{
    partial class InstallHaxe
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
            this.llHaxeToolkit = new System.Windows.Forms.LinkLabel();
            this.llLaunchCMD = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "In order to use this application properly, you will need to install the Haxe Tool" +
    "kit.\r\n";
            // 
            // llHaxeToolkit
            // 
            this.llHaxeToolkit.AutoSize = true;
            this.llHaxeToolkit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llHaxeToolkit.Location = new System.Drawing.Point(200, 47);
            this.llHaxeToolkit.Name = "llHaxeToolkit";
            this.llHaxeToolkit.Size = new System.Drawing.Size(121, 16);
            this.llHaxeToolkit.TabIndex = 1;
            this.llHaxeToolkit.TabStop = true;
            this.llHaxeToolkit.Text = "Install Haxe Toolkit";
            this.llHaxeToolkit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llHaxeToolkit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHaxeToolkit_LinkClicked);
            // 
            // llLaunchCMD
            // 
            this.llLaunchCMD.AutoSize = true;
            this.llLaunchCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLaunchCMD.Location = new System.Drawing.Point(179, 119);
            this.llLaunchCMD.Name = "llLaunchCMD";
            this.llLaunchCMD.Size = new System.Drawing.Size(162, 16);
            this.llLaunchCMD.TabIndex = 2;
            this.llLaunchCMD.TabStop = true;
            this.llLaunchCMD.Text = "Launch Command Prompt";
            this.llLaunchCMD.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.llLaunchCMD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLaunchCMD_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "After this has successfully installed, you will then need to open Command Prompt " +
    "\r\nand install the pre-requisites for compiling StoryDev.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(502, 96);
            this.label3.TabIndex = 4;
            this.label3.Text = "Once launched, type and execute the following commands (in order of appearance):\r" +
    "\n\r\nhaxelib install lime\r\nhaxelib run lime setup\r\nlime install openfl\r\nhaxelib in" +
    "stall hscript";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close and do not show again";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstallHaxe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llLaunchCMD);
            this.Controls.Add(this.llHaxeToolkit);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InstallHaxe";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llHaxeToolkit;
        private System.Windows.Forms.LinkLabel llLaunchCMD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}