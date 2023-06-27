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
            panel3 = new Panel();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            minButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            txtUser.Enter += current_box;
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
            txtPass.Enter += current_box;
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
            incorrectLogin.ForeColor = Color.FromArgb(24, 30, 54);
            incorrectLogin.Location = new Point(45, 233);
            incorrectLogin.Name = "incorrectLogin";
            incorrectLogin.Size = new Size(175, 15);
            incorrectLogin.TabIndex = 6;
            incorrectLogin.Text = "Incorrect Login, please try again";
            incorrectLogin.Click += incorrectLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(24, 30, 54);
            panel2.Controls.Add(incorrectLogin);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtPass);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(loginBtn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 477);
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
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(951, 577);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
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
            panel4.Location = new Point(354, 139);
            panel4.Name = "panel4";
            panel4.Size = new Size(352, 394);
            panel4.TabIndex = 19;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
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
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
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
        private Panel panel3;
        private Button keyPad9;
        private Button keyPad8;
        private Button keyPad7;
        private Button keyPad6;
        private Button keyPad5;
        private Button keyPad4;
        private Button keyPad3;
        private Button keyPad2;
        private Button keyPad1;
        private Panel panel4;
        private Button keyPad0;
        private Button keypadBck;
    }
}