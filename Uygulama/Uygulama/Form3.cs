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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        bool dy = false;

        private void geriButton_Click(object sender, EventArgs e)
        {
            Form1.personelGiris.Hide();
            Form1.girisMenu.Show();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            string girisyap_kullanici_adi = giris_kullanici_adi.Text;
            string girisyap_sifre = giris_sifre.Text;

            for (int i = 0; Form1.sayac >= i; i++)
            {
                if (Form1.data_k_adi[i] == girisyap_kullanici_adi && Form1.data_sifre[i] == girisyap_sifre)
                {
                    Form1.personelGiris.Hide();
                    Form1.anaMenu.Show();
                    dy = true;
                }
            }
            if (dy == false)
            {
                MessageBox.Show("Hatalı Kullanıcı Adı / Şifre");
            }
            else
            {
                dy = false;
            }
        }

        private void giris_sifre_TextChanged(object sender, EventArgs e)
        {
            giris_sifre.PasswordChar = '*';
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.kapat();
        }
    }
}
