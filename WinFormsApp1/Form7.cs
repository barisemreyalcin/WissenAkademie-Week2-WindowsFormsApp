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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        // List<T> içerisine verilen <T> tipe bürünerek, verilen tipteki elemanları tutan bir koleksiyon oluşturmamızı sağlar.
        // Dizilerdeki gibi boyutunu arttırma işlemine gerek yok
        List<string> list = new List<string>();

        private void btnAddElement_Click(object sender, EventArgs e)
        {
            // Kapasitenin üstünde eleman eklersem bir önceki elemanın 2 katı kadar kapasite oluşturur.
            // İşlemlerim bittikten sonra gereksiz kapasiteyi ortadan Trim.Excess() ile kaldır
            List<int> numbers = new List<int>();
            numbers.Add(1); // int olduğu için int tipinde eklemelisin
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            MessageBox.Show($"Elements added to the list. \n" +
                $"Number of elements: {numbers.Count}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> cities = new List<string>();
            cities.Add("Hatay");
            cities.Add("Ankara");
            cities.Add("İzmir");
            cities.Add("İstanbul");
            cities.Sort();

            foreach (string city in cities)
            {
                MessageBox.Show(city);
            }
        }

        private void btnElementExist_Click(object sender, EventArgs e)
        {
            // Collection tanımlama yolları
            // List<string> cities = new () {"Hatay", "Ankara", "İzmir"};
            // List<string> cities = new List<string>() {"Hatay", "Ankara", "İzmir"};


            List<string> cities = new List<string>();
            cities.Add("Hatay");
            cities.Add("Ankara");
            cities.Add("İzmir");
            cities.Add("İstanbul");

            if(cities.Contains("Hatay"))
            {
                MessageBox.Show("Hatay exists");
            } else
            {
                MessageBox.Show("Hatay does not exits");
            }
        }
    }
}
