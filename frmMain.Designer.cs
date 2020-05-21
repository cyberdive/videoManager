namespace Video_manager
{
    partial class frmMain
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
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCpy = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnShowdata = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(28, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import CSV";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(28, 61);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCpy
            // 
            this.btnCpy.Location = new System.Drawing.Point(28, 87);
            this.btnCpy.Name = "btnCpy";
            this.btnCpy.Size = new System.Drawing.Size(75, 23);
            this.btnCpy.TabIndex = 2;
            this.btnCpy.Text = "Copy";
            this.btnCpy.UseVisualStyleBackColor = true;
            this.btnCpy.Click += new System.EventHandler(this.btnCpy_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(28, 113);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnShowdata
            // 
            this.btnShowdata.Location = new System.Drawing.Point(28, 37);
            this.btnShowdata.Name = "btnShowdata";
            this.btnShowdata.Size = new System.Drawing.Size(75, 23);
            this.btnShowdata.TabIndex = 4;
            this.btnShowdata.Text = "Show data";
            this.btnShowdata.UseVisualStyleBackColor = true;
            this.btnShowdata.Click += new System.EventHandler(this.btnShowdata_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 151);
            this.Controls.Add(this.btnShowdata);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnCpy);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnImport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Video manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCpy;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnShowdata;
    }
}

