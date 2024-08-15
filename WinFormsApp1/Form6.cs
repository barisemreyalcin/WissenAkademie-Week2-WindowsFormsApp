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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        string[] cities = { "Ankara", "İstanbul", "Bursa", "Adana", "Mersin", "Kastamonu", "Bolu" };

        private void btnAddCities_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string city in cities)
            {
                listBox1.Items.Add(city);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox2.Items.Clear();
                //foreach (string city in cities)
                //{
                //    listBox2.Items.Add(city);
                //}
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
