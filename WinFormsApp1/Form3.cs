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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtEntered.MaxLength = 200;
            labelRemainingChar.Text = txtEntered.MaxLength.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int characterCount = txtEntered.Text.Length;
            int remainingChar = txtEntered.MaxLength - characterCount;

            labelRemainingChar.Text = remainingChar.ToString();

            if (remainingChar <= 20) {
                labelRemainingChar.ForeColor = Color.Red;
                labelRemainingChar.Font = new Font(labelRemainingChar.Font, FontStyle.Bold);
            } else
            {
                labelRemainingChar.ForeColor = Color.Black;
                labelRemainingChar.Font = new Font(labelRemainingChar.Font, FontStyle.Regular);

            }
        }
    }
}
