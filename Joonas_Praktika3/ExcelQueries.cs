using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joonas_Praktika3
{
    public static class ExcelQueries
    {
        public static void InsertToDatabase(PartItem item, OleDbConnection connection)
        {
            item.Toode = item.Toode.Replace("'", "''");

            string query =
            "INSERT INTO Hinnakiri (TooteGrupp, Tootja, Toode, Hind) " +
            $"VALUES ('{item.TooteGrupp}', '{item.Tootja}', '{item.Toode}', '{item.Hind}')";

            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static void InsertToodeToDatabase(string Toode, int GruppID, int TootjaID, OleDbConnection connection)
        {
            Toode = Toode.Replace("'", "''");

            string query = "INSERT INTO Tooted (Toode, GruppID, TootjaID) " +
            $"VALUES ('{Toode}', {GruppID}, {TootjaID})";

            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static int GetGruppID(string grupp, OleDbConnection connection) //returns null if does not exist
        {
            string query = 
                "SELECT GruppID FROM Grupid " +
                $"WHERE Grupp = '{grupp}'";

            OleDbCommand command = new OleDbCommand(query, connection);

            int id = (int)command.ExecuteScalar();
            if(id == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(id);
            }
            
        }

    }
}
