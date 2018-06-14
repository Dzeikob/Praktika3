using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
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

            JO_ToolBtn_WriteToDB.Enabled = true;
        }

        private void JO_ToolBtn_ReadHinnakiri_Click(object sender, EventArgs e)
        {
            
            List<ExcelPage> pages = DbConnection.OpenExcel();

            ExcelQueries.ClearGrupidTable(connection);
            ExcelQueries.ClearTootjadTable(connection);
            ExcelQueries.ClearTootedTable(connection);
            ExcelQueries.ClearNadalTable(connection);
            

            JO_Progress_Load.Maximum = pages.Count * 3000;
            foreach (var page in pages)
            {         
                WriteExcelToDB(page);
            }
            MessageBox.Show("Successfully imported excel to database ");
        }

        private void WriteExcelToDB(ExcelPage page)
        {
            Stopwatch watch = new Stopwatch();

            watch.Start();

            xlApp = page.xlApp;
            xlWorkbook = page.xlWorkbook;
            xlWorksheet = page.xlWorksheet;

            xlRange = xlWorksheet.Cells[3, 4];
            string nadalString = Convert.ToString(xlRange.Value);
            int nadal = Convert.ToInt32(nadalString.Split(' ')[1]);

            watch.Stop();
            int SetupTime = watch.Elapsed.Milliseconds;
            watch.Reset();

            watch.Start();

            int arv = 0;
            for (int rn = 12; rn < 3000; rn++)
            {
                xlRange = xlWorksheet.Cells[rn, 4];
                if (xlRange.Value != null)
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
                JO_Progress_Load.Value++;
            }

            watch.Stop();
            int ExcelTime = watch.Elapsed.Milliseconds;
            watch.Reset();
            watch.Start();

            for (int i = 0; i < arv; i++)
            {
                //Add Grupp and get ID of it
                int GruppID = ExcelQueries.GetGruppID(Ex_mas[i, 0], connection);
                if (GruppID == -1)
                {
                    ExcelQueries.InsertGruppToDatbase(Ex_mas[i, 0], connection);
                    GruppID = ExcelQueries.GetGruppID(Ex_mas[i, 0], connection);
                }

                //Add Tootja and get ID of it
                int TootjaID = ExcelQueries.GetTootjaID(Ex_mas[i, 1], connection);
                if (TootjaID == -1)
                {
                    ExcelQueries.InsertTootjaToDatabase(Ex_mas[i, 1], connection);
                    TootjaID = ExcelQueries.GetTootjaID(Ex_mas[i, 1], connection);
                }

                //Send toode to database
                int TooteID = ExcelQueries.GetTooteID(Ex_mas[i, 2], connection);
                if(TooteID == -1)
                {
                    ExcelQueries.InsertToodeToDatabase(Ex_mas[i, 2], GruppID, TootjaID, connection);
                    TooteID = ExcelQueries.GetTooteID(Ex_mas[i, 2], connection);
                }
                

                ExcelQueries.InsertNadalToDatabase(nadal, TooteID, Ex_mas[i, 3], connection);
            }
            watch.Stop();
            int QueriesTime = watch.Elapsed.Milliseconds;
            
            
        }

        private void JO_YL3_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
