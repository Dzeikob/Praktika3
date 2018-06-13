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
using Excel = Microsoft.Office.Interop.Excel;

namespace Joonas_Praktika3
{
    public partial class JO_YL3 : Form
    {
        Excel.Application xlApp;
        Excel.Workbook xlWorkbook;
        Excel.Worksheet xlWorksheet;
        Excel.Range xlRange;
        string[,] Ex_mas = new string[3000, 4];

        public JO_YL3()
        {
            InitializeComponent();
        }
        private OleDbConnection connection;
        private void JO_ToolBtn_OpenDB_Click(object sender, EventArgs e)
        {
            connection = DbConnection.OpenDatabaseConnection();
            if (connection == null)
            {
                MessageBox.Show("Failed to open database");
                return;
            }

            JO_ToolBtn_ReadHinnakiri.Enabled = true;
        }

        private void JO_ToolBtn_ReadHinnakiri_Click(object sender, EventArgs e)
        {
            ExcelPage page = DbConnection.OpenExcel();
            xlApp = page.xlApp;
            xlWorkbook = page.xlWorkbook;
            xlWorksheet = page.xlWorksheet;
            
            int arv = 0;
            for (int rn = 12; rn < 3000; rn++)
            {
                xlRange = xlWorksheet.Cells[rn, 4];
                if(xlRange.Value != null)
                {
                    //xlRange -- Get information about a certain cell
                    Ex_mas[arv, 3] = Convert.ToString(xlRange.Value);
                    xlRange = xlWorksheet.Cells[rn, 1];
                    Ex_mas[arv, 0] = xlRange.Value;
                    xlRange = xlWorksheet.Cells[rn, 2];
                    Ex_mas[arv, 1] = xlRange.Value;
                    xlRange = xlWorksheet.Cells[rn, 3];
                    Ex_mas[arv, 2] = xlRange.Value;
                    if (Ex_mas[arv, 2] != null)
                        arv++;
                }
            }
            
            for (int i = 0; i < arv; i++)
            {
                //PartItem item = new PartItem();
                //item.Hind = Ex_mas[i, 3];
                //item.TooteGrupp = Ex_mas[i, 0];
                //item.Tootja = Ex_mas[i, 1];
                //item.Toode = Ex_mas[i, 2];
                //MessageBox.Show(item.Hind + " " + item.TooteGrupp + " " + item.Toode + " " + item.Tootja);
                int id = ExcelQueries.GetGruppID(Ex_mas[i, 0], connection);
                if(id == -1)
                {
                    ExcelQueries.InsertGruppToDatbase(Ex_mas[i, 0], connection);
                }
                

                //ExcelQueries.InsertToDatabase(item, connection);
            }
            MessageBox.Show("lol");
        }

        private void JO_YL3_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
