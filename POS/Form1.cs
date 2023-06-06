using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace POS
{
    public partial class Form1 : Form
    {
        public static Timer fadeTimer = new Timer(100);
        public static int secondsCount = 0;
        public static int secondsSinceClick;


        public Form1()
        {
            InitializeComponent();
            fadeTimer.Elapsed += FadeTimer_Elapsed;
            fadeTimer.Enabled = true;
            fadeTimer.AutoReset = true;
            fadeTimer.Stop();
        }

        private void FadeTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            secondsCount++;
            Debug.WriteLine(secondsCount + " Seconds");
            if (secondsCount == 25)
            {
                incorrectLoginVisibility();
                secondsCount = 0;
                fadeTimer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "1" && txtPass.Text == "1")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                incorrectLogin.ForeColor = Color.Red;
                Debug.WriteLine("Color red"); ;
                fadeTimer.Start();
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.MaxLength = 8;
            txtPass.PasswordChar = '*';
        }

        private void incorrectLogin_Click(object sender, EventArgs e)
        {

        }

        private void incorrectLoginVisibility()
        {

            incorrectLogin.ForeColor = Color.FromArgb(46, 51, 73);

        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                button1_Click(sender, e);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}