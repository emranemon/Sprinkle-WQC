namespace Sprinkle
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.aboutBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // aboutBrowser
            // 
            this.aboutBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutBrowser.Location = new System.Drawing.Point(0, 0);
            this.aboutBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.aboutBrowser.Name = "aboutBrowser";
            this.aboutBrowser.Size = new System.Drawing.Size(800, 450);
            this.aboutBrowser.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aboutBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "Sprinkle wiki -About the project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser aboutBrowser;
    }
}