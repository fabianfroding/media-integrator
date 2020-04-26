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
            this.TextBoxOutputDirMediaShop = new System.Windows.Forms.TextBox();
            this.BTNSelectOutputDirMediaShop = new System.Windows.Forms.Button();
            this.BTNSelectInputDirMediaShop = new System.Windows.Forms.Button();
            this.TextBoxInputDirMediaShop = new System.Windows.Forms.TextBox();
            this.LabelOutputDirMediaShop = new System.Windows.Forms.Label();
            this.LabelInputDirMediaShop = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelInputDirSimpleMedia = new System.Windows.Forms.Label();
            this.LabelOutputDirSimpleMedia = new System.Windows.Forms.Label();
            this.BTNSelectInputDirSimpleMedia = new System.Windows.Forms.Button();
            this.TextBoxInputDirSimpleMedia = new System.Windows.Forms.TextBox();
            this.BTNSelectOutputDirSimpleMedia = new System.Windows.Forms.Button();
            this.TextBoxOutputDirSimpleMedia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNStartIntegration
            // 
            this.BTNStartIntegration.Location = new System.Drawing.Point(12, 333);
            this.BTNStartIntegration.Name = "BTNStartIntegration";
            this.BTNStartIntegration.Size = new System.Drawing.Size(160, 32);
            this.BTNStartIntegration.TabIndex = 0;
            this.BTNStartIntegration.Text = "Start Integration";
            this.BTNStartIntegration.UseVisualStyleBackColor = true;
            this.BTNStartIntegration.Click += new System.EventHandler(this.BTNStartIntegration_Click);
            // 
            // TextBoxOutputDirMediaShop
            // 
            this.TextBoxOutputDirMediaShop.Location = new System.Drawing.Point(50, 93);
            this.TextBoxOutputDirMediaShop.Name = "TextBoxOutputDirMediaShop";
            this.TextBoxOutputDirMediaShop.ReadOnly = true;
            this.TextBoxOutputDirMediaShop.Size = new System.Drawing.Size(416, 26);
            this.TextBoxOutputDirMediaShop.TabIndex = 1;
            // 
            // BTNSelectOutputDirMediaShop
            // 
            this.BTNSelectOutputDirMediaShop.Location = new System.Drawing.Point(12, 93);
            this.BTNSelectOutputDirMediaShop.Name = "BTNSelectOutputDirMediaShop";
            this.BTNSelectOutputDirMediaShop.Size = new System.Drawing.Size(36, 26);
            this.BTNSelectOutputDirMediaShop.TabIndex = 2;
            this.BTNSelectOutputDirMediaShop.Text = "...";
            this.BTNSelectOutputDirMediaShop.UseVisualStyleBackColor = true;
            this.BTNSelectOutputDirMediaShop.Click += new System.EventHandler(this.BTNSelectOutputDirMediaShop_Click);
            // 
            // BTNSelectInputDirMediaShop
            // 
            this.BTNSelectInputDirMediaShop.Location = new System.Drawing.Point(12, 32);
            this.BTNSelectInputDirMediaShop.Name = "BTNSelectInputDirMediaShop";
            this.BTNSelectInputDirMediaShop.Size = new System.Drawing.Size(36, 26);
            this.BTNSelectInputDirMediaShop.TabIndex = 4;
            this.BTNSelectInputDirMediaShop.Text = "...";
            this.BTNSelectInputDirMediaShop.UseVisualStyleBackColor = true;
            this.BTNSelectInputDirMediaShop.Click += new System.EventHandler(this.BTNSelectInputDirMediaShop_Click);
            // 
            // TextBoxInputDirMediaShop
            // 
            this.TextBoxInputDirMediaShop.Location = new System.Drawing.Point(50, 32);
            this.TextBoxInputDirMediaShop.Name = "TextBoxInputDirMediaShop";
            this.TextBoxInputDirMediaShop.ReadOnly = true;
            this.TextBoxInputDirMediaShop.Size = new System.Drawing.Size(416, 26);
            this.TextBoxInputDirMediaShop.TabIndex = 3;
            // 
            // LabelOutputDirMediaShop
            // 
            this.LabelOutputDirMediaShop.AutoSize = true;
            this.LabelOutputDirMediaShop.ForeColor = System.Drawing.Color.White;
            this.LabelOutputDirMediaShop.Location = new System.Drawing.Point(8, 70);
            this.LabelOutputDirMediaShop.Name = "LabelOutputDirMediaShop";
            this.LabelOutputDirMediaShop.Size = new System.Drawing.Size(218, 20);
            this.LabelOutputDirMediaShop.TabIndex = 5;
            this.LabelOutputDirMediaShop.Text = "Media Shop Output Directory:";
            // 
            // LabelInputDirMediaShop
            // 
            this.LabelInputDirMediaShop.AutoSize = true;
            this.LabelInputDirMediaShop.ForeColor = System.Drawing.Color.White;
            this.LabelInputDirMediaShop.Location = new System.Drawing.Point(8, 9);
            this.LabelInputDirMediaShop.Name = "LabelInputDirMediaShop";
            this.LabelInputDirMediaShop.Size = new System.Drawing.Size(206, 20);
            this.LabelInputDirMediaShop.TabIndex = 6;
            this.LabelInputDirMediaShop.Text = "Media Shop Input Directory:";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.ForeColor = System.Drawing.Color.White;
            this.LabelStatus.Location = new System.Drawing.Point(178, 339);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(0, 20);
            this.LabelStatus.TabIndex = 7;
            // 
            // LabelInputDirSimpleMedia
            // 
            this.LabelInputDirSimpleMedia.AutoSize = true;
            this.LabelInputDirSimpleMedia.ForeColor = System.Drawing.Color.White;
            this.LabelInputDirSimpleMedia.Location = new System.Drawing.Point(8, 168);
            this.LabelInputDirSimpleMedia.Name = "LabelInputDirSimpleMedia";
            this.LabelInputDirSimpleMedia.Size = new System.Drawing.Size(216, 20);
            this.LabelInputDirSimpleMedia.TabIndex = 13;
            this.LabelInputDirSimpleMedia.Text = "Simple Media Input Directory:";
            // 
            // LabelOutputDirSimpleMedia
            // 
            this.LabelOutputDirSimpleMedia.AutoSize = true;
            this.LabelOutputDirSimpleMedia.ForeColor = System.Drawing.Color.White;
            this.LabelOutputDirSimpleMedia.Location = new System.Drawing.Point(8, 229);
            this.LabelOutputDirSimpleMedia.Name = "LabelOutputDirSimpleMedia";
            this.LabelOutputDirSimpleMedia.Size = new System.Drawing.Size(228, 20);
            this.LabelOutputDirSimpleMedia.TabIndex = 12;
            this.LabelOutputDirSimpleMedia.Text = "Simple Media Output Directory:";
            // 
            // BTNSelectInputDirSimpleMedia
            // 
            this.BTNSelectInputDirSimpleMedia.Location = new System.Drawing.Point(12, 191);
            this.BTNSelectInputDirSimpleMedia.Name = "BTNSelectInputDirSimpleMedia";
            this.BTNSelectInputDirSimpleMedia.Size = new System.Drawing.Size(36, 26);
            this.BTNSelectInputDirSimpleMedia.TabIndex = 11;
            this.BTNSelectInputDirSimpleMedia.Text = "...";
            this.BTNSelectInputDirSimpleMedia.UseVisualStyleBackColor = true;
            this.BTNSelectInputDirSimpleMedia.Click += new System.EventHandler(this.BTNSelectInputDirSimpleMedia_Click);
            // 
            // TextBoxInputDirSimpleMedia
            // 
            this.TextBoxInputDirSimpleMedia.Location = new System.Drawing.Point(50, 191);
            this.TextBoxInputDirSimpleMedia.Name = "TextBoxInputDirSimpleMedia";
            this.TextBoxInputDirSimpleMedia.ReadOnly = true;
            this.TextBoxInputDirSimpleMedia.Size = new System.Drawing.Size(416, 26);
            this.TextBoxInputDirSimpleMedia.TabIndex = 10;
            // 
            // BTNSelectOutputDirSimpleMedia
            // 
            this.BTNSelectOutputDirSimpleMedia.Location = new System.Drawing.Point(12, 252);
            this.BTNSelectOutputDirSimpleMedia.Name = "BTNSelectOutputDirSimpleMedia";
            this.BTNSelectOutputDirSimpleMedia.Size = new System.Drawing.Size(36, 26);
            this.BTNSelectOutputDirSimpleMedia.TabIndex = 9;
            this.BTNSelectOutputDirSimpleMedia.Text = "...";
            this.BTNSelectOutputDirSimpleMedia.UseVisualStyleBackColor = true;
            this.BTNSelectOutputDirSimpleMedia.Click += new System.EventHandler(this.BTNSelectOutputDirSimpleMedia_Click);
            // 
            // TextBoxOutputDirSimpleMedia
            // 
            this.TextBoxOutputDirSimpleMedia.Location = new System.Drawing.Point(50, 252);
            this.TextBoxOutputDirSimpleMedia.Name = "TextBoxOutputDirSimpleMedia";
            this.TextBoxOutputDirSimpleMedia.ReadOnly = true;
            this.TextBoxOutputDirSimpleMedia.Size = new System.Drawing.Size(416, 26);
            this.TextBoxOutputDirSimpleMedia.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(546, 377);
            this.Controls.Add(this.LabelInputDirSimpleMedia);
            this.Controls.Add(this.LabelOutputDirSimpleMedia);
            this.Controls.Add(this.BTNSelectInputDirSimpleMedia);
            this.Controls.Add(this.TextBoxInputDirSimpleMedia);
            this.Controls.Add(this.BTNSelectOutputDirSimpleMedia);
            this.Controls.Add(this.TextBoxOutputDirSimpleMedia);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.LabelInputDirMediaShop);
            this.Controls.Add(this.LabelOutputDirMediaShop);
            this.Controls.Add(this.BTNSelectInputDirMediaShop);
            this.Controls.Add(this.TextBoxInputDirMediaShop);
            this.Controls.Add(this.BTNSelectOutputDirMediaShop);
            this.Controls.Add(this.TextBoxOutputDirMediaShop);
            this.Controls.Add(this.BTNStartIntegration);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Integrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNStartIntegration;
        private System.Windows.Forms.TextBox TextBoxOutputDirMediaShop;
        private System.Windows.Forms.Button BTNSelectOutputDirMediaShop;
        private System.Windows.Forms.Button BTNSelectInputDirMediaShop;
        private System.Windows.Forms.TextBox TextBoxInputDirMediaShop;
        private System.Windows.Forms.Label LabelOutputDirMediaShop;
        private System.Windows.Forms.Label LabelInputDirMediaShop;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelInputDirSimpleMedia;
        private System.Windows.Forms.Label LabelOutputDirSimpleMedia;
        private System.Windows.Forms.Button BTNSelectInputDirSimpleMedia;
        private System.Windows.Forms.TextBox TextBoxInputDirSimpleMedia;
        private System.Windows.Forms.Button BTNSelectOutputDirSimpleMedia;
        private System.Windows.Forms.TextBox TextBoxOutputDirSimpleMedia;
    }
}

