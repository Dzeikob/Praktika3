namespace Joonas_Praktika3
{
    partial class JO_YL2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JO_YL2));
            this.JO_DataGrid_Authors = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.JO_Tool_OpenDB = new System.Windows.Forms.ToolStripButton();
            this.JO_Tool_ReadAuthors = new System.Windows.Forms.ToolStripButton();
            this.JO_DataGrid_Titles = new System.Windows.Forms.DataGridView();
            this.JO_Btn_Titles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JO_DataGrid_Authors)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JO_DataGrid_Titles)).BeginInit();
            this.SuspendLayout();
            // 
            // JO_DataGrid_Authors
            // 
            this.JO_DataGrid_Authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JO_DataGrid_Authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JO_DataGrid_Authors.Location = new System.Drawing.Point(12, 28);
            this.JO_DataGrid_Authors.Name = "JO_DataGrid_Authors";
            this.JO_DataGrid_Authors.Size = new System.Drawing.Size(730, 326);
            this.JO_DataGrid_Authors.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JO_Tool_OpenDB,
            this.JO_Tool_ReadAuthors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // JO_Tool_OpenDB
            // 
            this.JO_Tool_OpenDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JO_Tool_OpenDB.Image = ((System.Drawing.Image)(resources.GetObject("JO_Tool_OpenDB.Image")));
            this.JO_Tool_OpenDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JO_Tool_OpenDB.Name = "JO_Tool_OpenDB";
            this.JO_Tool_OpenDB.Size = new System.Drawing.Size(91, 22);
            this.JO_Tool_OpenDB.Text = "Open Database";
            this.JO_Tool_OpenDB.Click += new System.EventHandler(this.JO_Tool_OpenDB_Click);
            // 
            // JO_Tool_ReadAuthors
            // 
            this.JO_Tool_ReadAuthors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JO_Tool_ReadAuthors.Image = ((System.Drawing.Image)(resources.GetObject("JO_Tool_ReadAuthors.Image")));
            this.JO_Tool_ReadAuthors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JO_Tool_ReadAuthors.Name = "JO_Tool_ReadAuthors";
            this.JO_Tool_ReadAuthors.Size = new System.Drawing.Size(82, 22);
            this.JO_Tool_ReadAuthors.Text = "Read Authors";
            this.JO_Tool_ReadAuthors.Click += new System.EventHandler(this.JO_Tool_ReadAuthors_Click);
            // 
            // JO_DataGrid_Titles
            // 
            this.JO_DataGrid_Titles.AllowUserToAddRows = false;
            this.JO_DataGrid_Titles.AllowUserToDeleteRows = false;
            this.JO_DataGrid_Titles.AllowUserToResizeColumns = false;
            this.JO_DataGrid_Titles.AllowUserToResizeRows = false;
            this.JO_DataGrid_Titles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.JO_DataGrid_Titles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JO_DataGrid_Titles.Location = new System.Drawing.Point(12, 393);
            this.JO_DataGrid_Titles.Name = "JO_DataGrid_Titles";
            this.JO_DataGrid_Titles.Size = new System.Drawing.Size(730, 159);
            this.JO_DataGrid_Titles.TabIndex = 2;
            // 
            // JO_Btn_Titles
            // 
            this.JO_Btn_Titles.Location = new System.Drawing.Point(313, 360);
            this.JO_Btn_Titles.Name = "JO_Btn_Titles";
            this.JO_Btn_Titles.Size = new System.Drawing.Size(129, 27);
            this.JO_Btn_Titles.TabIndex = 3;
            this.JO_Btn_Titles.Text = "Titles";
            this.JO_Btn_Titles.UseVisualStyleBackColor = true;
            this.JO_Btn_Titles.Click += new System.EventHandler(this.JO_Btn_Titles_Click);
            // 
            // JO_YL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 564);
            this.Controls.Add(this.JO_Btn_Titles);
            this.Controls.Add(this.JO_DataGrid_Titles);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.JO_DataGrid_Authors);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "JO_YL2";
            this.Text = "JO_YL2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JO_YL2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.JO_DataGrid_Authors)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JO_DataGrid_Titles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView JO_DataGrid_Authors;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton JO_Tool_OpenDB;
        private System.Windows.Forms.ToolStripButton JO_Tool_ReadAuthors;
        private System.Windows.Forms.DataGridView JO_DataGrid_Titles;
        private System.Windows.Forms.Button JO_Btn_Titles;
    }
}