namespace POS
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // quantitySelectorTxt
            // 
            quantitySelectorTxt.Location = new Point(202, 110);
            quantitySelectorTxt.Name = "quantitySelectorTxt";
            quantitySelectorTxt.Size = new Size(100, 23);
            quantitySelectorTxt.TabIndex = 0;
            quantitySelectorTxt.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 113);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 1;
            label1.Text = "How many items?";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(305, 175);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(78, 175);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "No";
            button2.UseVisualStyleBackColor = true;
            // 
            // quantitySelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 255);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(quantitySelectorTxt);
            FormBorderStyle = FormBorderStyle.None;
            Name = "quantitySelectorForm";
            Text = "quantitySelectorForm";
            Load += quantitySelectorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox quantitySelectorTxt;
        private Label label1;
        private Button button1;
        private Button button2;
        private ColorDialog colorDialog1;
    }
}