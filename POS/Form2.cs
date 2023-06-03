using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Net.Mail;

namespace POS
{
    public partial class Form2 : Form
    {

        int startingPosX = 29;
        int startingPosY = 11;
        int column = 0;
        int row = 0;
        decimal priceOfGoods = 0;

        Dictionary<string, int> productsDict =
                       new Dictionary<string, int>();

        Dictionary<string, int> productPosition =
            new Dictionary<string, int>();



        public Form2()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }


        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void productIDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void productIDbtn_Click(object sender, EventArgs e)
        {
            string currentProductID = productIDtxt.Text;
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keith\OneDrive - Technological University Dublin\Documents\Database2.accdb";

            // SQL query to search for the number "00002" under the "Product ID" table
            string sqlQuery = $"SELECT * FROM Table1 WHERE ProductID = \"{(productIDtxt.Text).ToString()}\"";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a command object with the SQL query and connection
                OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                // Execute the query and obtain a data reader
                OleDbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    errorLabel.Visible = false;

                    while (reader.Read())
                    {
                        // Access the values of the retrieved row
                        string productId = reader.GetString(reader.GetOrdinal("ProductID"));
                        string productName = reader.GetString(reader.GetOrdinal("ProductName"));
                        decimal productPrice = reader.GetDecimal(reader.GetOrdinal("Price"));

                        // Do something with the retrieved data
                        Debug.WriteLine($"Product Price: {productId}, Product Name: {productName}, Price: {productPrice}");

                        startingPosY = startingPosY + 20;

                        // Name label
                        Label label1 = new Label()
                        {
                            Text = productName,
                            ForeColor = Color.White,
                            BackColor = Color.FromArgb(46, 51, 73),
                            TabIndex = 10,

                        };

                        // Price label
                        Label label2 = new Label()
                        {
                            Text = productPrice.ToString(),
                            ForeColor = Color.White,
                            BackColor = Color.FromArgb(46, 51, 73),
                            TabIndex = 10,
                        };

                        // Quantity label
                        Label label3 = new Label()
                        {
                            Text = "1",
                            ForeColor = Color.White,
                            BackColor = Color.FromArgb(46, 51, 73),
                            TabIndex = 10,
                        };



                        if (productsDict.ContainsKey(productName))
                        {
                            // Increment product value
                            Debug.WriteLine("Already exists, incrementing product");
                            productsDict[productName]++;

                            // Change labels
                            Debug.WriteLine($"\n Amount of item: {(buyingPanel.GetControlFromPosition(2, productPosition[productName])).Text}");

                            // Change Quantity
                            buyingPanel.GetControlFromPosition(2, productPosition[productName]).Text =
                               (Int32.Parse(buyingPanel.GetControlFromPosition(2, productPosition[productName]).Text) + 1).ToString();

                            // Change Price
                            buyingPanel.GetControlFromPosition(1, productPosition[productName]).Text =
                                (decimal.Parse(buyingPanel.GetControlFromPosition(1, productPosition[productName]).Text) + productPrice).ToString();

                            // Change Total Price
                            priceOfGoods = priceOfGoods + productPrice;
                            totalPrice.Text = $"Price: {(priceOfGoods).ToString()}";


                        }
                        else
                        {
                            // Add new product
                            Debug.WriteLine("Product does not exist (in dictionary), adding product");
                            productsDict.Add(productName, 1);
                            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
                            buyingPanel.Controls.Add(label1, column, row); // Column, Row
                            buyingPanel.Controls.Add(label2, column + 1, row);
                            buyingPanel.Controls.Add(label3, column + 2, row);

                            // Change total price
                            priceOfGoods = priceOfGoods + productPrice;
                            totalPrice.Text = $"Price: {(priceOfGoods).ToString()}";

                            // Record position of product
                            productPosition.Add(productName, row);

                            Debug.WriteLine($"{productName} Added. Position: {row}");
                            row = row + 1;

                        }
                    }
                }
                else
                {
                    // Display error message
                    Debug.WriteLine($"No records found for {productIDtxt.Text}.");
                    errorLabel.ForeColor = Color.Red;
                    errorLabel.Text = $"No records found for {productIDtxt.Text}.";
                    errorLabel.Visible = true;
                }

                // Close the data reader and database connection
                reader.Close();
                connection.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buyingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
