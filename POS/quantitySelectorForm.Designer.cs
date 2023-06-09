﻿namespace POS
{
    partial class quantitySelectorForm
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
            quantitySelectorTxt = new TextBox();
            WindowLabel = new Label();
            continueBtn = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // quantitySelectorTxt
            // 
            quantitySelectorTxt.Location = new Point(209, 136);
            quantitySelectorTxt.Name = "quantitySelectorTxt";
            quantitySelectorTxt.Size = new Size(100, 23);
            quantitySelectorTxt.TabIndex = 0;
            quantitySelectorTxt.TextChanged += textBox1_TextChanged;
            quantitySelectorTxt.KeyDown += quantitySelectorTxt_KeyDown;
            // 
            // WindowLabel
            // 
            WindowLabel.AutoSize = true;
            WindowLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            WindowLabel.ForeColor = Color.White;
            WindowLabel.Location = new Point(209, 21);
            WindowLabel.Name = "WindowLabel";
            WindowLabel.Size = new Size(107, 14);
            WindowLabel.TabIndex = 1;
            WindowLabel.Text = "Quantity Selector";
            WindowLabel.Click += label1_Click;
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
            continueBtn.TabIndex = 2;
            continueBtn.Text = "Continue";
            continueBtn.UseVisualStyleBackColor = false;
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
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
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
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.boxes;
            pictureBox1.Location = new Point(171, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // quantitySelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(537, 255);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(continueBtn);
            Controls.Add(quantitySelectorTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "quantitySelectorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "quantitySelectorForm";
            Load += quantitySelectorForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox quantitySelectorTxt;
        private Label WindowLabel;
        private Button continueBtn;
        private Button button2;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}