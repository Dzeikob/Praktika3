using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Joonas_Praktika3
{
    public partial class JO_YL1 : Form
    {
        public JO_YL1()
        {
            InitializeComponent();

            this.FormClosing += JO_YL1_FormClosing;
            JO_ListBox_Authors.SelectedIndexChanged += JO_ListBox_Authors_SelectedIndexChanged;
        }

        

        private static OleDbConnection connection;

        private void JO_ToolBtn_OpenDB_Click(object sender, EventArgs e)
        {
            connection = DbConnection.OpenDatabaseConnection();
            if(connection == null)
            {
                MessageBox.Show("Error opening database");
                return;
            }
            JO_ToolBtn_ReadAuthors.Enabled = true;
            JO_Btn_Insert.Enabled = true;
            JO_Btn_Titles.Enabled = true;
            JO_ToolBtn_ReadAuthors.BackColor = Color.Green;
        }

        
        

        private void JO_Btn_Insert_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Name = JO_TextBox_Author.Text;
            author.YearBorn = JO_TxtBoxYearBorn.Text;

            BiblioQueries.InsertToDatabase(author, connection);
            SyncAuthors();
        }

        private void JO_ListBox_Authors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JO_ListBox_Authors.SelectedIndex == -1) return;
            ActivateEditMode();
            Author author = (Author)JO_ListBox_Authors.SelectedItem;

            JO_TextBox_Author.Text = author.Name;

            JO_TxtBoxYearBorn.Text = author.YearBorn;
            
        }

        private void ActivateEditMode()
        {
            JO_Btn_Insert.Enabled = false;
            JO_Btn_Delete.Enabled = true;
            JO_Btn_Update.Enabled = true;
        }
        private void ActivateInsertMode()
        {
            JO_Btn_Insert.Enabled = true;
            JO_Btn_Delete.Enabled = false;
            JO_Btn_Update.Enabled = false;
        }
        private void JO_Btn_Deselect_Click(object sender, EventArgs e)
        {
            JO_TextBox_Author.Clear();
            JO_ListBox_Authors.SelectedIndex = -1;
            ActivateInsertMode();
        }
        private void JO_YL1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch { }
            
        }
        private void JO_ToolBtn_ReadAuthors_Click(object sender, EventArgs e)
        {
            SyncAuthors();
        }
        private void SyncAuthors()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            JO_ListBox_Authors.DataSource = BiblioQueries.GetAuthors(connection);
            JO_Lbl_AuthorsCount.Text = JO_ListBox_Authors.Items.Count.ToString();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            JO_Lbl_AuthorsTimeTaken.Text = elapsedMs.ToString() + " ms";
        }

        private void JO_Btn_Update_Click(object sender, EventArgs e)
        {
            Author oldAuthor = (Author)JO_ListBox_Authors.SelectedItem;
            Author newAuthor = new Author();

            newAuthor.Name = JO_TextBox_Author.Text;
            newAuthor.YearBorn = JO_TxtBoxYearBorn.Text;

            BiblioQueries.UpdateAuthor(oldAuthor.AuthorID, newAuthor, connection);
            SyncAuthors();
            
        }

        private void JO_Btn_Delete_Click(object sender, EventArgs e)
        {
            Author author = (Author)JO_ListBox_Authors.SelectedItem;

            //Sync authors list only when DeleteAuthor successfully deleted a record
            if(BiblioQueries.DeleteAuthor(author.AuthorID, connection) == true)
            {
                SyncAuthors();
            }
            
        }
        
        private void JO_Btn_Titles_Click(object sender, EventArgs e)
        {
            if (JO_ListBox_Authors.SelectedIndex == -1) return;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            Author author = (Author)JO_ListBox_Authors.SelectedItem;
            JO_ListBox_Titles.DataSource = BiblioQueries.GetTitles(author.AuthorID, connection);

            var elapsedMs = watch.ElapsedMilliseconds;
            JO_Lbl_TitlesTimeTaken.Text = elapsedMs.ToString() + " ms";
            JO_Lbl_TitlesCount.Text = JO_ListBox_Titles.Items.Count.ToString();

            JO_ListBox_Titles.SelectedIndex = -1;


        }
    }
}
