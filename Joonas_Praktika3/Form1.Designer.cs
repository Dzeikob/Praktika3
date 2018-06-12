namespace Joonas_Praktika3
{
    partial class Form1
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
            this.JO_YL1 = new System.Windows.Forms.Button();
            this.JO_Btn_Yl2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JO_YL1
            // 
            this.JO_YL1.Location = new System.Drawing.Point(15, 15);
            this.JO_YL1.Margin = new System.Windows.Forms.Padding(6);
            this.JO_YL1.Name = "JO_YL1";
            this.JO_YL1.Size = new System.Drawing.Size(109, 41);
            this.JO_YL1.TabIndex = 1;
            this.JO_YL1.Text = "YL1";
            this.JO_YL1.UseVisualStyleBackColor = true;
            this.JO_YL1.Click += new System.EventHandler(this.JO_YL1_Click);
            // 
            // JO_Btn_Yl2
            // 
            this.JO_Btn_Yl2.Location = new System.Drawing.Point(15, 68);
            this.JO_Btn_Yl2.Margin = new System.Windows.Forms.Padding(6);
            this.JO_Btn_Yl2.Name = "JO_Btn_Yl2";
            this.JO_Btn_Yl2.Size = new System.Drawing.Size(109, 41);
            this.JO_Btn_Yl2.TabIndex = 2;
            this.JO_Btn_Yl2.Text = "YL2";
            this.JO_Btn_Yl2.UseVisualStyleBackColor = true;
            this.JO_Btn_Yl2.Click += new System.EventHandler(this.JO_Btn_Yl2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 202);
            this.Controls.Add(this.JO_Btn_Yl2);
            this.Controls.Add(this.JO_YL1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JO_YL1;
        private System.Windows.Forms.Button JO_Btn_Yl2;
    }
}

