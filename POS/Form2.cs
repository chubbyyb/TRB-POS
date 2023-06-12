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
        public const string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keith\OneDrive - Technological University Dublin\Documents\Database2.accdb";
        public const string connectionStringRecords = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\keith\OneDrive - Technological University Dublin\Documents\Database3.accdb";



        Dictionary<string, int> productsDict =
                       new Dictionary<string, int>();

        Dictionary<string, int> productPosition =
            new Dictionary<string, int>();


        public Form2()
        {
            InitializeComponent();
            errorLabel.Visible = false;


            //Disable cash/card buttons
            panelFinishTransactionCardBtn.Enabled = false;
            panelFinishTransactionCashBtn.Enabled = false;

            //Disable goBackButton
            goBackTransactionBtn.Visible = false;
            goBackTransactionBtn.Enabled = false;
            //transactionPanel.BackColor = Color.FromArgb(25, Color.Black);


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

            // SQL query to search for the number "00002" under the "Product ID" table
            string sqlQuery = $"SELECT * FROM Table1 WHERE ProductID = @ProductID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the database connection
                connection.Open();

                // Create a command object with the SQL query and connection
                OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                command.Parameters.AddWithValue("@ProductID", currentProductID);

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
                            //Text = "",
                            //ForeColor = Color.Black,
                            BackColor = Color.CornflowerBlue,
                            FlatStyle = FlatStyle.Flat,
                        };
                        quantityButton.Click += quant_Click;
                        quantityButton.FlatAppearance.BorderSize = 0;


                        if (productsDict.ContainsKey(productName)) // if product exists
                        {
                            // Increment product value
                            Debug.WriteLine("Already exists, incrementing product");
                            productsDict[productName]++;

                            // Increment product quantity label
                            Debug.WriteLine($"\n Amount of item: {productsDict[productName]}");
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

                            // Add Selection button
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

            productIDtxt.Clear();
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


        // Deletion button [Removed]
        private void Button_Click(object sender, EventArgs e)
        {
            //Button clickedButton = (Button)sender;

            //MessageBox.Show($"Button in row {buyingPanel.GetRow(clickedButton)} clicked");
            //Debug.WriteLine($"Button in row {buyingPanel.GetRow(clickedButton)} clicked");

            //int rowPressed = buyingPanel.GetRow(clickedButton);

            // Remove presence from productsDict and productPosition
            //productsDict.Remove(buyingPanel.GetControlFromPosition(0, rowPressed).Text);
            //productPosition.Remove(buyingPanel.GetControlFromPosition(0, rowPressed).Text);

            // Adjust the price
            //priceOfGoods = priceOfGoods - decimal.Parse(buyingPanel.GetControlFromPosition(1, rowPressed).Text);
            //totalPrice.Text = "Price: €" + priceOfGoods.ToString();

            // Delete the row
            //for (int i = 0; i < buyingPanel.ColumnCount; i++)
            //{
            // Control Control = buyingPanel.GetControlFromPosition(i, rowPressed);
            // buyingPanel.Controls.Remove(Control);
            //}

            // Decrement all productPosition above x
            // Move rows up

        }

        // Selection button
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

        // base quantity button
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

                using (quantitySelectorForm quantitySelectorForm = new quantitySelectorForm())
                {

                    DialogResult dialogResult = quantitySelectorForm.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        if ((Int32.TryParse(quantitySelectorForm.selectedText, out quantityAmountInteger) == false) || quantityAmountInteger < 1)
                        {
                            MessageBox.Show("Ivalid selection, number must be over 1!");
                            return;
                        }
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("Process cancelled");
                        return;
                    }
                }



                decimal productPrice = 0;
                string productSelected = buyingPanel.GetControlFromPosition(productNameCol, rowPressed).Text;

                string sqlQuery = $"SELECT * FROM Table1 WHERE ProductName = @productSelected";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    // Open the database connection
                    connection.Open();

                    // Create a command object with the SQL query and connection
                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@ProductID", productSelected);

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
                // Get discount amount
                using (DiscountEuro DiscountEuro = new DiscountEuro())
                {

                    DialogResult dialogResult = DiscountEuro.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        if ((Decimal.TryParse(DiscountEuro.selectedText, out percentDiscountDecimal) == false) || percentDiscountDecimal < 1)
                        {
                            MessageBox.Show("Ivalid selection, number must be over 1!");
                            return;
                        }
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("Process cancelled");
                        return;
                    }
                }


                // Adjust total price
                priceOfGoods = priceOfGoods - priceOfRow;

                // Adjust row price
                priceOfRow = priceOfRow * ((100 - percentDiscountDecimal) / 100);

                if (priceOfRow == 0)
                {
                    priceOfRow = 0;
                    buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text = "0";

                }
                else
                {
                    buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text = priceOfRow.ToString("0.00");
                }

                // Adjust total price label
                totalPrice.Text = $"Price: €{(priceOfGoods).ToString("0.00")}";
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
                using (DiscountEuro DiscountEuro = new DiscountEuro())
                {

                    DialogResult dialogResult = DiscountEuro.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        if ((Decimal.TryParse(DiscountEuro.selectedText, out euroDiscountDecimal) == false) || euroDiscountDecimal < 1)
                        {
                            MessageBox.Show("Ivalid selection, number must be over 1!");
                            return;
                        }
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("Process cancelled");
                        return;
                    }
                }


                // Adjust row price
                priceOfRow = priceOfRow - euroDiscountDecimal;

                if (priceOfRow == 0)
                {
                    priceOfRow = 0;
                    buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text = "0";

                }
                else
                {
                    buyingPanel.GetControlFromPosition(productPriceCol, rowPressed).Text = priceOfRow.ToString("0.00");
                }

                // Adjust total price
                priceOfGoods = priceOfGoods - euroDiscountDecimal;

                // Adjust total price label
                totalPrice.Text = $"Price: €{(priceOfGoods).ToString("0.00")}";
            }
        }

        private void panelFinishTransactionCardBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("________TYPE: CARD________");

            decimal productPrice = 0;
            string sqlQuery = "";

            foreach (KeyValuePair<string, int> pair in productsDict)
            {
                // divide by 0 error checking
                if (decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, productPosition[pair.Key]).Text) == 0)
                {
                    productPrice = 0;
                    Debug.WriteLine("Product: " + pair.Key + ", Quantity: " + pair.Value + ", Price: € FREE");
                }
                else
                {
                    productPrice = (decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, productPosition[pair.Key]).Text) / pair.Value) * productsDict[pair.Key];
                    Debug.WriteLine("Product: " + pair.Key + ", Quantity: " + pair.Value + ", Price: €" + productPrice.ToString("0.00"));
                }

            }

            try
            {
                sqlQuery = $"INSERT INTO Table1 (totalPrice, dateOfTransaction, type) VALUES (@priceOfGoods, @DateOfTransaction, @Card)";

                using (OleDbConnection connection = new OleDbConnection(connectionStringRecords))
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@priceOfGoods", priceOfGoods);
                    command.Parameters.AddWithValue("@DateOfTransaction", DateTime.Now.ToString("dd/MM/yy"));
                    command.Parameters.AddWithValue("@Type", "Card");
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message
                Debug.WriteLine("An error occurred: " + ex.Message);
            }

            // Refresh after every transaction
            this.Controls.Clear();
            InitializeComponent();
            startingPosX = 29;
            startingPosY = 11;
            column = 0;
            row = 0;
            rowPressed = -1;
            priceOfGoods = 0;
            productsDict.Clear();
            productPosition.Clear();
            errorLabel.Visible = false;
            //Disable cash/card buttons
            panelFinishTransactionCardBtn.Enabled = false;
            panelFinishTransactionCashBtn.Enabled = false;

            //Disable goBackButton
            goBackTransactionBtn.Visible = false;
            goBackTransactionBtn.Enabled = false;
            //transactionPanel.BackColor = Color.FromArgb(25, Color.Black);

        }

        private void panelFinishTransactionCashBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("________TYPE: CASH________");

            decimal productPrice = 0;
            string sqlQuery = "";

            foreach (KeyValuePair<string, int> pair in productsDict)
            {
                // divide by 0 error checking
                if (decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, productPosition[pair.Key]).Text) == 0)
                {
                    productPrice = 0;
                    Debug.WriteLine("Product: " + pair.Key + ", Quantity: " + pair.Value + ", Price: € FREE");
                }
                else
                {
                    productPrice = (decimal.Parse(buyingPanel.GetControlFromPosition(productPriceCol, productPosition[pair.Key]).Text) / pair.Value) * productsDict[pair.Key];
                    Debug.WriteLine("Product: " + pair.Key + ", Quantity: " + pair.Value + ", Price: €" + productPrice.ToString("0.00"));
                }

            }

            // Record Transaction
            try
            {
                sqlQuery = $"INSERT INTO Table1 (totalPrice, dateOfTransaction, type) VALUES (@priceOfGoods, @DateOfTransaction, @Type)";

                using (OleDbConnection connection = new OleDbConnection(connectionStringRecords))
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@priceOfGoods", priceOfGoods);
                    command.Parameters.AddWithValue("@DateOfTransaction", DateTime.Now.ToString("dd/MM/yy"));
                    command.Parameters.AddWithValue("@Type", "Cash");
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error message
                Debug.WriteLine("An error occurred during transaction logging: " + ex.Message);
            }


            // Stock Management
            try
            {


                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    foreach (KeyValuePair<string, int> pair in productsDict)
                    {
                        sqlQuery = $"UPDATE Table1 SET AmountOfStock = AmountOfStock - {pair.Value} WHERE ProductName = @ProductName";
                        OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@ProductName", pair.Key);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }
            }
            catch(Exception ex) 
            {
                // Handle the exception or log the error message
                Debug.WriteLine("An error occurred during stock management: " + ex.Message);
            }


            // Refresh after every transaction
            this.Controls.Clear();
            InitializeComponent();
            startingPosX = 29;
            startingPosY = 11;
            column = 0;
            row = 0;
            rowPressed = -1;
            priceOfGoods = 0;
            productsDict.Clear();
            productPosition.Clear();
            errorLabel.Visible = false;
            //Disable cash/card buttons
            panelFinishTransactionCardBtn.Enabled = false;
            panelFinishTransactionCashBtn.Enabled = false;

            //Disable goBackButton
            goBackTransactionBtn.Visible = false;
            goBackTransactionBtn.Enabled = false;
            //transactionPanel.BackColor = Color.FromArgb(25, Color.Black);
        }

        private void finishTransactionBtn_Click(object sender, EventArgs e)
        {

            if (productsDict.Count == 0)
            {
                MessageBox.Show("No Items scanned!");
            }
            else
            {
                goBackTransactionBtn.Enabled = true;
                goBackTransactionBtn.Visible = true;

                transactionPanel.BorderStyle = BorderStyle.FixedSingle;
                panelFinishTransactionCardBtn.Enabled = true;
                panelFinishTransactionCashBtn.Enabled = true;

                productIDbtn.Enabled = false;
                baseDeleteBtn.Enabled = false;
                baseQBtn.Enabled = false;
                baseDiscountEur.Enabled = false;
                baseDiscountPrcnt.Enabled = false;
                logOutButton.Enabled = false;

                finishTransactionBtn.Enabled = false;
            }
        }

        private void goBackTransactionBtn_Click(object sender, EventArgs e)
        {
            productIDbtn.Enabled = true;
            baseDeleteBtn.Enabled = true;
            baseQBtn.Enabled = true;
            baseDiscountEur.Enabled = true;
            baseDiscountPrcnt.Enabled = true;
            logOutButton.Enabled = true;

            transactionPanel.BorderStyle = BorderStyle.None;
            panelFinishTransactionCardBtn.Enabled = false;
            panelFinishTransactionCashBtn.Enabled = false;


            goBackTransactionBtn.Enabled = false;
            goBackTransactionBtn.Visible = false;

            finishTransactionBtn.Enabled = true;
        }

        private void productIDtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                productIDbtn_Click(sender, e);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
