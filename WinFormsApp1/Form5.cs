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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string[] cars = { "BMW", "Volvo", "Toyota", "Kia", "Honda", "Fiat", "Tesla", "Hyundai", "VW", "Renault", "Peugeot", "Suzuki", "Tofaş" };

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            string lastCar = cars[cars.Length - 1];
            MessageBox.Show(lastCar, "Last Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rndIndex = rnd.Next(0, cars.Length);
            string randomCar = cars[rndIndex];
            MessageBox.Show(randomCar, "Random Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        int index = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (index < cars.Length)
            {
                listCars.Items.Add(cars[index]); // Listbox componentine özgü
                                                 // Items bir collection
                index++;
            }
            else
            {
                MessageBox.Show("All cars added to the list!");
            }
        }
    }
}
