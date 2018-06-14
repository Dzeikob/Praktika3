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
        public static void InsertToDatabase(Toode item, OleDbConnection connection)
        {
            item.TooteKirjeldus = item.TooteKirjeldus.Replace("'", "''");

            string query =
            "INSERT INTO Hinnakiri (TooteGrupp, Tootja, Toode, Hind) " +
            $"VALUES ('{item.TooteGrupp}', '{item.Tootja}', '{item.TooteKirjeldus}', '{item.Hind}')";

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
        public static void ClearTootjadTable(OleDbConnection connection)
        {
            string query = "DELETE FROM Tootjad";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static void ClearGrupidTable(OleDbConnection connection)
        {
            string query = "DELETE FROM Grupid";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static void ClearTootedTable(OleDbConnection connection)
        {
            string query = "DELETE FROM Tooted";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static void ClearNadalTable(OleDbConnection connection)
        {
            string query = "DELETE FROM Nadalad";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static List<Nadal> GetNadalValues(OleDbConnection connection)
        {
            string query =
                "SELECT * FROM Nadalad";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();

            List<Nadal> nadalad = new List<Nadal>();

            while(reader.Read())
            {
                
                Toode toode = new Toode();
                toode.TooteID = Convert.ToInt32(reader["TooteID"]);
                toode.Hind = reader["Hind"].ToString();
                int nadalNumber = Convert.ToInt32(reader["Nadal"]);
                int nadalIndex = DoesNadalExist(nadalad, nadalNumber);
                if (nadalIndex == -1)
                {
                    Nadal nadal = new Nadal();
                    nadal.NadalNumber = nadalNumber;
                    nadal.AddToode(toode);
                    nadalad.Add(nadal);
                }
                else
                {
                    nadalad[nadalIndex].AddToode(toode);
                }
                
            }
            return nadalad;
        }
        private static int DoesNadalExist(List<Nadal> items, int nadal)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (item.NadalNumber == nadal) return i;
                i++;
            }
            return -1;
        }


    }
}
