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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Form1.personelKayit.Hide();
            Form1.girisMenu.Show();
            
        }

        private void kayitButton_Click(object sender, EventArgs e)
        {
            string kayitol_kullanici_adi = kayit_kullanici_adi.Text;
            string kayitol_sifre = kayit_sifre.Text;

            if (kayitol_kullanici_adi == "" || kayitol_sifre == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Veya Şifre Kısmını Doldurunuz");
            }
            else
            {
                Form1.data_k_adi[Form1.sayac] = kayitol_kullanici_adi;
                Form1.data_sifre[Form1.sayac] = kayitol_sifre;
                Form1.sayac++;
                MessageBox.Show("Başarıyla Kayıt Oldunuz");
            }
        }

        private void kayit_sifre_TextChanged(object sender, EventArgs e)
        {
            kayit_sifre.PasswordChar = '*';
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.kapat();
        }
    }
}
