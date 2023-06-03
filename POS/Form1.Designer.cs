namespace POS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            loginBtn = new Button();
            incorrectLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Stout", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(334, 37);
            label1.Name = "label1";
            label1.Size = new Size(212, 16);
            label1.TabIndex = 0;
            label1.Text = "The Red Beeper";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(354, 256);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(192, 23);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += textBox1_TextChanged_1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(354, 309);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(192, 23);
            txtPass.TabIndex = 2;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 259);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 312);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(24, 30, 54);
            loginBtn.BackgroundImageLayout = ImageLayout.None;
            loginBtn.Location = new Point(354, 371);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(192, 36);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += button1_Click;
            // 
            // incorrectLogin
            // 
            incorrectLogin.AutoSize = true;
            incorrectLogin.ForeColor = Color.FromArgb(46, 51, 73);
            incorrectLogin.Location = new Point(362, 430);
            incorrectLogin.Name = "incorrectLogin";
            incorrectLogin.Size = new Size(175, 15);
            incorrectLogin.TabIndex = 6;
            incorrectLogin.Text = "Incorrect Login, please try again";
            incorrectLogin.Click += incorrectLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(incorrectLogin);
            Controls.Add(loginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Label label2;
        private Label label3;
        private Button loginBtn;
        private Label incorrectLogin;
    }
}