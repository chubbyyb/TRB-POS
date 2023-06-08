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
            minButton = new Button();
            exitButton = new Button();
            label1 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            loginBtn = new Button();
            incorrectLogin = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(minButton);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 100);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // minButton
            // 
            minButton.BackColor = Color.LightSalmon;
            minButton.FlatAppearance.BorderSize = 0;
            minButton.FlatStyle = FlatStyle.Flat;
            minButton.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minButton.Location = new Point(889, 12);
            minButton.Name = "minButton";
            minButton.Size = new Size(22, 19);
            minButton.TabIndex = 9;
            minButton.UseVisualStyleBackColor = false;
            minButton.Click += minButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(917, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(22, 19);
            exitButton.TabIndex = 8;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(420, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 31);
            label1.TabIndex = 0;
            label1.Text = "TRB";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(55, 60);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = " username";
            txtUser.Size = new Size(192, 32);
            txtUser.TabIndex = 1;
            txtUser.TextChanged += textBox1_TextChanged_1;
            txtUser.KeyDown += txtUser_KeyDown;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(55, 98);
            txtPass.Name = "txtPass";
            txtPass.PlaceholderText = " password";
            txtPass.Size = new Size(192, 32);
            txtPass.TabIndex = 2;
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.KeyDown += txtPass_KeyDown;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(46, 51, 73);
            loginBtn.BackgroundImageLayout = ImageLayout.None;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.ForeColor = SystemColors.ControlLightLight;
            loginBtn.Location = new Point(45, 164);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(192, 36);
            loginBtn.TabIndex = 1;
            loginBtn.Text = "LOGIN";
            loginBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(loginBtn);
            panel2.Location = new Point(309, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 220);
            panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = Properties.Resources.id_card;
            pictureBox1.Location = new Point(17, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.IndianRed;
            pictureBox2.Image = Properties.Resources.key32;
            pictureBox2.Location = new Point(17, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panel2);
            Controls.Add(incorrectLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button loginBtn;
        private Label incorrectLogin;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button minButton;
        private Button exitButton;
    }
}