namespace Joonas_Praktika3
{
    partial class JO_YL4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JO_YL4));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.JO_ToolBtn_OpenDB = new System.Windows.Forms.ToolStripButton();
            this.JO_ListBox_Nadal1 = new System.Windows.Forms.ListBox();
            this.JO_ListBox_Nadal2 = new System.Windows.Forms.ListBox();
            this.JO_ListBox_Difference = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JO_Lbl_DifferenceCount = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JO_ToolBtn_OpenDB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(808, 25);
            this.toolStrip1.TabIndex = 0;
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
            // JO_ListBox_Nadal1
            // 
            this.JO_ListBox_Nadal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_ListBox_Nadal1.FormattingEnabled = true;
            this.JO_ListBox_Nadal1.ItemHeight = 18;
            this.JO_ListBox_Nadal1.Location = new System.Drawing.Point(12, 42);
            this.JO_ListBox_Nadal1.Name = "JO_ListBox_Nadal1";
            this.JO_ListBox_Nadal1.Size = new System.Drawing.Size(152, 310);
            this.JO_ListBox_Nadal1.TabIndex = 1;
            // 
            // JO_ListBox_Nadal2
            // 
            this.JO_ListBox_Nadal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_ListBox_Nadal2.FormattingEnabled = true;
            this.JO_ListBox_Nadal2.ItemHeight = 18;
            this.JO_ListBox_Nadal2.Location = new System.Drawing.Point(636, 42);
            this.JO_ListBox_Nadal2.Name = "JO_ListBox_Nadal2";
            this.JO_ListBox_Nadal2.Size = new System.Drawing.Size(152, 310);
            this.JO_ListBox_Nadal2.TabIndex = 2;
            // 
            // JO_ListBox_Difference
            // 
            this.JO_ListBox_Difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_ListBox_Difference.FormattingEnabled = true;
            this.JO_ListBox_Difference.ItemHeight = 16;
            this.JO_ListBox_Difference.Location = new System.Drawing.Point(170, 42);
            this.JO_ListBox_Difference.Name = "JO_ListBox_Difference";
            this.JO_ListBox_Difference.Size = new System.Drawing.Size(460, 308);
            this.JO_ListBox_Difference.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difference count:";
            // 
            // JO_Lbl_DifferenceCount
            // 
            this.JO_Lbl_DifferenceCount.AutoSize = true;
            this.JO_Lbl_DifferenceCount.Location = new System.Drawing.Point(438, 25);
            this.JO_Lbl_DifferenceCount.Name = "JO_Lbl_DifferenceCount";
            this.JO_Lbl_DifferenceCount.Size = new System.Drawing.Size(13, 13);
            this.JO_Lbl_DifferenceCount.TabIndex = 5;
            this.JO_Lbl_DifferenceCount.Text = "--";
            // 
            // JO_YL4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 378);
            this.Controls.Add(this.JO_Lbl_DifferenceCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JO_ListBox_Difference);
            this.Controls.Add(this.JO_ListBox_Nadal2);
            this.Controls.Add(this.JO_ListBox_Nadal1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "JO_YL4";
            this.Text = "JO_YL4";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton JO_ToolBtn_OpenDB;
        private System.Windows.Forms.ListBox JO_ListBox_Nadal1;
        private System.Windows.Forms.ListBox JO_ListBox_Nadal2;
        private System.Windows.Forms.ListBox JO_ListBox_Difference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label JO_Lbl_DifferenceCount;
    }
}