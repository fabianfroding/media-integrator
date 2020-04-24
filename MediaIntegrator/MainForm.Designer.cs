namespace media_integrator
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
            this.BTNStartIntegration = new System.Windows.Forms.Button();
            this.TextBoxOutputDir = new System.Windows.Forms.TextBox();
            this.BTNSelectOutputDir = new System.Windows.Forms.Button();
            this.BTNSelectInputDir = new System.Windows.Forms.Button();
            this.TextBoxInputDir = new System.Windows.Forms.TextBox();
            this.LabelOutputDir = new System.Windows.Forms.Label();
            this.LabelInputDir = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNStartIntegration
            // 
            this.BTNStartIntegration.Location = new System.Drawing.Point(12, 148);
            this.BTNStartIntegration.Name = "BTNStartIntegration";
            this.BTNStartIntegration.Size = new System.Drawing.Size(160, 32);
            this.BTNStartIntegration.TabIndex = 0;
            this.BTNStartIntegration.Text = "Start Integration";
            this.BTNStartIntegration.UseVisualStyleBackColor = true;
            this.BTNStartIntegration.Click += new System.EventHandler(this.BTNStartIntegration_Click);
            // 
            // TextBoxOutputDir
            // 
            this.TextBoxOutputDir.Location = new System.Drawing.Point(50, 93);
            this.TextBoxOutputDir.Name = "TextBoxOutputDir";
            this.TextBoxOutputDir.ReadOnly = true;
            this.TextBoxOutputDir.Size = new System.Drawing.Size(416, 26);
            this.TextBoxOutputDir.TabIndex = 1;
            // 
            // BTNSelectOutputDir
            // 
            this.BTNSelectOutputDir.Location = new System.Drawing.Point(12, 93);
            this.BTNSelectOutputDir.Name = "BTNSelectOutputDir";
            this.BTNSelectOutputDir.Size = new System.Drawing.Size(32, 26);
            this.BTNSelectOutputDir.TabIndex = 2;
            this.BTNSelectOutputDir.Text = "...";
            this.BTNSelectOutputDir.UseVisualStyleBackColor = true;
            this.BTNSelectOutputDir.Click += new System.EventHandler(this.BTNSelectOutputDir_Click);
            // 
            // BTNSelectInputDir
            // 
            this.BTNSelectInputDir.Location = new System.Drawing.Point(12, 32);
            this.BTNSelectInputDir.Name = "BTNSelectInputDir";
            this.BTNSelectInputDir.Size = new System.Drawing.Size(32, 26);
            this.BTNSelectInputDir.TabIndex = 4;
            this.BTNSelectInputDir.Text = "...";
            this.BTNSelectInputDir.UseVisualStyleBackColor = true;
            this.BTNSelectInputDir.Click += new System.EventHandler(this.BTNSelectInputDir_Click);
            // 
            // TextBoxInputDir
            // 
            this.TextBoxInputDir.Location = new System.Drawing.Point(50, 32);
            this.TextBoxInputDir.Name = "TextBoxInputDir";
            this.TextBoxInputDir.ReadOnly = true;
            this.TextBoxInputDir.Size = new System.Drawing.Size(416, 26);
            this.TextBoxInputDir.TabIndex = 3;
            // 
            // LabelOutputDir
            // 
            this.LabelOutputDir.AutoSize = true;
            this.LabelOutputDir.ForeColor = System.Drawing.Color.White;
            this.LabelOutputDir.Location = new System.Drawing.Point(8, 70);
            this.LabelOutputDir.Name = "LabelOutputDir";
            this.LabelOutputDir.Size = new System.Drawing.Size(129, 20);
            this.LabelOutputDir.TabIndex = 5;
            this.LabelOutputDir.Text = "Output Directory:";
            // 
            // LabelInputDir
            // 
            this.LabelInputDir.AutoSize = true;
            this.LabelInputDir.ForeColor = System.Drawing.Color.White;
            this.LabelInputDir.Location = new System.Drawing.Point(8, 9);
            this.LabelInputDir.Name = "LabelInputDir";
            this.LabelInputDir.Size = new System.Drawing.Size(117, 20);
            this.LabelInputDir.TabIndex = 6;
            this.LabelInputDir.Text = "Input Directory:";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.ForeColor = System.Drawing.Color.White;
            this.LabelStatus.Location = new System.Drawing.Point(178, 154);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 20);
            this.LabelStatus.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(538, 271);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelInputDir);
            this.Controls.Add(this.LabelOutputDir);
            this.Controls.Add(this.BTNSelectInputDir);
            this.Controls.Add(this.TextBoxInputDir);
            this.Controls.Add(this.BTNSelectOutputDir);
            this.Controls.Add(this.TextBoxOutputDir);
            this.Controls.Add(this.BTNStartIntegration);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNStartIntegration;
        private System.Windows.Forms.TextBox TextBoxOutputDir;
        private System.Windows.Forms.Button BTNSelectOutputDir;
        private System.Windows.Forms.Button BTNSelectInputDir;
        private System.Windows.Forms.TextBox TextBoxInputDir;
        private System.Windows.Forms.Label LabelOutputDir;
        private System.Windows.Forms.Label LabelInputDir;
        private System.Windows.Forms.Label LabelStatus;
    }
}

