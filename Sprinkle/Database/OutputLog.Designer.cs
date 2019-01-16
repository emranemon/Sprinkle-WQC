namespace Sprinkle
{
    partial class OutputLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputLog));
            this.LogDataGridView = new System.Windows.Forms.DataGridView();
            this.searchDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.logHeading = new System.Windows.Forms.Label();
            this.logType = new System.Windows.Forms.Label();
            this.allLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.AllowUserToAddRows = false;
            this.LogDataGridView.AllowUserToDeleteRows = false;
            this.LogDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogDataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGridView.Location = new System.Drawing.Point(25, 92);
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.ReadOnly = true;
            this.LogDataGridView.Size = new System.Drawing.Size(745, 479);
            this.LogDataGridView.TabIndex = 0;
            // 
            // searchDateTimePicker
            // 
            this.searchDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.searchDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.searchDateTimePicker.Location = new System.Drawing.Point(599, 49);
            this.searchDateTimePicker.Name = "searchDateTimePicker";
            this.searchDateTimePicker.Size = new System.Drawing.Size(90, 20);
            this.searchDateTimePicker.TabIndex = 1;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(695, 48);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 21);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // logHeading
            // 
            this.logHeading.AutoSize = true;
            this.logHeading.BackColor = System.Drawing.Color.Transparent;
            this.logHeading.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logHeading.ForeColor = System.Drawing.Color.Brown;
            this.logHeading.Location = new System.Drawing.Point(28, 23);
            this.logHeading.Name = "logHeading";
            this.logHeading.Size = new System.Drawing.Size(236, 25);
            this.logHeading.TabIndex = 3;
            this.logHeading.Text = "Sprinkle: Output Logs";
            // 
            // logType
            // 
            this.logType.AutoSize = true;
            this.logType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.logType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logType.Location = new System.Drawing.Point(30, 73);
            this.logType.Name = "logType";
            this.logType.Size = new System.Drawing.Size(454, 16);
            this.logType.TabIndex = 4;
            this.logType.Text = "Every time \"Sprinkle\" predicts, saves relative info as output logs.";
            // 
            // allLogs
            // 
            this.allLogs.BackColor = System.Drawing.Color.LightSeaGreen;
            this.allLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allLogs.Location = new System.Drawing.Point(507, 49);
            this.allLogs.Name = "allLogs";
            this.allLogs.Size = new System.Drawing.Size(72, 21);
            this.allLogs.TabIndex = 5;
            this.allLogs.Text = "All Logs";
            this.allLogs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allLogs.UseVisualStyleBackColor = false;
            this.allLogs.Click += new System.EventHandler(this.allLogs_Click);
            // 
            // OutputLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 598);
            this.Controls.Add(this.allLogs);
            this.Controls.Add(this.logType);
            this.Controls.Add(this.logHeading);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.searchDateTimePicker);
            this.Controls.Add(this.LogDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OutputLog";
            this.Text = "Sprinkle -Output Log";
            this.Load += new System.EventHandler(this.OutputLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LogDataGridView;
        private System.Windows.Forms.DateTimePicker searchDateTimePicker;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label logHeading;
        private System.Windows.Forms.Label logType;
        private System.Windows.Forms.Button allLogs;
    }
}