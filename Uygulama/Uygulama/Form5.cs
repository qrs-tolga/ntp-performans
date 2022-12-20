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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tekOyunculu_Click(object sender, EventArgs e)
        {
            Form1.tasKagitMakasSecim.Hide();
            Form1.tasKagitMakasTekOyunculu.Show();
        }

        private void ciftOyunculu_Click(object sender, EventArgs e)
        {
            Form1.tasKagitMakasSecim.Hide();
            Form1.tasKagitMakasCiftOyunculu.Show();
        }
    }
}
