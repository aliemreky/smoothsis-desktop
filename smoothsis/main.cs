using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smoothsis
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {
            labelKullanici.Text = Program.kullanici.Item2;
            labelSirket.Text = Program.sirket;
            labelTarih.Text = DateTime.Now.ToString("dd.MM.yyyy, dddd");
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("KAPATMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
            
        }

        private void veritabaniDeğişikliğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cariEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariOlustur cariKayit = new cariOlustur();
            cariKayit.ShowDialog();
        }

        private void cariListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariListesi cariListe = new cariListesi(0);
            cariListe.ShowDialog();
        }

        private void kullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grup grup = new grup();
            grup.ShowDialog();
        }

        private void cariDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariDuzenle cariDuzen = new cariDuzenle();
            cariDuzen.ShowDialog();
        }

        private void siparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            siparisOlustur siparisEkle = new siparisOlustur();
            siparisEkle.ShowDialog();
        }
    }
}
