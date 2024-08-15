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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        int counter = 1;
        private void btnAddButton_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Width = 150;
            btn.Height = 40;

            Random rnd = new Random();
            int btnX = rnd.Next(0, this.ClientSize.Width - btn.Width); // this burada form'un instance'sine denk geliyor
            btn.Left = btnX;

            int btnY = rnd.Next(0, this.ClientSize.Height - btn.Height);
            btn.Top= btnY;

            btn.Text = counter.ToString();
            counter++;


            //btn.Click += new EventHandler(btn_Click);
            btn.Click += btn_Click;


            this.Controls.Add(btn);

        }

        private void btn_Click(object? sender, EventArgs e) // sender burada btn'i taşıyor, bir obje
        {
            Button btn = (Button)sender;
            MessageBox.Show(btn.Text);
        }
    }
}
