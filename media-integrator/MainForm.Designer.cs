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
            this.BTNIntegrate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNIntegrate
            // 
            this.BTNIntegrate.Location = new System.Drawing.Point(43, 75);
            this.BTNIntegrate.Name = "BTNIntegrate";
            this.BTNIntegrate.Size = new System.Drawing.Size(160, 57);
            this.BTNIntegrate.TabIndex = 0;
            this.BTNIntegrate.Text = "Start Integration";
            this.BTNIntegrate.UseVisualStyleBackColor = true;
            this.BTNIntegrate.Click += new System.EventHandler(this.BTNIntegrate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(447, 216);
            this.Controls.Add(this.BTNIntegrate);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNIntegrate;
    }
}

