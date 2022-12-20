using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        private void numbers_only(object sender, KeyPressEventArgs e)
        {
            char nums_only = e.KeyChar;
            
            if (!char.IsDigit(nums_only) && nums_only != 8)
            {
                e.Handled = true;
            }
        }
        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.kapat();
        }

        private void oyun_1_Click(object sender, EventArgs e)
        {
            Form1.anaMenu.Hide();
            Form1.tasKagitMakasSecim.Show();
        }

        private void oyun_2_Click(object sender, EventArgs e)
        {
            Form1.anaMenu.Hide();
            Form1.SayiTahminEtme.Show();
        }
    }
}
