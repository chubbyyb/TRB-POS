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
        int rowPressed = -1;
        decimal priceOfGoods = 0;

        public const int amountOfColumns = 3;
        public const int productNameCol = 0;
        public const int productPriceCol = 1;
        public const int productQntCol = 2;


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

                        Button deleteButton = new Button()
                        {
                            Text = "D",
                            ForeColor = Color.Blue,
                            BackColor = Color.White,
                        };
                        deleteButton.Click += Button_Click;

                        Button quantityButton = new Button()
                        {
                            Text = "Q",
                            ForeColor = Color.Blue,
                            BackColor = Color.White,
                        };
                        quantityButton.Click += quant_Click;


                        if (productsDict.ContainsKey(productName)) // if product exists
                        {
                            // Increment product value
                            Debug.WriteLine("Already exists, incrementing product");
                            productsDict[productName]++;

                            // Change labels
                            Debug.WriteLine($"\n Amount of item: {(buyingPanel.GetControlFromPosition(productQntCol, productPosition[productName])).Text}");

                            // Change Quantity
                            buyingPanel.GetControlFromPosition(productQntCol, productPosition[productName]).Text =
                               (Int32.Parse(buyingPanel.GetControlFromPosition(productQntCol, productPosition[productName]).Text) + 1).ToString();

                            // Change Price
                            buyingPanel.GetControlFromPosition(1, productPosition[productName]).Text =
                                (decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, productPosition[productName]).Text) + productPrice).ToString();

                            // Change Total Price
                            priceOfGoods = priceOfGoods + productPrice;
                            totalPrice.Text = $"Price: €{(priceOfGoods).ToString()}";


                        }
                        else
                        {
                            // Add new product
                            Debug.WriteLine("Product does not exist (in dictionary), adding product");
                            productsDict.Add(productName, 1);
                            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
                            buyingPanel.Controls.Add(label1, productNameCol, row); // Column, Row
                            buyingPanel.Controls.Add(label2, productPriceCol, row);
                            buyingPanel.Controls.Add(label3, productQntCol, row);

                            // Add deletion and quantity button
                            buyingPanel.Controls.Add(deleteButton, column + 3, row);
                            buyingPanel.Controls.Add(quantityButton, column + 4, row);

                            // Change total price
                            priceOfGoods = priceOfGoods + productPrice;
                            totalPrice.Text = $"Price: €{(priceOfGoods).ToString()}";

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


        // Button click event handler
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            // Perform actions specific to the second row button
            //MessageBox.Show($"Button in row {buyingPanel.GetRow(clickedButton)} clicked");
            Debug.WriteLine($"Button in row {buyingPanel.GetRow(clickedButton)} clicked");

            int rowPressed = buyingPanel.GetRow(clickedButton);

            // Remove presence from productsDict and productPosition
            productsDict.Remove(buyingPanel.GetControlFromPosition(0, rowPressed).Text);
            productPosition.Remove(buyingPanel.GetControlFromPosition(0, rowPressed).Text);

            // Adjust the price
            priceOfGoods = priceOfGoods - decimal.Parse(buyingPanel.GetControlFromPosition(1, rowPressed).Text);
            totalPrice.Text = "Price: €" + priceOfGoods.ToString();

            // Delete the row
            for (int i = 0; i < buyingPanel.ColumnCount; i++)
            {
                Control Control = buyingPanel.GetControlFromPosition(i, rowPressed);
                buyingPanel.Controls.Remove(Control);
            }

            // Decrement all productPosition above x
            // Move rows up

        }

        private void quant_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            Debug.WriteLine($"Button in row {buyingPanel.GetRow(clickedButton)} clicked");

            // Clear previously selected row
            if (rowPressed == -1 || buyingPanel.GetControlFromPosition(0, rowPressed) == null)
            {
                Debug.WriteLine("Ignored (clear previously selected row) [Nothing selected previously]");
            }
            else
            {
                for (int i = 0; i < amountOfColumns; i++)
                {
                    buyingPanel.GetControlFromPosition(i, rowPressed).BackColor = Color.FromArgb(46, 51, 73);
                }
            }

            rowPressed = buyingPanel.GetRow(clickedButton);


            // Selected
            for (int i = 0; i < amountOfColumns; i++)
            {
                buyingPanel.GetControlFromPosition(i, rowPressed).BackColor = Color.LightBlue;
            }

            // Clear highlighting after another thing is highlighted
        }

        // base delete button
        private void button1_Click(object sender, EventArgs e)
        {
            if (rowPressed == -1 || buyingPanel.GetControlFromPosition(0, rowPressed) == null)
            {
                MessageBox.Show("Nothing selected!");
            }
            else
            {
                // Remove presence from productsDict and productPosition
                productsDict.Remove(buyingPanel.GetControlFromPosition(0, rowPressed).Text);
                productPosition.Remove(buyingPanel.GetControlFromPosition(0, rowPressed).Text);

                // Adjust the price
                priceOfGoods = priceOfGoods - decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text);
                totalPrice.Text = "Price: €" + priceOfGoods.ToString();

                // Delete the row
                for (int i = 0; i < buyingPanel.ColumnCount; i++)
                {
                    Control Control = buyingPanel.GetControlFromPosition(i, rowPressed);
                    buyingPanel.Controls.Remove(Control);
                }

                // Decrement all productPosition above x
                // Move rows up
            }
        }


        private void baseQBtn_Click(object sender, EventArgs e)
        {

            if (rowPressed == -1 || buyingPanel.GetControlFromPosition(0, rowPressed) == null)
            {
                MessageBox.Show("Nothing selected!");
            }
            else
            {

                string quantityAmount = "a";
                int quantityAmountInteger = 0;
                do
                {
                    quantityAmount = Microsoft.VisualBasic.Interaction.InputBox("How many items?", "Quantity Selector", "1-999");
                } while (Int32.TryParse(quantityAmount, out quantityAmountInteger) == false || quantityAmountInteger < 1);


                decimal productPrice = 0;
                string productSelected = buyingPanel.GetControlFromPosition(productNameCol, rowPressed).Text;

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keith\OneDrive - Technological University Dublin\Documents\Database2.accdb";
                string sqlQuery = $"SELECT * FROM Table1 WHERE ProductName = \"{(productSelected)}\"";

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
                            productPrice = reader.GetDecimal(reader.GetOrdinal("Price"));

                            Debug.WriteLine(productPrice);

                            // Adjust the price
                            priceOfGoods = priceOfGoods - (productPrice * Int32.Parse((buyingPanel.GetControlFromPosition(productQntCol, rowPressed).Text)));
                            priceOfGoods = priceOfGoods + (productPrice * quantityAmountInteger);
                        }
                    }


                    Debug.WriteLine("hello");

                    // Remove from productsDict
                    productsDict[productSelected] = quantityAmountInteger;

                    // Adjust the display price
                    totalPrice.Text = $"Price: €{(priceOfGoods).ToString()}";

                    // Adjust col quantity and display price
                    buyingPanel.GetControlFromPosition(productQntCol, rowPressed).Text =
                        quantityAmountInteger.ToString();

                    Debug.WriteLine(productPrice);
                    buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text =
                        (quantityAmountInteger * productPrice).ToString();

                    // Close the data reader and database connection
                    reader.Close();
                    connection.Close();
                }
            }

        }

        private void baseDiscountPrcnt_Click(object sender, EventArgs e)
        {
            if (rowPressed == -1 || buyingPanel.GetControlFromPosition(0, rowPressed) == null)
            {
                MessageBox.Show("Nothing selected!");
            }
            else
            {
                decimal priceOfRow = 0;
                string percentDiscount = "a";
                decimal percentDiscountDecimal = 0;
                priceOfRow = decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text);

                // Get discount amount
                do
                {
                    percentDiscount = Microsoft.VisualBasic.Interaction.InputBox("How much discount (%) ?", "Discount Selector", "50");
                } while (decimal.TryParse(percentDiscount, out percentDiscountDecimal) == false || percentDiscountDecimal < 1 || percentDiscountDecimal > 100);


                // Adjust total price
                priceOfGoods = priceOfGoods - priceOfRow;

                // Adjust row price
                priceOfRow = priceOfRow * ((100 - percentDiscountDecimal) / 100);
                buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text = priceOfRow.ToString("#.##");

                // Adjust total price label
                totalPrice.Text = $"Price: €{(priceOfGoods + priceOfRow).ToString("#.##")}";
            }
        }

        private void baseDiscountEur_Click(object sender, EventArgs e)
        {
            if (rowPressed == -1 || buyingPanel.GetControlFromPosition(0, rowPressed) == null)
            {
                MessageBox.Show("Nothing selected!");
            }
            else
            {
                decimal priceOfRow = 0;
                string euroDiscount = "a";
                decimal euroDiscountDecimal = 0;
                priceOfRow = decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text);

                // Get discount amount
                do
                {
                    euroDiscount = Microsoft.VisualBasic.Interaction.InputBox("How much discount (€) ?", "Discount Selector", "50.21");
                } while (decimal.TryParse(euroDiscount, out euroDiscountDecimal) == false || euroDiscountDecimal < 0);


                // Adjust total price
                priceOfGoods = priceOfGoods - priceOfRow;

                // Adjust row price
                priceOfRow = priceOfRow - euroDiscountDecimal;
                buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text = priceOfRow.ToString("#.##");

                // Adjust total price label
                totalPrice.Text = $"Price: €{(priceOfGoods + priceOfRow).ToString("#.##")}";
            }
        }
    }
}
