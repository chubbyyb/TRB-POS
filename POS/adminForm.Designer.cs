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
            ((System.ComponentModel.ISupportInitialize)stockData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)purchaseData).BeginInit();
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
            stockBtn.Location = new Point(208, 120);
            stockBtn.Name = "stockBtn";
            stockBtn.Size = new Size(152, 46);
            stockBtn.TabIndex = 1;
            stockBtn.Text = "Load Stock Data";
            stockBtn.UseVisualStyleBackColor = true;
            stockBtn.Click += button1_Click;
            // 
            // purchaseBtn
            // 
            purchaseBtn.Location = new Point(909, 120);
            purchaseBtn.Name = "purchaseBtn";
            purchaseBtn.Size = new Size(152, 46);
            purchaseBtn.TabIndex = 3;
            purchaseBtn.Text = "Load Purchase Data";
            purchaseBtn.UseVisualStyleBackColor = true;
            purchaseBtn.Click += button2_Click;
            // 
            // purchaseData
            // 
            purchaseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            purchaseData.Location = new Point(671, 189);
            purchaseData.Name = "purchaseData";
            purchaseData.RowTemplate.Height = 25;
            purchaseData.Size = new Size(590, 337);
            purchaseData.TabIndex = 2;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(12, 767);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(174, 66);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "<-------";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // adminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1273, 845);
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
            ResumeLayout(false);
        }

        #endregion

        private DataGridView stockData;
        private Button stockBtn;
        private Button purchaseBtn;
        private DataGridView purchaseData;
        private Button exitBtn;
    }
}