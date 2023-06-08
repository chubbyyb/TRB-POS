namespace POS
{
    partial class DiscountEuro
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            WindowLabel = new Label();
            discountEurTxt = new TextBox();
            button2 = new Button();
            continueBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(WindowLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 57);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.euros;
            pictureBox1.Location = new Point(200, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // WindowLabel
            // 
            WindowLabel.AutoSize = true;
            WindowLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WindowLabel.ForeColor = Color.White;
            WindowLabel.Location = new Point(238, 21);
            WindowLabel.Name = "WindowLabel";
            WindowLabel.Size = new Size(58, 14);
            WindowLabel.TabIndex = 1;
            WindowLabel.Text = "Discount";
            // 
            // discountEurTxt
            // 
            discountEurTxt.Location = new Point(209, 136);
            discountEurTxt.Name = "discountEurTxt";
            discountEurTxt.Size = new Size(100, 23);
            discountEurTxt.TabIndex = 7;
            discountEurTxt.TextChanged += discountEurTxt_TextChanged;
            discountEurTxt.KeyDown += discountEurTxt_KeyDown;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.DialogResult = DialogResult.Cancel;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(346, 204);
            button2.Name = "button2";
            button2.Size = new Size(75, 29);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.LightGreen;
            continueBtn.DialogResult = DialogResult.OK;
            continueBtn.FlatAppearance.BorderSize = 0;
            continueBtn.FlatStyle = FlatStyle.Flat;
            continueBtn.Location = new Point(427, 204);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(75, 29);
            continueBtn.TabIndex = 8;
            continueBtn.Text = "Continue";
            continueBtn.UseVisualStyleBackColor = false;
            // 
            // DiscountEuro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(537, 255);
            Controls.Add(button2);
            Controls.Add(continueBtn);
            Controls.Add(discountEurTxt);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiscountEuro";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiscountEuro";
            Load += DiscountEuro_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label WindowLabel;
        private PictureBox pictureBox1;
        private TextBox discountEurTxt;
        private Button button2;
        private Button continueBtn;
    }
}