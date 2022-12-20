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
    public partial class Form6 : Form
    {
        static Random rnd = new Random();
        public Form6()
        {
            InitializeComponent();
        }

        public void oyun(int oyuncuSecim)
        {
            int bilgisayarSecim = rnd.Next(0,3);

            if (bilgisayarSecim == oyuncuSecim)
            {
                label2.Text =  "Berabere";
            }
            else if (oyuncuSecim == 0)
            {
                if(bilgisayarSecim == 1)
                {
                    label2.Text = "Kazanan Bilgisayar";
                }
                else if (bilgisayarSecim == 2)
                {
                    label2.Text = "Kazanan Oyuncu";
                }
            }
            else if (oyuncuSecim == 1)
            {
                if (bilgisayarSecim == 2)
                {
                    label2.Text = "Kazanan Bilgisayar";
                }
                else if (bilgisayarSecim == 0)
                {
                    label2.Text = "Kazanan Oyuncu";
                }
            }
            else if (oyuncuSecim == 2)
            {
                if (bilgisayarSecim == 0)
                {
                    label2.Text = "Kazanan Bilgisayar";
                }
                else if (bilgisayarSecim == 1)
                {
                    label2.Text = "Kazanan Oyuncu";
                }
            }
        }
        private void tasSecim_Click(object sender, EventArgs e)
        {
            oyun(0);
        }

        private void kagitSecim_Click(object sender, EventArgs e)
        {
            oyun(1);
        }

        private void makasSecim_Click(object sender, EventArgs e)
        {
            oyun(2);
        }

        private void geriButton_Click(object sender, EventArgs e)
        {
            Form1.tasKagitMakasTekOyunculu.Hide();
            Form1.anaMenu.Show();
        }
    }
}
