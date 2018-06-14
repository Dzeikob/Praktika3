using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joonas_Praktika3
{
    public partial class JO_YL4 : Form
    {
        public JO_YL4()
        {
            InitializeComponent();
        }

        private static OleDbConnection connection;

        private void JO_ToolBtn_OpenDB_Click(object sender, EventArgs e)
        {
            connection = DbConnection.OpenDatabaseConnection();
            if (connection != null)
            {
                FillNadalLists();
            }
            else
            {
                MessageBox.Show("Error opening database");
            }
        }

        private void FillNadalLists()
        {
            JO_ListBox_Nadal1.DataSource = ExcelQueries.GetNadalValues(connection);
            JO_ListBox_Nadal2.DataSource = ExcelQueries.GetNadalValues(connection);
            
            JO_ListBox_Nadal1.SelectedIndexChanged += JO_ListBox_Nadal1_SelectedIndexChanged;
            JO_ListBox_Nadal2.SelectedIndexChanged += JO_ListBox_Nadal1_SelectedIndexChanged;
        }

        private void JO_ListBox_Nadal1_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            JO_ListBox_Difference.DataSource = GetDifference((Nadal)JO_ListBox_Nadal1.SelectedItem, (Nadal)JO_ListBox_Nadal2.SelectedItem);

        }
        private List<string> GetDifference(Nadal nadal1, Nadal nadal2)
        {
            List<string> differences = new List<string>();
            List<int> checkedIDlist = new List<int>();
            for (int i = 0; i < nadal1.Tooted.Count; i++)
            {
                Toode toode1 = nadal1.Tooted[i];
                Toode toode2 = nadal2.Tooted.Find(j => j.TooteID == toode1.TooteID);
                
                //If there is not equilevant to toode1, its new or deleted
                if(toode2 == null)
                {
                    differences.Add($"{nadal1.NadalNumber}.nadalal oli toode {toode1.TooteID} mida polnud {nadal2.NadalNumber}.nadalal");
                }
                else if(toode2.Hind != toode1.Hind)
                {
                    differences.Add($"{nadal1.NadalNumber}.nadal = {toode1.TooteID} = {toode1.Hind} EUR | {nadal2.NadalNumber}.nadalal = {toode2.TooteID} = {toode2.Hind} EUR");
                }
                checkedIDlist.Add(toode1.TooteID);
            }
            for (int i = 0; i < nadal2.Tooted.Count; i++)
            {
                Toode toode1 = nadal2.Tooted[i];
                Toode toode2 = nadal1.Tooted.Find(j => j.TooteID == toode1.TooteID);
                
                //If already checked previously then continue;
                if (checkedIDlist.Contains(toode1.TooteID)) continue;
                //If there is not equilevant to toode1, its new or deleted
                if (toode2 == null)
                {
                    differences.Add($"{nadal2.NadalNumber}.nadalal oli toode {toode1.TooteID} mida polnud {nadal1.NadalNumber}.nadalal");
                }
                else if (toode2.Hind != toode1.Hind)
                {
                    differences.Add($"{nadal2.NadalNumber}.nadal = {toode1.TooteID} = {toode1.Hind} EUR | {nadal1.NadalNumber}.nadalal = {toode2.TooteID} = {toode2.Hind} EUR");
                }
                checkedIDlist.Add(toode1.TooteID);
            }
            JO_Lbl_DifferenceCount.Text = differences.Count.ToString();

            return differences;
        }
    }
}
