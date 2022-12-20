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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int tahmin = 0;
        int puan = 0;
        int hak = 5;
        private void gonder_Click(object sender, EventArgs e)
        {
            int rastgele = rnd.Next(1, 11);
            bas:
            try
            {
                if(hak > 0)
                {
                    tahmin = Convert.ToInt32(tahmin_textbox.Text);
                    if (rastgele == tahmin)
                    {
                        MessageBox.Show("Doğru Tahmin !");
                        puan += 10;
                    }
                    else if (rastgele >= tahmin)
                    {
                        MessageBox.Show("Yanlış Tahmin !");
                        puan += 10 - (rastgele - tahmin);
                    }
                    else if (tahmin >= rastgele)
                    {
                        MessageBox.Show("Yanlış Tahmin !");
                        puan += 10 - (tahmin - rastgele);
                    }

                    else
                    {
                        gonder.Enabled = false;
                    }
                    hak--;
                    label3.Text = "Kalan Hak : " + hak;
                    label4.Text = "Puan : " + puan;
                }
                

            }
            catch
            {
                MessageBox.Show("Lütfen Sayı Giriniz !");
                goto bas;
            }
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            hak = 5;
            label3.Text = "Kalan Hak : " + hak;
            Form1.SayiTahminEtme.Hide();
            Form1.anaMenu.Show();
        }
    }
}
