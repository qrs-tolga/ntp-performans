using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        int sayac = 1;
        int oyuncu1, oyuncu2;
        public void oyun(int oyuncu1Secim, int oyuncu2Secim)
        {

            if (oyuncu2Secim == oyuncu1Secim)
            {
                label2.Text = "Berabere";
            }
            else if (oyuncu1Secim == 0)
            {
                if (oyuncu2Secim == 1)
                {
                    label2.Text = "Kazanan 2. Oyuncu";
                }
                else if (oyuncu2Secim == 2)
                {
                    label2.Text = "Kazanan 1. Oyuncu";
                }
            }
            else if (oyuncu1Secim == 1)
            {
                if (oyuncu2Secim == 2)
                {
                    label2.Text = "Kazanan 2. Oyuncu";
                }
                else if (oyuncu2Secim == 0)
                {
                    label2.Text = "Kazanan 1. Oyuncu";
                }
            }
            else if (oyuncu1Secim == 2)
            {
                if (oyuncu2Secim == 0)
                {
                    label2.Text = "Kazanan 2. Oyuncu";
                }
                else if (oyuncu2Secim == 1)
                {
                    label2.Text = "Kazanan 1. Oyuncu";
                }
            }
        }

        private void kagitSecim_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                oyuncu1 = 1;
                sayac = 2;
                label1.Text = "2. Oyuncu Seçim Yapınız";
            }
            else if (sayac == 2)
            {
                oyuncu2 = 1;
                sayac = 1;
                oyun(oyuncu1, oyuncu2);
                label1.Text = "1. Oyuncu Seçim Yapınız";
            }
        }

        private void makasSecim_Click(object sender, EventArgs e)
        {
            if (sayac == 1)
            {
                oyuncu1 = 2;
                sayac = 2;
                label1.Text = "2. Oyuncu Seçim Yapınız";
            }
            else if (sayac == 2)
            {
                oyuncu2 = 2;
                sayac = 1;
                oyun(oyuncu1, oyuncu2);
                label1.Text = "1. Oyuncu Seçim Yapınız";
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Form1.tasKagitMakasCiftOyunculu.Hide();
            Form1.anaMenu.Show();
        }

        private void tasSecim_Click(object sender, EventArgs e)
        {
            if(sayac == 1)
            {
                oyuncu1 = 0;
                sayac = 2;
                label1.Text = "2. Oyuncu Seçim Yapınız";
            }
            else if (sayac == 2)
            {
                oyuncu2 = 0;
                sayac = 1;
                oyun(oyuncu1, oyuncu2);
                label1.Text = "1. Oyuncu Seçim Yapınız";
            }
        }
    }
}
