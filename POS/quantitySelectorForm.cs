﻿using System;
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
    public partial class quantitySelectorForm : Form
    {

        public string selectedText { get; set; }

        public quantitySelectorForm()
        {
            InitializeComponent();
            quantitySelectorTxt.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quantitySelectorForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            selectedText = quantitySelectorTxt.Text;
        }

        private void quantitySelectorTxt_KeyDown(object sender, KeyEventArgs e)
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
