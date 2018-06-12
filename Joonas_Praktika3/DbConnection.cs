using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
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
            
            return null;
        }
    }
}
