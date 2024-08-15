using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            labelInput.Text = txtInput.Text.Trim();
        }

        private void txtInput_MouseEnter(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.OrangeRed;
            txtInput.ForeColor = Color.White;
        }

        private void txtInput_MouseLeave(object sender, EventArgs e)
        {
            txtInput.BackColor = Color.White;
            txtInput.ForeColor = Color.Black;

        }
    }
}
