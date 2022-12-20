using System.Runtime.CompilerServices;

namespace Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string[] data_k_adi  = new string[100];
        public static string[] data_sifre = new string[100];
        public static int sayac = 0;

        public static Form1 girisMenu = new Form1();
        public static Form2 personelKayit = new Form2();
        public static Form3 personelGiris = new Form3();
        public static Form4 anaMenu = new Form4();
        public static Form5 tasKagitMakasSecim = new Form5();
        public static Form6 tasKagitMakasTekOyunculu = new Form6();
        public static Form7 tasKagitMakasCiftOyunculu = new Form7();
        public static Form8 SayiTahminEtme = new Form8();
        public static void kapat()
        {
            girisMenu.Close();
            personelKayit.Close();
            personelGiris.Close();
            anaMenu.Close();
            Application.Exit();
        }
        private void kayitButton_Click(object sender, EventArgs e)
        {
            personelKayit.Show();
            this.Hide();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            personelGiris.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}