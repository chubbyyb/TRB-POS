using System;
using System.Data;
using System.Data.OleDb;
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
    }
}
