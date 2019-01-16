namespace Sprinkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PortComboBox = new System.Windows.Forms.ComboBox();
            this.ReadDataButton = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Label();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.conductivity = new System.Windows.Forms.Label();
            this.turbidity = new System.Windows.Forms.Label();
            this.ph = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.DataHeading = new System.Windows.Forms.Label();
            this.OutputPanel = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.pictureGIF = new System.Windows.Forms.PictureBox();
            this.outputLog = new System.Windows.Forms.Button();
            this.wiki = new System.Windows.Forms.Button();
            this.mlPrediction = new System.Windows.Forms.Button();
            this.whoStandard = new System.Windows.Forms.Button();
            this.DataPanel.SuspendLayout();
            this.OutputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGIF)).BeginInit();
            this.SuspendLayout();
            // 
            // PortComboBox
            // 
            this.PortComboBox.BackColor = System.Drawing.Color.White;
            this.PortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortComboBox.ForeColor = System.Drawing.Color.Black;
            this.PortComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.PortComboBox.Location = new System.Drawing.Point(92, 125);
            this.PortComboBox.Name = "PortComboBox";
            this.PortComboBox.Size = new System.Drawing.Size(97, 26);
            this.PortComboBox.TabIndex = 0;
            this.PortComboBox.Text = "Select Port";
            // 
            // ReadDataButton
            // 
            this.ReadDataButton.BackColor = System.Drawing.Color.Lime;
            this.ReadDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadDataButton.Location = new System.Drawing.Point(228, 125);
            this.ReadDataButton.Name = "ReadDataButton";
            this.ReadDataButton.Size = new System.Drawing.Size(109, 28);
            this.ReadDataButton.TabIndex = 1;
            this.ReadDataButton.Text = "Read Data";
            this.ReadDataButton.UseVisualStyleBackColor = false;
            this.ReadDataButton.Click += new System.EventHandler(this.ReadDataButton_Click);
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.Transparent;
            this.Heading.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.Color.Crimson;
            this.Heading.Location = new System.Drawing.Point(123, 33);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(591, 50);
            this.Heading.TabIndex = 2;
            this.Heading.Text = "Sprinkle : Water Quality Checker";
            this.Heading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DataPanel
            // 
            this.DataPanel.BackColor = System.Drawing.Color.Lavender;
            this.DataPanel.Controls.Add(this.conductivity);
            this.DataPanel.Controls.Add(this.turbidity);
            this.DataPanel.Controls.Add(this.ph);
            this.DataPanel.Controls.Add(this.temperature);
            this.DataPanel.Controls.Add(this.DataHeading);
            this.DataPanel.Location = new System.Drawing.Point(92, 185);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(245, 200);
            this.DataPanel.TabIndex = 3;
            // 
            // conductivity
            // 
            this.conductivity.AutoSize = true;
            this.conductivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conductivity.Location = new System.Drawing.Point(25, 164);
            this.conductivity.Name = "conductivity";
            this.conductivity.Size = new System.Drawing.Size(83, 15);
            this.conductivity.TabIndex = 4;
            this.conductivity.Text = "Conductivity";
            // 
            // turbidity
            // 
            this.turbidity.AutoSize = true;
            this.turbidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turbidity.Location = new System.Drawing.Point(25, 129);
            this.turbidity.Name = "turbidity";
            this.turbidity.Size = new System.Drawing.Size(62, 15);
            this.turbidity.TabIndex = 3;
            this.turbidity.Text = "Turbidity";
            // 
            // ph
            // 
            this.ph.AutoSize = true;
            this.ph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ph.Location = new System.Drawing.Point(25, 94);
            this.ph.Name = "ph";
            this.ph.Size = new System.Drawing.Size(128, 15);
            this.ph.TabIndex = 2;
            this.ph.Text = "Pouvoir Hydrogène";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(25, 61);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(89, 15);
            this.temperature.TabIndex = 1;
            this.temperature.Text = "Temperature";
            // 
            // DataHeading
            // 
            this.DataHeading.AutoSize = true;
            this.DataHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.DataHeading.Location = new System.Drawing.Point(54, 18);
            this.DataHeading.Name = "DataHeading";
            this.DataHeading.Size = new System.Drawing.Size(117, 18);
            this.DataHeading.TabIndex = 0;
            this.DataHeading.Text = "Sample\'s Data";
            // 
            // OutputPanel
            // 
            this.OutputPanel.BackColor = System.Drawing.Color.Lavender;
            this.OutputPanel.Controls.Add(this.result);
            this.OutputPanel.Controls.Add(this.resultLabel);
            this.OutputPanel.Location = new System.Drawing.Point(529, 246);
            this.OutputPanel.Name = "OutputPanel";
            this.OutputPanel.Size = new System.Drawing.Size(168, 90);
            this.OutputPanel.TabIndex = 4;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.result.Location = new System.Drawing.Point(14, 40);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(140, 27);
            this.result.TabIndex = 1;
            this.result.Text = "................";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.resultLabel.Location = new System.Drawing.Point(54, 16);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(56, 18);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Result";
            // 
            // pictureGIF
            // 
            this.pictureGIF.BackColor = System.Drawing.Color.Transparent;
            this.pictureGIF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureGIF.Image = ((System.Drawing.Image)(resources.GetObject("pictureGIF.Image")));
            this.pictureGIF.Location = new System.Drawing.Point(548, 147);
            this.pictureGIF.Name = "pictureGIF";
            this.pictureGIF.Size = new System.Drawing.Size(120, 93);
            this.pictureGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGIF.TabIndex = 5;
            this.pictureGIF.TabStop = false;
            // 
            // outputLog
            // 
            this.outputLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLog.Location = new System.Drawing.Point(665, 402);
            this.outputLog.Name = "outputLog";
            this.outputLog.Size = new System.Drawing.Size(103, 27);
            this.outputLog.TabIndex = 6;
            this.outputLog.Text = "Output Log>>";
            this.outputLog.UseVisualStyleBackColor = true;
            this.outputLog.Click += new System.EventHandler(this.outputLog_Click);
            // 
            // wiki
            // 
            this.wiki.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.wiki.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wiki.ForeColor = System.Drawing.Color.OldLace;
            this.wiki.Location = new System.Drawing.Point(12, 12);
            this.wiki.Name = "wiki";
            this.wiki.Size = new System.Drawing.Size(49, 29);
            this.wiki.TabIndex = 7;
            this.wiki.Text = "Wiki";
            this.wiki.UseVisualStyleBackColor = false;
            this.wiki.Click += new System.EventHandler(this.wiki_Click);
            // 
            // mlPrediction
            // 
            this.mlPrediction.BackColor = System.Drawing.SystemColors.Control;
            this.mlPrediction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlPrediction.ForeColor = System.Drawing.Color.Black;
            this.mlPrediction.Image = ((System.Drawing.Image)(resources.GetObject("mlPrediction.Image")));
            this.mlPrediction.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlPrediction.Location = new System.Drawing.Point(369, 246);
            this.mlPrediction.Name = "mlPrediction";
            this.mlPrediction.Size = new System.Drawing.Size(128, 34);
            this.mlPrediction.TabIndex = 8;
            this.mlPrediction.Text = "ML Prediction";
            this.mlPrediction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlPrediction.UseVisualStyleBackColor = false;
            this.mlPrediction.Click += new System.EventHandler(this.mlPrediction_Click);
            // 
            // whoStandard
            // 
            this.whoStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whoStandard.Image = ((System.Drawing.Image)(resources.GetObject("whoStandard.Image")));
            this.whoStandard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.whoStandard.Location = new System.Drawing.Point(369, 305);
            this.whoStandard.Name = "whoStandard";
            this.whoStandard.Size = new System.Drawing.Size(128, 31);
            this.whoStandard.TabIndex = 9;
            this.whoStandard.Text = "WHO Standard";
            this.whoStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.whoStandard.UseVisualStyleBackColor = true;
            this.whoStandard.Click += new System.EventHandler(this.whoStandard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.whoStandard);
            this.Controls.Add(this.mlPrediction);
            this.Controls.Add(this.wiki);
            this.Controls.Add(this.outputLog);
            this.Controls.Add(this.pictureGIF);
            this.Controls.Add(this.OutputPanel);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.ReadDataButton);
            this.Controls.Add(this.PortComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprinkle - Water Quality Checker";
            this.DataPanel.ResumeLayout(false);
            this.DataPanel.PerformLayout();
            this.OutputPanel.ResumeLayout(false);
            this.OutputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGIF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortComboBox;
        private System.Windows.Forms.Button ReadDataButton;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Label conductivity;
        private System.Windows.Forms.Label turbidity;
        private System.Windows.Forms.Label ph;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label DataHeading;
        private System.Windows.Forms.Panel OutputPanel;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.PictureBox pictureGIF;
        private System.Windows.Forms.Button outputLog;
        private System.Windows.Forms.Button wiki;
        private System.Windows.Forms.Button mlPrediction;
        private System.Windows.Forms.Button whoStandard;
    }
}

