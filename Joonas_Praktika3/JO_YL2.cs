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
    public partial class JO_YL2 : Form
    {
        public JO_YL2()
        {
            InitializeComponent();
            JO_DataGrid_Titles.ColumnCount = 1;
            JO_DataGrid_Authors.CellValueChanged += JO_DataGrid_Authors_CellValueChanged;
        }

        private void JO_DataGrid_Authors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Author author = new Author();

            author.AuthorID = (int)JO_DataGrid_Authors.Rows[rowIndex].Cells["AuthorID"].Value;

            if (JO_DataGrid_Authors.Rows[rowIndex].Cells["Name"].Value == null)
            {
                BiblioQueries.DeleteAuthor(author.AuthorID, connection);
                RefreshGrid();
            }
            else
            {
                author.Name = JO_DataGrid_Authors.Rows[rowIndex].Cells["Name"].Value.ToString();
                author.YearBorn = JO_DataGrid_Authors.Rows[rowIndex].Cells["Year Born"].Value.ToString();
                BiblioQueries.UpdateAuthor(author.AuthorID, author, connection);
            } 
        }


        private OleDbConnection connection;

        private void JO_Tool_OpenDB_Click(object sender, EventArgs e)
        {
            connection = DbConnection.OpenDatabaseConnection();
            
        }

        private bool _gridSetupDone = false;
        private void JO_Tool_ReadAuthors_Click(object sender, EventArgs e)
        {
            //If setup for grid has already been done, just refresh the grid.
            if(_gridSetupDone == true)
            {
                RefreshGrid();
                return;
            }
            JO_DataGrid_Authors.AutoGenerateColumns = false;
            JO_DataGrid_Authors.ColumnCount = 3;
            JO_DataGrid_Authors.DataSource = BiblioQueries.GetAuthors(connection);

            //Hide author id row for later to use.
            JO_DataGrid_Authors.Columns[0].Name = "AuthorID";
            JO_DataGrid_Authors.Columns[0].DataPropertyName = "AuthorID";
            JO_DataGrid_Authors.Columns[0].Visible = false;

            JO_DataGrid_Authors.Columns[1].Name = "Name";
            JO_DataGrid_Authors.Columns[1].DataPropertyName = "Name";

            JO_DataGrid_Authors.Columns[2].Name = "Year Born";
            JO_DataGrid_Authors.Columns[2].DataPropertyName = "YearBorn";
            

            _gridSetupDone = true;
        }
        private void RefreshGrid()
        {
            JO_DataGrid_Authors.DataSource = BiblioQueries.GetAuthors(connection);
        }

        private void JO_YL2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                connection.Close();
            }
            catch { }
        }

        private void JO_DataGrid_Authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void JO_Btn_Titles_Click(object sender, EventArgs e)
        {
            int rowIndex = JO_DataGrid_Authors.SelectedCells[0].RowIndex;
            int authorID = (int)JO_DataGrid_Authors.Rows[rowIndex].Cells["AuthorID"].Value;

            JO_DataGrid_Titles.Rows.Clear();
            foreach (string item in BiblioQueries.GetTitles(authorID, connection))
            {
                JO_DataGrid_Titles.Rows.Add(item);
            }
        }
    }
}
