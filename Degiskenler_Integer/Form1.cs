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
    }
}
