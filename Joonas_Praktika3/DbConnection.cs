using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace Joonas_Praktika3
{
    public static class DbConnection
    {
        public static OleDbConnection OpenDatabaseConnection()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "db files (*.mdb, *.accdb) | *.mdb; *.accdb";

            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK)
            {
                string source = ofd.FileName;
                string connectionString = "Provider=Microsoft.Ace.OLEDB.12.0; Data Source=" + source + ";";
                OleDbConnection connection = new OleDbConnection(connectionString);
                connection.Open();
                return connection;
            }
            else
            {
                return null;
            }   
        }
        public static ExcelPage OpenExcel()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files | *.XLS; *.XLSX; *XLSM;";

            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                ExcelPage page = new ExcelPage();

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(ofd.FileName);
                Excel.Worksheet xlWorksheet = xlWorkbook.Worksheets["Täishinnakiri"];

                page.xlApp = xlApp;
                page.xlWorkbook = xlWorkbook;
                page.xlWorksheet = xlWorksheet;

                return page;
            }
            else
            {
                return null;
            }
            
        }
    }
}
