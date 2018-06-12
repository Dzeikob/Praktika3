using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joonas_Praktika3
{
    public static class BiblioQueries
    {
        public static List<Author> GetAuthors(OleDbConnection connection)
        {
            string query =
                "SELECT Authors.Author, Authors.Au_ID, Authors.[Year Born]" +
                "FROM Authors " +
                "ORDER BY Authors.Author;";

            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();
            List<Author> authors = new List<Author>();
            while (reader.Read())
            {
                Author author = new Author();
                author.Name = reader[0].ToString();
                author.AuthorID = (int)reader[1];

                if (reader[2].ToString() != "")
                {
                    author.YearBorn = reader[2].ToString();
                }
                authors.Add(author);
            }
            return authors;
        }
        public static void UpdateAuthor(int authorID, Author newAuthor, OleDbConnection connection)
        {
            string birthAddon = "";
            if (newAuthor.YearBorn != "")
            {
                birthAddon = $", [Year Born] = {newAuthor.YearBorn} ";
            }

            string query =
                "UPDATE Authors " +
                $"SET Author = '{newAuthor.Name}' {birthAddon}" +
                $"WHERE Au_ID = {authorID}";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }
        public static bool DeleteAuthor(int authorID, OleDbConnection connection, bool askUser = true)
        {
            if(askUser == true)
            {
                //Ask user if he wants to delete these titles.
                string Titles = "";
                foreach (var item in GetTitles(authorID, connection))
                {
                    Titles += item + Environment.NewLine;
                }

                DialogResult result = MessageBox.Show("You are about to delete these titles: " + Environment.NewLine + Titles, "Are you sure?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return false;
            }
            

            //Delete titles
            string query =
                "DELETE t.*, ta.* " +
                "FROM [Title Author] as ta, Titles as t " +
                $"WHERE ta.Au_ID = {authorID} AND ta.ISBN = t.ISBN";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();

            query =
                "DELETE FROM Authors " +
                $"WHERE Au_ID = {authorID}";
            command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            return true;
        }
        public static List<string> GetTitles(int authorID, OleDbConnection connection)
        {
            string query =
                "SELECT t.Title " +
                "FROM [Title Author] as ta, Titles as t " +
                $"WHERE ta.Au_ID = {authorID} AND ta.ISBN = t.ISBN";
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataReader reader = command.ExecuteReader();

            List<string> Titles = new List<string>();
            while (reader.Read())
            {
                Titles.Add(reader[0].ToString());
            }
            return Titles;
        }

        public static void InsertToDatabase(Author author, OleDbConnection connection)
        {
            string query;
            if (author.YearBorn != "")
            {
                query =
                "INSERT INTO Authors (Author, [Year Born]) " +
                $"VALUES ('{author.Name}', {author.YearBorn})";

            }
            else
            {
                query =
                    "INSERT INTO Authors (Author) " +
                    $"VALUES ('{author.Name}')";
            }


            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
        }


    }
}
