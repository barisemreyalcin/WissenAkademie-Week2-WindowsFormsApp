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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            textBox1.Enter += ChangeBackColor;
            textBox2.Enter += ChangeBackColor;
            textBox3.Enter += ChangeBackColor;
            textBox4.Enter += ChangeBackColor;

            textBox1.Leave += ChangeBackColorDefault;
            textBox2.Leave += ChangeBackColorDefault;
            textBox3.Leave += ChangeBackColorDefault;
            textBox4.Leave += ChangeBackColorDefault;
        }

        private void ChangeBackColorDefault(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.White;
        }

        private void ChangeBackColor(object? sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = Color.Aqua;

        }

      

        //private void textBox1_Enter(object sender, EventArgs e)
        //{
        //    textBox1.BackColor = Color.Aqua;
        //}

        //private void textBox1_Leave(object sender, EventArgs e)
        //{
        //    textBox1.BackColor = Color.White;
        //}
    }
}
