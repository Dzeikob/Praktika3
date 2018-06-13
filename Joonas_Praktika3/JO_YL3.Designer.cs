namespace Joonas_Praktika3
{
    partial class JO_YL3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JO_YL3));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.JO_ToolBtn_OpenDB = new System.Windows.Forms.ToolStripButton();
            this.JO_ToolBtn_WriteToDB = new System.Windows.Forms.ToolStripButton();
            this.JO_Progress_Load = new System.Windows.Forms.ProgressBar();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JO_ToolBtn_OpenDB,
            this.JO_ToolBtn_WriteToDB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(172, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // JO_ToolBtn_OpenDB
            // 
            this.JO_ToolBtn_OpenDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JO_ToolBtn_OpenDB.Image = ((System.Drawing.Image)(resources.GetObject("JO_ToolBtn_OpenDB.Image")));
            this.JO_ToolBtn_OpenDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JO_ToolBtn_OpenDB.Name = "JO_ToolBtn_OpenDB";
            this.JO_ToolBtn_OpenDB.Size = new System.Drawing.Size(58, 22);
            this.JO_ToolBtn_OpenDB.Text = "Open DB";
            this.JO_ToolBtn_OpenDB.Click += new System.EventHandler(this.JO_ToolBtn_OpenDB_Click);
            // 
            // JO_ToolBtn_WriteToDB
            // 
            this.JO_ToolBtn_WriteToDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JO_ToolBtn_WriteToDB.Enabled = false;
            this.JO_ToolBtn_WriteToDB.Image = ((System.Drawing.Image)(resources.GetObject("JO_ToolBtn_WriteToDB.Image")));
            this.JO_ToolBtn_WriteToDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JO_ToolBtn_WriteToDB.Name = "JO_ToolBtn_WriteToDB";
            this.JO_ToolBtn_WriteToDB.Size = new System.Drawing.Size(100, 19);
            this.JO_ToolBtn_WriteToDB.Text = "Write excel to DB";
            this.JO_ToolBtn_WriteToDB.Click += new System.EventHandler(this.JO_ToolBtn_ReadHinnakiri_Click);
            // 
            // JO_Progress_Load
            // 
            this.JO_Progress_Load.Location = new System.Drawing.Point(12, 40);
            this.JO_Progress_Load.Name = "JO_Progress_Load";
            this.JO_Progress_Load.Size = new System.Drawing.Size(149, 23);
            this.JO_Progress_Load.TabIndex = 3;
            // 
            // JO_YL3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 74);
            this.Controls.Add(this.JO_Progress_Load);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "JO_YL3";
            this.Text = "JO_YL3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JO_YL3_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton JO_ToolBtn_OpenDB;
        private System.Windows.Forms.ToolStripButton JO_ToolBtn_WriteToDB;
        private System.Windows.Forms.ProgressBar JO_Progress_Load;
    }
}