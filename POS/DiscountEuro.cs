using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class DiscountEuro : Form
    {
        public string selectedText { get; set; }

        public DiscountEuro()
        {
            InitializeComponent();
            discountEurTxt.Focus();
        }

        private void DiscountEuro_Load(object sender, EventArgs e)
        {

        }

        private void discountEurTxt_TextChanged(object sender, EventArgs e)
        {
            selectedText = discountEurTxt.Text;
        }

        private void discountEurTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;

                continueBtn.Focus();
            }
        }
    }
}
