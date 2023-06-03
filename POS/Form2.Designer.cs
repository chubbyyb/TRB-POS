namespace POS
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logOutButton = new Button();
            panel1 = new Panel();
            leftPanel = new Panel();
            totalPrice = new Label();
            buyingPanel = new TableLayoutPanel();
            productIDtxt = new TextBox();
            productIDbtn = new Button();
            errorLabel = new Label();
            panel1.SuspendLayout();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(12, 152);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(98, 98);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(logOutButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 594);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 262);
            panel1.TabIndex = 1;
            // 
            // leftPanel
            // 
            leftPanel.AutoScroll = true;
            leftPanel.BackColor = Color.FromArgb(10, 30, 54);
            leftPanel.Controls.Add(totalPrice);
            leftPanel.Controls.Add(buyingPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(392, 594);
            leftPanel.TabIndex = 2;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Location = new Point(58, 550);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(51, 15);
            totalPrice.TabIndex = 1;
            totalPrice.Text = "Price: €0";
            totalPrice.Click += label1_Click_1;
            // 
            // buyingPanel
            // 
            buyingPanel.AutoScroll = true;
            buyingPanel.ColumnCount = 5;
            buyingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.16201F));
            buyingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.83799F));
            buyingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            buyingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            buyingPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            buyingPanel.Location = new Point(29, 24);
            buyingPanel.Name = "buyingPanel";
            buyingPanel.Padding = new Padding(13, 0, 13, 0);
            buyingPanel.RowCount = 20;
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            buyingPanel.Size = new Size(340, 520);
            buyingPanel.TabIndex = 0;
            buyingPanel.Paint += buyingPanel_Paint;
            // 
            // productIDtxt
            // 
            productIDtxt.Location = new Point(428, 542);
            productIDtxt.Name = "productIDtxt";
            productIDtxt.Size = new Size(257, 23);
            productIDtxt.TabIndex = 0;
            productIDtxt.TextChanged += productIDtxt_TextChanged;
            // 
            // productIDbtn
            // 
            productIDbtn.Location = new Point(691, 542);
            productIDbtn.Name = "productIDbtn";
            productIDbtn.Size = new Size(75, 23);
            productIDbtn.TabIndex = 3;
            productIDbtn.Text = "Add";
            productIDbtn.UseVisualStyleBackColor = true;
            productIDbtn.Click += productIDbtn_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(428, 576);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "label1";
            errorLabel.Click += label1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1426, 856);
            Controls.Add(errorLabel);
            Controls.Add(productIDbtn);
            Controls.Add(productIDtxt);
            Controls.Add(leftPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logOutButton;
        private Panel panel1;
        private Panel leftPanel;
        private TextBox productIDtxt;
        private Button productIDbtn;
        private Label errorLabel;
        private TableLayoutPanel buyingPanel;
        private Label totalPrice;
    }
}