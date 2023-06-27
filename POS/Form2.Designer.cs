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
            adminButton = new Button();
            panel4 = new Panel();
            keypadBck = new Button();
            keyPad0 = new Button();
            keyPad9 = new Button();
            keyPad8 = new Button();
            keyPad7 = new Button();
            keyPad6 = new Button();
            keyPad5 = new Button();
            keyPad4 = new Button();
            keyPad3 = new Button();
            keyPad2 = new Button();
            keyPad1 = new Button();
            panel1.SuspendLayout();
            transactionPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Location = new Point(0, 544);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 262);
            panel1.TabIndex = 1;
            // 
            // goBackTransactionBtn
            // 
            goBackTransactionBtn.BackColor = Color.IndianRed;
            goBackTransactionBtn.FlatAppearance.BorderSize = 0;
            goBackTransactionBtn.FlatStyle = FlatStyle.Flat;
            goBackTransactionBtn.Location = new Point(990, 21);
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
            finishTransactionBtn.Location = new Point(990, 69);
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
            transactionPanel.Location = new Point(969, 126);
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
            leftPanel.Size = new Size(392, 544);
            leftPanel.TabIndex = 2;
            // 
            // totalPrice
            // 
            totalPrice.AutoSize = true;
            totalPrice.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalPrice.ForeColor = Color.LightGreen;
            totalPrice.Location = new Point(29, 480);
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
            buyingPanel.RowCount = 10;
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
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            buyingPanel.Size = new Size(340, 453);
            buyingPanel.TabIndex = 0;
            buyingPanel.Paint += buyingPanel_Paint;
            // 
            // productIDtxt
            // 
            productIDtxt.BorderStyle = BorderStyle.None;
            productIDtxt.Location = new Point(438, 422);
            productIDtxt.Name = "productIDtxt";
            productIDtxt.Size = new Size(257, 16);
            productIDtxt.TabIndex = 0;
            productIDtxt.TextChanged += productIDtxt_TextChanged;
            productIDtxt.Enter += current_box;
            productIDtxt.KeyDown += productIDtxt_KeyDown;
            // 
            // productIDbtn
            // 
            productIDbtn.Location = new Point(701, 418);
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
            errorLabel.Location = new Point(438, 452);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(38, 15);
            errorLabel.TabIndex = 4;
            errorLabel.Text = "label1";
            errorLabel.Click += label1_Click;
            // 
            // adminButton
            // 
            adminButton.BackColor = Color.LimeGreen;
            adminButton.FlatAppearance.BorderSize = 0;
            adminButton.FlatStyle = FlatStyle.Flat;
            adminButton.Location = new Point(1149, 24);
            adminButton.Name = "adminButton";
            adminButton.Size = new Size(75, 34);
            adminButton.TabIndex = 5;
            adminButton.Text = "Admin";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += button1_Click_1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(keypadBck);
            panel4.Controls.Add(keyPad0);
            panel4.Controls.Add(keyPad9);
            panel4.Controls.Add(keyPad8);
            panel4.Controls.Add(keyPad7);
            panel4.Controls.Add(keyPad6);
            panel4.Controls.Add(keyPad5);
            panel4.Controls.Add(keyPad4);
            panel4.Controls.Add(keyPad3);
            panel4.Controls.Add(keyPad2);
            panel4.Controls.Add(keyPad1);
            panel4.Location = new Point(873, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 394);
            panel4.TabIndex = 20;
            // 
            // keypadBck
            // 
            keypadBck.BackColor = Color.RosyBrown;
            keypadBck.BackgroundImageLayout = ImageLayout.None;
            keypadBck.FlatAppearance.BorderSize = 0;
            keypadBck.FlatStyle = FlatStyle.Flat;
            keypadBck.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keypadBck.ForeColor = SystemColors.ControlLightLight;
            keypadBck.Location = new Point(136, 276);
            keypadBck.Name = "keypadBck";
            keypadBck.Size = new Size(168, 73);
            keypadBck.TabIndex = 20;
            keypadBck.TabStop = false;
            keypadBck.Text = "<--------";
            keypadBck.TextImageRelation = TextImageRelation.TextBeforeImage;
            keypadBck.UseVisualStyleBackColor = false;
            keypadBck.Click += keypadBck_Click;
            // 
            // keyPad0
            // 
            keyPad0.BackColor = Color.Gray;
            keyPad0.BackgroundImageLayout = ImageLayout.None;
            keyPad0.FlatAppearance.BorderSize = 0;
            keyPad0.FlatStyle = FlatStyle.Flat;
            keyPad0.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad0.ForeColor = SystemColors.ControlLightLight;
            keyPad0.Location = new Point(49, 276);
            keyPad0.Name = "keyPad0";
            keyPad0.Size = new Size(81, 73);
            keyPad0.TabIndex = 19;
            keyPad0.TabStop = false;
            keyPad0.Text = "0";
            keyPad0.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad0.UseVisualStyleBackColor = false;
            keyPad0.Click += keypad_click;
            // 
            // keyPad9
            // 
            keyPad9.BackColor = Color.Gray;
            keyPad9.BackgroundImageLayout = ImageLayout.None;
            keyPad9.FlatAppearance.BorderSize = 0;
            keyPad9.FlatStyle = FlatStyle.Flat;
            keyPad9.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad9.ForeColor = SystemColors.ControlLightLight;
            keyPad9.Location = new Point(223, 197);
            keyPad9.Name = "keyPad9";
            keyPad9.Size = new Size(81, 73);
            keyPad9.TabIndex = 18;
            keyPad9.TabStop = false;
            keyPad9.Text = "9";
            keyPad9.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad9.UseVisualStyleBackColor = false;
            keyPad9.Click += keypad_click;
            // 
            // keyPad8
            // 
            keyPad8.BackColor = Color.Gray;
            keyPad8.BackgroundImageLayout = ImageLayout.None;
            keyPad8.FlatAppearance.BorderSize = 0;
            keyPad8.FlatStyle = FlatStyle.Flat;
            keyPad8.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad8.ForeColor = SystemColors.ControlLightLight;
            keyPad8.Location = new Point(136, 197);
            keyPad8.Name = "keyPad8";
            keyPad8.Size = new Size(81, 73);
            keyPad8.TabIndex = 17;
            keyPad8.TabStop = false;
            keyPad8.Text = "8";
            keyPad8.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad8.UseVisualStyleBackColor = false;
            keyPad8.Click += keypad_click;
            // 
            // keyPad7
            // 
            keyPad7.BackColor = Color.Gray;
            keyPad7.BackgroundImageLayout = ImageLayout.None;
            keyPad7.FlatAppearance.BorderSize = 0;
            keyPad7.FlatStyle = FlatStyle.Flat;
            keyPad7.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad7.ForeColor = SystemColors.ControlLightLight;
            keyPad7.Location = new Point(49, 197);
            keyPad7.Name = "keyPad7";
            keyPad7.Size = new Size(81, 73);
            keyPad7.TabIndex = 16;
            keyPad7.TabStop = false;
            keyPad7.Text = "7";
            keyPad7.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad7.UseVisualStyleBackColor = false;
            keyPad7.Click += keypad_click;
            // 
            // keyPad6
            // 
            keyPad6.BackColor = Color.Gray;
            keyPad6.BackgroundImageLayout = ImageLayout.None;
            keyPad6.FlatAppearance.BorderSize = 0;
            keyPad6.FlatStyle = FlatStyle.Flat;
            keyPad6.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad6.ForeColor = SystemColors.ControlLightLight;
            keyPad6.Location = new Point(223, 118);
            keyPad6.Name = "keyPad6";
            keyPad6.Size = new Size(81, 73);
            keyPad6.TabIndex = 15;
            keyPad6.TabStop = false;
            keyPad6.Text = "6";
            keyPad6.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad6.UseVisualStyleBackColor = false;
            keyPad6.Click += keypad_click;
            // 
            // keyPad5
            // 
            keyPad5.BackColor = Color.Gray;
            keyPad5.BackgroundImageLayout = ImageLayout.None;
            keyPad5.FlatAppearance.BorderSize = 0;
            keyPad5.FlatStyle = FlatStyle.Flat;
            keyPad5.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad5.ForeColor = SystemColors.ControlLightLight;
            keyPad5.Location = new Point(136, 118);
            keyPad5.Name = "keyPad5";
            keyPad5.Size = new Size(81, 73);
            keyPad5.TabIndex = 14;
            keyPad5.TabStop = false;
            keyPad5.Text = "5";
            keyPad5.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad5.UseVisualStyleBackColor = false;
            keyPad5.Click += keypad_click;
            // 
            // keyPad4
            // 
            keyPad4.BackColor = Color.Gray;
            keyPad4.BackgroundImageLayout = ImageLayout.None;
            keyPad4.FlatAppearance.BorderSize = 0;
            keyPad4.FlatStyle = FlatStyle.Flat;
            keyPad4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad4.ForeColor = SystemColors.ControlLightLight;
            keyPad4.Location = new Point(49, 118);
            keyPad4.Name = "keyPad4";
            keyPad4.Size = new Size(81, 73);
            keyPad4.TabIndex = 13;
            keyPad4.TabStop = false;
            keyPad4.Text = "4";
            keyPad4.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad4.UseVisualStyleBackColor = false;
            keyPad4.Click += keypad_click;
            // 
            // keyPad3
            // 
            keyPad3.BackColor = Color.Gray;
            keyPad3.BackgroundImageLayout = ImageLayout.None;
            keyPad3.FlatAppearance.BorderSize = 0;
            keyPad3.FlatStyle = FlatStyle.Flat;
            keyPad3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad3.ForeColor = SystemColors.ControlLightLight;
            keyPad3.Location = new Point(223, 39);
            keyPad3.Name = "keyPad3";
            keyPad3.Size = new Size(81, 73);
            keyPad3.TabIndex = 12;
            keyPad3.TabStop = false;
            keyPad3.Text = "3";
            keyPad3.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad3.UseVisualStyleBackColor = false;
            keyPad3.Click += keypad_click;
            // 
            // keyPad2
            // 
            keyPad2.BackColor = Color.Gray;
            keyPad2.BackgroundImageLayout = ImageLayout.None;
            keyPad2.FlatAppearance.BorderSize = 0;
            keyPad2.FlatStyle = FlatStyle.Flat;
            keyPad2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad2.ForeColor = SystemColors.ControlLightLight;
            keyPad2.Location = new Point(136, 39);
            keyPad2.Name = "keyPad2";
            keyPad2.Size = new Size(81, 73);
            keyPad2.TabIndex = 11;
            keyPad2.TabStop = false;
            keyPad2.Text = "2";
            keyPad2.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad2.UseVisualStyleBackColor = false;
            keyPad2.Click += keypad_click;
            // 
            // keyPad1
            // 
            keyPad1.BackColor = Color.Gray;
            keyPad1.BackgroundImageLayout = ImageLayout.None;
            keyPad1.FlatAppearance.BorderSize = 0;
            keyPad1.FlatStyle = FlatStyle.Flat;
            keyPad1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            keyPad1.ForeColor = SystemColors.ControlLightLight;
            keyPad1.Location = new Point(49, 39);
            keyPad1.Name = "keyPad1";
            keyPad1.Size = new Size(81, 73);
            keyPad1.TabIndex = 10;
            keyPad1.TabStop = false;
            keyPad1.Text = "1";
            keyPad1.TextImageRelation = TextImageRelation.TextBeforeImage;
            keyPad1.UseVisualStyleBackColor = false;
            keyPad1.Click += keypad_click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1257, 806);
            Controls.Add(panel4);
            Controls.Add(adminButton);
            Controls.Add(errorLabel);
            Controls.Add(productIDbtn);
            Controls.Add(productIDtxt);
            Controls.Add(leftPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            transactionPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            panel4.ResumeLayout(false);
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
        private Button adminButton;
        private Panel panel4;
        private Button keypadBck;
        private Button keyPad0;
        private Button keyPad9;
        private Button keyPad8;
        private Button keyPad7;
        private Button keyPad6;
        private Button keyPad5;
        private Button keyPad4;
        private Button keyPad3;
        private Button keyPad2;
        private Button keyPad1;
    }
}