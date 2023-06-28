namespace POS
{
    partial class adminForm
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
            stockData = new DataGridView();
            stockBtn = new Button();
            purchaseBtn = new Button();
            purchaseData = new DataGridView();
            exitBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            adminLbl = new Label();
            moneyTodayLbl = new Label();
            profitBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)stockData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purchaseData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // stockData
            // 
            stockData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stockData.Location = new Point(12, 189);
            stockData.Name = "stockData";
            stockData.RowTemplate.Height = 25;
            stockData.Size = new Size(590, 337);
            stockData.TabIndex = 0;
            // 
            // stockBtn
            // 
            stockBtn.BackColor = Color.SandyBrown;
            stockBtn.FlatAppearance.BorderSize = 0;
            stockBtn.FlatStyle = FlatStyle.Flat;
            stockBtn.Location = new Point(213, 120);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(152, 46);
            stockBtn.TabIndex = 1;
            stockBtn.Text = "Load Stock Data";
            stockBtn.UseVisualStyleBackColor = false;
            stockBtn.Click += button1_Click;
            // 
            // purchaseBtn
            // 
            purchaseBtn.BackColor = Color.YellowGreen;
            purchaseBtn.FlatAppearance.BorderSize = 0;
            purchaseBtn.FlatStyle = FlatStyle.Flat;
            purchaseBtn.Location = new Point(876, 120);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(152, 46);
            purchaseBtn.TabIndex = 3;
            purchaseBtn.Text = "Load Purchase Data";
            purchaseBtn.UseVisualStyleBackColor = false;
            purchaseBtn.Click += button2_Click;
            // 
            // purchaseData
            // 
            purchaseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purchaseData.Location = new Point(655, 189);
            purchaseData.Name = "purchaseData";
            purchaseData.RowTemplate.Height = 25;
            purchaseData.Size = new Size(590, 337);
            purchaseData.TabIndex = 2;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(12, 715);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(174, 66);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "<-------";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.boxes;
            pictureBox1.Location = new Point(170, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.euros;
            pictureBox2.Location = new Point(833, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(adminLbl);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1257, 70);
            panel1.TabIndex = 7;
            // 
            // adminLbl
            // 
            adminLbl.AutoSize = true;
            adminLbl.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            adminLbl.Location = new Point(558, 21);
            adminLbl.Name = "adminLbl";
            adminLbl.Size = new Size(131, 30);
            adminLbl.TabIndex = 0;
            adminLbl.Text = "Admin Panel";
            // 
            // moneyTodayLbl
            // 
            moneyTodayLbl.AutoSize = true;
            moneyTodayLbl.BackColor = Color.Transparent;
            moneyTodayLbl.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            moneyTodayLbl.ForeColor = SystemColors.Control;
            moneyTodayLbl.Location = new Point(24, 582);
            moneyTodayLbl.Name = "moneyTodayLbl";
            moneyTodayLbl.Size = new Size(121, 28);
            moneyTodayLbl.TabIndex = 8;
            moneyTodayLbl.Text = "Profit Today:";
            moneyTodayLbl.Click += moneyTodayLbl_Click;
            // 
            // profitBTN
            // 
            profitBTN.BackColor = Color.YellowGreen;
            profitBTN.FlatAppearance.BorderSize = 0;
            profitBTN.FlatStyle = FlatStyle.Flat;
            profitBTN.Location = new Point(24, 623);
            profitBTN.Name = "profitBTN";
            profitBTN.Size = new Size(75, 23);
            profitBTN.TabIndex = 9;
            profitBTN.Text = "Update";
            profitBTN.UseVisualStyleBackColor = false;
            profitBTN.Click += button1_Click_1;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1257, 806);
            Controls.Add(profitBTN);
            Controls.Add(moneyTodayLbl);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(exitBtn);
            Controls.Add(purchaseBtn);
            Controls.Add(purchaseData);
            Controls.Add(stockBtn);
            Controls.Add(stockData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminForm";
            ((System.ComponentModel.ISupportInitialize)stockData).EndInit();
            ((System.ComponentModel.ISupportInitialize)purchaseData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView stockData;
        private Button stockBtn;
        private Button purchaseBtn;
        private DataGridView purchaseData;
        private Button exitBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label adminLbl;
        private Label moneyTodayLbl;
        private Button profitBTN;
    }
}