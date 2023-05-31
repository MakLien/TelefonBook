using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbProj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // gömmer formen som gör att det ser ut som att den stängs av när man klickar på knappen
            this.Hide();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database5.accdb";
            conn.Open();

            // I denna koden tas Id from tabellen och när man skriver in ids nummer kommer radern med samma id i tabellen tas bort. 
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "delete from Tabell1 where ID  = " + Idbox.Text + "";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully deleted");
            this.Hide();
        }
    }
}
