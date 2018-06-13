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
        public static int GetTooteID(string Toode, OleDbConnection connection)
        {
            Toode = Toode.Replace("'", "''");

            string query =
                "SELECT TooteID FROM Tooted " +
                $"WHERE Toode = '{Toode}'";

            OleDbCommand command = new OleDbCommand(query, connection);
            int id = -1;

            object answer = command.ExecuteScalar();

            if (answer != null)
            {
                id = (int)answer;
            }

            return id; //Return -1 if not found
        }

        public static int GetGruppID(string grupp, OleDbConnection connection)
        {
            string query =
                "SELECT GruppID FROM Grupid " +
                $"WHERE Grupp = '{grupp}'";

            OleDbCommand command = new OleDbCommand(query, connection);
            int id = -1;

            object answer = command.ExecuteScalar();

            if (answer != null)
            {
                id = (int)answer;
            }

            return id; //Return -1 if not found
        }
        public static void InsertGruppToDatbase(string grupp, OleDbConnection connection)
        {
            string query = "INSERT INTO Grupid (Grupp) " +
            $"VALUES ('{grupp}')";

            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static int GetTootjaID(string tootja, OleDbConnection connection)
        {
            string query =
                "SELECT TootjaID FROM Tootjad " +
                $"WHERE Tootja = '{tootja}'";

            OleDbCommand command = new OleDbCommand(query, connection);
            int id = -1;

            object answer = command.ExecuteScalar();

            if (answer != null)
            {
                id = (int)answer;
            }

            return id; //Return -1 if not found
        }
        public static void InsertTootjaToDatabase(string tootja, OleDbConnection connection)
        {
            string query = "INSERT INTO Tootjad (Tootja) " +
            $"VALUES ('{tootja}')";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static void InsertNadalToDatabase(int nadal, int TooteID, string Hind, OleDbConnection connection)
        {
            string query = "INSERT INTO Nadalad (Nadal, TooteID, Hind) " +
            $"VALUES ({nadal}, {TooteID}, '{Hind}')";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        

    }
}
