using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label1.Text = "Alan:" + alan + " Cevre:" + cevre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sinav1, sinav2, sinav3, ortalama;
            sinav1 = 100;
            sinav2 = 90;
            sinav3 = 90;
            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            label2.Text = "Ortalama " + ortalama;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //odev diktortgende alan ve cevre hesaplama
            //kısa 10 uzun 20
            int alan, cevre, kisakenar, uzunkenar;
            kisakenar = 30;
            uzunkenar = 20;
            alan = kisakenar * uzunkenar;
            cevre = (kisakenar + uzunkenar) * 2;
            label3.Text = "Alan = " + alan + " Cevre = " + cevre;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(textBox1.Text); //burada sayı 5 deseydik convert etmeyiz
            //burada tanımladıgımız değişken integer değişkeni almaya calıstıgımız string o zaman donusum yapılır
            label5.Text = sayi.ToString();

        }
    }
}
