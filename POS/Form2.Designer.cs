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
            goBackTransactionBtn = new Button();
            finishTransactionBtn = new Button();
            transactionPanel = new Panel();
            panelFinishTransactionCardBtn = new Button();
            panelFinishTransactionCashBtn = new Button();
            baseDiscountEur = new Button();
            baseDiscountPrcnt = new Button();
            baseQBtn = new Button();
            baseDeleteBtn = new Button();
            leftPanel = new Panel();
            totalPrice = new Label();
            buyingPanel = new TableLayoutPanel();
            productIDtxt = new TextBox();
            productIDbtn = new Button();
            errorLabel = new Label();
            panel1.SuspendLayout();
            transactionPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Brown;
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Location = new Point(12, 152);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(98, 98);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(goBackTransactionBtn);
            panel1.Controls.Add(finishTransactionBtn);
            panel1.Controls.Add(transactionPanel);
            panel1.Controls.Add(baseDiscountEur);
            panel1.Controls.Add(baseDiscountPrcnt);
            panel1.Controls.Add(baseQBtn);
            panel1.Controls.Add(baseDeleteBtn);
            panel1.Controls.Add(logOutButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 594);
            panel1.Name = "panel1";
            panel1.Size = new Size(1426, 262);
            panel1.TabIndex = 1;
            // 
            // goBackTransactionBtn
            // 
            goBackTransactionBtn.BackColor = Color.IndianRed;
            goBackTransactionBtn.FlatAppearance.BorderSize = 0;
            goBackTransactionBtn.FlatStyle = FlatStyle.Flat;
            goBackTransactionBtn.Location = new Point(1168, 7);
            goBackTransactionBtn.Name = "goBackTransactionBtn";
            goBackTransactionBtn.Size = new Size(217, 42);
            goBackTransactionBtn.TabIndex = 8;
            goBackTransactionBtn.Text = "<-----------";
            goBackTransactionBtn.UseVisualStyleBackColor = false;
            goBackTransactionBtn.Click += goBackTransactionBtn_Click;
            // 
            // finishTransactionBtn
            // 
            finishTransactionBtn.BackColor = Color.DarkOliveGreen;
            finishTransactionBtn.FlatAppearance.BorderSize = 2;
            finishTransactionBtn.FlatStyle = FlatStyle.Flat;
            finishTransactionBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            finishTransactionBtn.Location = new Point(1168, 55);
            finishTransactionBtn.Name = "finishTransactionBtn";
            finishTransactionBtn.Size = new Size(217, 42);
            finishTransactionBtn.TabIndex = 7;
            finishTransactionBtn.Text = "Finish Transaction";
            finishTransactionBtn.UseVisualStyleBackColor = false;
            finishTransactionBtn.Click += finishTransactionBtn_Click;
            // 
            // transactionPanel
            // 
            transactionPanel.BackColor = Color.FromArgb(24, 30, 20);
            transactionPanel.Controls.Add(panelFinishTransactionCardBtn);
            transactionPanel.Controls.Add(panelFinishTransactionCashBtn);
            transactionPanel.Location = new Point(1147, 112);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(255, 124);
            transactionPanel.TabIndex = 7;
            // 
            // panelFinishTransactionCardBtn
            // 
            panelFinishTransactionCardBtn.BackColor = Color.SteelBlue;
            panelFinishTransactionCardBtn.FlatAppearance.BorderSize = 0;
            panelFinishTransactionCardBtn.FlatStyle = FlatStyle.Flat;
            panelFinishTransactionCardBtn.Location = new Point(140, 13);
            panelFinishTransactionCardBtn.Name = "panelFinishTransactionCardBtn";
            panelFinishTransactionCardBtn.Size = new Size(98, 98);
            panelFinishTransactionCardBtn.TabIndex = 5;
            panelFinishTransactionCardBtn.Text = "Card";
            panelFinishTransactionCardBtn.UseVisualStyleBackColor = false;
            panelFinishTransactionCardBtn.Click += panelFinishTransactionCardBtn_Click;
            // 
            // panelFinishTransactionCashBtn
            // 
            panelFinishTransactionCashBtn.BackColor = Color.DarkOliveGreen;
            panelFinishTransactionCashBtn.FlatAppearance.BorderSize = 0;
            panelFinishTransactionCashBtn.FlatStyle = FlatStyle.Flat;
            panelFinishTransactionCashBtn.Location = new Point(21, 13);
            panelFinishTransactionCashBtn.Name = "panelFinishTransactionCashBtn";
            panelFinishTransactionCashBtn.Size = new Size(98, 98);
            panelFinishTransactionCashBtn.TabIndex = 6;
            panelFinishTransactionCashBtn.Text = "Cash";
            panelFinishTransactionCashBtn.UseVisualStyleBackColor = false;
            panelFinishTransactionCashBtn.Click += panelFinishTransactionCashBtn_Click;
            // 
            // baseDiscountEur
            // 
            baseDiscountEur.BackColor = Color.Gray;
            baseDiscountEur.FlatAppearance.BorderSize = 0;
            baseDiscountEur.FlatStyle = FlatStyle.Flat;
            baseDiscountEur.Location = new Point(517, 138);
            baseDiscountEur.Name = "baseDiscountEur";
            baseDiscountEur.Size = new Size(98, 98);
            baseDiscountEur.TabIndex = 4;
            baseDiscountEur.Text = "Discount €";
            baseDiscountEur.UseVisualStyleBackColor = false;
            baseDiscountEur.Click += baseDiscountEur_Click;
            // 
            // baseDiscountPrcnt
            // 
            baseDiscountPrcnt.BackColor = Color.Gray;
            baseDiscountPrcnt.FlatAppearance.BorderSize = 0;
            baseDiscountPrcnt.FlatStyle = FlatStyle.Flat;
            baseDiscountPrcnt.Location = new Point(401, 138);
            baseDiscountPrcnt.Name = "baseDiscountPrcnt";
            baseDiscountPrcnt.Size = new Size(98, 98);
            baseDiscountPrcnt.TabIndex = 3;
            baseDiscountPrcnt.Text = "Discount %";
            baseDiscountPrcnt.UseVisualStyleBackColor = false;
            baseDiscountPrcnt.Click += baseDiscountPrcnt_Click;
            // 
            // baseQBtn
            // 
            baseQBtn.BackColor = Color.Chocolate;
            baseQBtn.FlatAppearance.BorderSize = 0;
            baseQBtn.FlatStyle = FlatStyle.Flat;
            baseQBtn.Location = new Point(517, 34);
            baseQBtn.Name = "baseQBtn";
            baseQBtn.Size = new Size(98, 98);
            baseQBtn.TabIndex = 2;
            baseQBtn.Text = "Change Quantity";
            baseQBtn.UseVisualStyleBackColor = false;
            baseQBtn.Click += baseQBtn_Click;
            // 
            // baseDeleteBtn
            // 
            baseDeleteBtn.BackColor = Color.IndianRed;
            baseDeleteBtn.FlatAppearance.BorderSize = 0;
            baseDeleteBtn.FlatStyle = FlatStyle.Flat;
            baseDeleteBtn.Location = new Point(401, 34);
            baseDeleteBtn.Name = "baseDeleteBtn";
            baseDeleteBtn.Size = new Size(98, 98);
            baseDeleteBtn.TabIndex = 1;
            baseDeleteBtn.Text = "Delete";
            baseDeleteBtn.UseVisualStyleBackColor = false;
            baseDeleteBtn.Click += button1_Click;
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
            totalPrice.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalPrice.ForeColor = Color.LightGreen;
            totalPrice.Location = new Point(29, 557);
            totalPrice.Name = "totalPrice";
            totalPrice.Size = new Size(99, 24);
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
            productIDtxt.KeyDown += productIDtxt_KeyDown;
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
            transactionPanel.ResumeLayout(false);
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
        private Button baseDeleteBtn;
        private Button baseQBtn;
        private Button baseDiscountEur;
        private Button baseDiscountPrcnt;
        private Button panelFinishTransactionCardBtn;
        private Button panelFinishTransactionCashBtn;
        private Panel transactionPanel;
        private Button finishTransactionBtn;
        private Button goBackTransactionBtn;
    }
}