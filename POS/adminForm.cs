using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Windows.Forms;

namespace POS
{
    public partial class adminForm : Form
    {
        public const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keith\OneDrive - Technological University Dublin\Documents\Database2.accdb";
        public const string connectionStringRecords = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keith\OneDrive - Technological University Dublin\Documents\Database3.accdb";


        public adminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display the data
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbDataAdapter oleDbDa = new OleDbDataAdapter("SELECT * FROM Table1", conn);
                DataTable dtbl = new DataTable();
                oleDbDa.Fill(dtbl);

                stockData.DataSource = dtbl;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Display the data
            using (OleDbConnection conn = new OleDbConnection(connectionStringRecords))
            {
                conn.Open();
                OleDbDataAdapter oleDbDa = new OleDbDataAdapter("SELECT * FROM Table1", conn);
                DataTable dtbl = new DataTable();
                oleDbDa.Fill(dtbl);

                purchaseData.DataSource = dtbl;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Profit today
            using (OleDbConnection conn = new OleDbConnection(connectionStringRecords))
            {
                conn.Open();
                OleDbDataAdapter oleDbDa = new OleDbDataAdapter($"SELECT SUM(totalPrice) FROM Table1 WHERE dateValue(dateOfTransaction) = '{DateTime.Now.ToString("dd/MM/yyyy")}'", conn);
                DataTable resultTable = new DataTable();
                oleDbDa.Fill(resultTable);


                object resultValue = resultTable.Rows[0][0];
                moneyTodayLbl.Text = $"Profit Today: €{resultValue}";
            }
        }

        private void moneyTodayLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
