namespace Joonas_Praktika3
{
    partial class JO_YL1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JO_YL1));
            this.JO_ListBox_Authors = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.JO_ToolBtn_OpenDB = new System.Windows.Forms.ToolStripButton();
            this.JO_ToolBtn_ReadAuthors = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JO_Lbl_AuthorsCount = new System.Windows.Forms.Label();
            this.JO_Lbl_AuthorsTimeTaken = new System.Windows.Forms.Label();
            this.JO_Btn_Insert = new System.Windows.Forms.Button();
            this.JO_Btn_Update = new System.Windows.Forms.Button();
            this.JO_Btn_Delete = new System.Windows.Forms.Button();
            this.JO_Btn_Titles = new System.Windows.Forms.Button();
            this.JO_ListBox_Titles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JO_TextBox_Author = new System.Windows.Forms.TextBox();
            this.JO_TxtBoxYearBorn = new System.Windows.Forms.TextBox();
            this.JO_Lbl_TitlesTimeTaken = new System.Windows.Forms.Label();
            this.JO_Lbl_TitlesCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.JO_Btn_Deselect = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // JO_ListBox_Authors
            // 
            this.JO_ListBox_Authors.FormattingEnabled = true;
            this.JO_ListBox_Authors.ItemHeight = 18;
            this.JO_ListBox_Authors.Location = new System.Drawing.Point(12, 63);
            this.JO_ListBox_Authors.Name = "JO_ListBox_Authors";
            this.JO_ListBox_Authors.Size = new System.Drawing.Size(257, 508);
            this.JO_ListBox_Authors.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JO_ToolBtn_OpenDB,
            this.JO_ToolBtn_ReadAuthors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // JO_ToolBtn_OpenDB
            // 
            this.JO_ToolBtn_OpenDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JO_ToolBtn_OpenDB.Image = ((System.Drawing.Image)(resources.GetObject("JO_ToolBtn_OpenDB.Image")));
            this.JO_ToolBtn_OpenDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JO_ToolBtn_OpenDB.Name = "JO_ToolBtn_OpenDB";
            this.JO_ToolBtn_OpenDB.Size = new System.Drawing.Size(91, 22);
            this.JO_ToolBtn_OpenDB.Text = "Open Biblio DB";
            this.JO_ToolBtn_OpenDB.Click += new System.EventHandler(this.JO_ToolBtn_OpenDB_Click);
            // 
            // JO_ToolBtn_ReadAuthors
            // 
            this.JO_ToolBtn_ReadAuthors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.JO_ToolBtn_ReadAuthors.Enabled = false;
            this.JO_ToolBtn_ReadAuthors.Image = ((System.Drawing.Image)(resources.GetObject("JO_ToolBtn_ReadAuthors.Image")));
            this.JO_ToolBtn_ReadAuthors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.JO_ToolBtn_ReadAuthors.Name = "JO_ToolBtn_ReadAuthors";
            this.JO_ToolBtn_ReadAuthors.Size = new System.Drawing.Size(82, 22);
            this.JO_ToolBtn_ReadAuthors.Text = "Read Authors";
            this.JO_ToolBtn_ReadAuthors.Click += new System.EventHandler(this.JO_ToolBtn_ReadAuthors_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rows:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time:";
            // 
            // JO_Lbl_AuthorsCount
            // 
            this.JO_Lbl_AuthorsCount.AutoSize = true;
            this.JO_Lbl_AuthorsCount.ForeColor = System.Drawing.Color.Red;
            this.JO_Lbl_AuthorsCount.Location = new System.Drawing.Point(64, 585);
            this.JO_Lbl_AuthorsCount.Name = "JO_Lbl_AuthorsCount";
            this.JO_Lbl_AuthorsCount.Size = new System.Drawing.Size(28, 18);
            this.JO_Lbl_AuthorsCount.TabIndex = 4;
            this.JO_Lbl_AuthorsCount.Text = "--";
            // 
            // JO_Lbl_AuthorsTimeTaken
            // 
            this.JO_Lbl_AuthorsTimeTaken.AutoSize = true;
            this.JO_Lbl_AuthorsTimeTaken.ForeColor = System.Drawing.Color.Red;
            this.JO_Lbl_AuthorsTimeTaken.Location = new System.Drawing.Point(239, 585);
            this.JO_Lbl_AuthorsTimeTaken.Name = "JO_Lbl_AuthorsTimeTaken";
            this.JO_Lbl_AuthorsTimeTaken.Size = new System.Drawing.Size(28, 18);
            this.JO_Lbl_AuthorsTimeTaken.TabIndex = 5;
            this.JO_Lbl_AuthorsTimeTaken.Text = "--";
            // 
            // JO_Btn_Insert
            // 
            this.JO_Btn_Insert.Enabled = false;
            this.JO_Btn_Insert.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_Btn_Insert.Location = new System.Drawing.Point(436, 149);
            this.JO_Btn_Insert.Name = "JO_Btn_Insert";
            this.JO_Btn_Insert.Size = new System.Drawing.Size(100, 47);
            this.JO_Btn_Insert.TabIndex = 6;
            this.JO_Btn_Insert.Text = "INSERT";
            this.JO_Btn_Insert.UseVisualStyleBackColor = true;
            this.JO_Btn_Insert.Click += new System.EventHandler(this.JO_Btn_Insert_Click);
            // 
            // JO_Btn_Update
            // 
            this.JO_Btn_Update.Enabled = false;
            this.JO_Btn_Update.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_Btn_Update.Location = new System.Drawing.Point(565, 149);
            this.JO_Btn_Update.Name = "JO_Btn_Update";
            this.JO_Btn_Update.Size = new System.Drawing.Size(100, 47);
            this.JO_Btn_Update.TabIndex = 7;
            this.JO_Btn_Update.Text = "UPDATE";
            this.JO_Btn_Update.UseVisualStyleBackColor = true;
            this.JO_Btn_Update.Click += new System.EventHandler(this.JO_Btn_Update_Click);
            // 
            // JO_Btn_Delete
            // 
            this.JO_Btn_Delete.Enabled = false;
            this.JO_Btn_Delete.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_Btn_Delete.ForeColor = System.Drawing.Color.Red;
            this.JO_Btn_Delete.Location = new System.Drawing.Point(694, 149);
            this.JO_Btn_Delete.Name = "JO_Btn_Delete";
            this.JO_Btn_Delete.Size = new System.Drawing.Size(100, 47);
            this.JO_Btn_Delete.TabIndex = 8;
            this.JO_Btn_Delete.Text = "DELETE";
            this.JO_Btn_Delete.UseVisualStyleBackColor = true;
            this.JO_Btn_Delete.Click += new System.EventHandler(this.JO_Btn_Delete_Click);
            // 
            // JO_Btn_Titles
            // 
            this.JO_Btn_Titles.Enabled = false;
            this.JO_Btn_Titles.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_Btn_Titles.Location = new System.Drawing.Point(323, 218);
            this.JO_Btn_Titles.Name = "JO_Btn_Titles";
            this.JO_Btn_Titles.Size = new System.Drawing.Size(100, 47);
            this.JO_Btn_Titles.TabIndex = 9;
            this.JO_Btn_Titles.Text = "TITLES";
            this.JO_Btn_Titles.UseVisualStyleBackColor = true;
            this.JO_Btn_Titles.Click += new System.EventHandler(this.JO_Btn_Titles_Click);
            // 
            // JO_ListBox_Titles
            // 
            this.JO_ListBox_Titles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JO_ListBox_Titles.FormattingEnabled = true;
            this.JO_ListBox_Titles.ItemHeight = 18;
            this.JO_ListBox_Titles.Location = new System.Drawing.Point(436, 218);
            this.JO_ListBox_Titles.Name = "JO_ListBox_Titles";
            this.JO_ListBox_Titles.Size = new System.Drawing.Size(415, 346);
            this.JO_ListBox_Titles.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(319, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(319, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Year Born";
            // 
            // JO_TextBox_Author
            // 
            this.JO_TextBox_Author.Location = new System.Drawing.Point(463, 45);
            this.JO_TextBox_Author.Name = "JO_TextBox_Author";
            this.JO_TextBox_Author.Size = new System.Drawing.Size(332, 26);
            this.JO_TextBox_Author.TabIndex = 13;
            // 
            // JO_TxtBoxYearBorn
            // 
            this.JO_TxtBoxYearBorn.Location = new System.Drawing.Point(463, 95);
            this.JO_TxtBoxYearBorn.Name = "JO_TxtBoxYearBorn";
            this.JO_TxtBoxYearBorn.Size = new System.Drawing.Size(51, 26);
            this.JO_TxtBoxYearBorn.TabIndex = 14;
            // 
            // JO_Lbl_TitlesTimeTaken
            // 
            this.JO_Lbl_TitlesTimeTaken.AutoSize = true;
            this.JO_Lbl_TitlesTimeTaken.ForeColor = System.Drawing.Color.Red;
            this.JO_Lbl_TitlesTimeTaken.Location = new System.Drawing.Point(710, 585);
            this.JO_Lbl_TitlesTimeTaken.Name = "JO_Lbl_TitlesTimeTaken";
            this.JO_Lbl_TitlesTimeTaken.Size = new System.Drawing.Size(28, 18);
            this.JO_Lbl_TitlesTimeTaken.TabIndex = 18;
            this.JO_Lbl_TitlesTimeTaken.Text = "--";
            // 
            // JO_Lbl_TitlesCount
            // 
            this.JO_Lbl_TitlesCount.AutoSize = true;
            this.JO_Lbl_TitlesCount.ForeColor = System.Drawing.Color.Red;
            this.JO_Lbl_TitlesCount.Location = new System.Drawing.Point(535, 585);
            this.JO_Lbl_TitlesCount.Name = "JO_Lbl_TitlesCount";
            this.JO_Lbl_TitlesCount.Size = new System.Drawing.Size(28, 18);
            this.JO_Lbl_TitlesCount.TabIndex = 17;
            this.JO_Lbl_TitlesCount.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(658, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Rows:";
            // 
            // JO_Btn_Deselect
            // 
            this.JO_Btn_Deselect.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.JO_Btn_Deselect.Location = new System.Drawing.Point(194, 40);
            this.JO_Btn_Deselect.Name = "JO_Btn_Deselect";
            this.JO_Btn_Deselect.Size = new System.Drawing.Size(75, 23);
            this.JO_Btn_Deselect.TabIndex = 19;
            this.JO_Btn_Deselect.Text = "Deselect";
            this.JO_Btn_Deselect.UseVisualStyleBackColor = true;
            this.JO_Btn_Deselect.Click += new System.EventHandler(this.JO_Btn_Deselect_Click);
            // 
            // JO_YL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 623);
            this.Controls.Add(this.JO_Btn_Deselect);
            this.Controls.Add(this.JO_Lbl_TitlesTimeTaken);
            this.Controls.Add(this.JO_Lbl_TitlesCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.JO_TxtBoxYearBorn);
            this.Controls.Add(this.JO_TextBox_Author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JO_ListBox_Titles);
            this.Controls.Add(this.JO_Btn_Titles);
            this.Controls.Add(this.JO_Btn_Delete);
            this.Controls.Add(this.JO_Btn_Update);
            this.Controls.Add(this.JO_Btn_Insert);
            this.Controls.Add(this.JO_Lbl_AuthorsTimeTaken);
            this.Controls.Add(this.JO_Lbl_AuthorsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.JO_ListBox_Authors);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "JO_YL1";
            this.Text = "YL1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox JO_ListBox_Authors;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label JO_Lbl_AuthorsCount;
        private System.Windows.Forms.Label JO_Lbl_AuthorsTimeTaken;
        private System.Windows.Forms.Button JO_Btn_Insert;
        private System.Windows.Forms.Button JO_Btn_Update;
        private System.Windows.Forms.Button JO_Btn_Delete;
        private System.Windows.Forms.Button JO_Btn_Titles;
        private System.Windows.Forms.ListBox JO_ListBox_Titles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox JO_TextBox_Author;
        private System.Windows.Forms.TextBox JO_TxtBoxYearBorn;
        private System.Windows.Forms.Label JO_Lbl_TitlesTimeTaken;
        private System.Windows.Forms.Label JO_Lbl_TitlesCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton JO_ToolBtn_OpenDB;
        private System.Windows.Forms.ToolStripButton JO_ToolBtn_ReadAuthors;
        private System.Windows.Forms.Button JO_Btn_Deselect;
    }
}