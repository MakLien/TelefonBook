using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Test så att jag vet om Databasen är  kopplad till WFA
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database5.accdb";
            conn.Open();
            MessageBox.Show("ok");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database5DataSet5.Tabell1' table. You can move, or remove it, as needed.
            this.tabell1TableAdapter.Fill(this.database5DataSet5.Tabell1);


        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Gör så att man kan see datan man skriver in för att spara in i databasen live med hjälpa va att klicka på knappen
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database5.accdb";
            conn.Open();

            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from  Tabell1";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

           // Skapar koppling mellan WFA Och Acces data basen
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database5.accdb";
            conn.Open();

            // Det skall lägga till data fält som man skriver inn i FullName, Phone, Email, Klass och sedan sparas i Data basen och sedan har jag gjort en knapp som upptaterar Databasen så infon man skriver in är synlig
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "INSERT INTO Tabell1(FullName, Phone, Email, Klass)" + "VALUES ('" + NameBox.Text + "', '" + PhoneBox.Text + "', '" + EmailBox.Text + "', '" + KlassBox.Text + "')";
            comm.Connection = conn;
            comm.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully saved");

            // tömer allt inom texbox som på cancel knappen fast automatiskt efter kommandot
            NameBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";
            KlassBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // tömer allt inom texbox texten när man klickar på knappen
            NameBox.Text = "";
            PhoneBox.Text = "";
            EmailBox.Text = "";
            KlassBox.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Visa_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider = Microsoft.ace.oledb.12.0; Data Source = Database5.accdb";
            conn.Open();

            // Tar all data från tabellen "Person_info" och lägger det i mitt datavisningsfällt när mitt pogram startas.
            OleDbCommand comm = new OleDbCommand();
            comm.CommandText = "Select * from Tabell1";
            comm.Connection = conn;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = comm;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            Form2 frmadd = new Form2();
            frmadd.ShowDialog();

        }
    }
}
