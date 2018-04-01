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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelKullanici.Text = Program.kullanici.Item2;
            labelSirket.Text = Program.sirket;
            labelTarih.Text = DateTime.Now.ToString("dd.MM.yyyy, dddd");
        }

        private void veritabaniDeğişikliğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cariEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariOlustur cariKayit = new CariOlustur();
            cariKayit.ShowDialog();
        }

        private void cariListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariListesi cariListe = new CariListesi(0);
            cariListe.ShowDialog();
        }

        private void kullaniciEklePage(object sender, EventArgs e)
        {
            KullaniciOlustur kullaniciOlustur = new KullaniciOlustur();
            kullaniciOlustur.ShowDialog();
        }

        private void kullaniciListesiPage(object sender, EventArgs e)
        {
            KullaniciListeleDuzenle kullaniciListeleDuzenle = new KullaniciListeleDuzenle();
            kullaniciListeleDuzenle.ShowDialog();
        }

        private void grupPage(object sender, EventArgs e)
        {
            Grup grup = new Grup();
            grup.ShowDialog();
        }

        private void cariDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariDuzenle cariDuzen = new CariDuzenle();
            cariDuzen.ShowDialog();
        }

        private void siparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisPaneli siparisPaneli = new SiparisPaneli();
            siparisPaneli.ShowDialog();
        }

        private void stokOlusturPage(object sender, EventArgs e)
        {
            StokOlustur stokOlustur = new StokOlustur();
            stokOlustur.ShowDialog();
        }

        private void stokListeleDuzenlePage(object sender, EventArgs e)
        {
            StokListesi stokListeleDuzenle = new StokListesi(0);
            stokListeleDuzenle.ShowDialog();
        }

        private void showDepoOlusturPage(object sender, EventArgs e)
        {
            DepoOlustur depoOlustur = new DepoOlustur();
            depoOlustur.ShowDialog();
        }

        private void depoListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepoListesi depoListesi = new DepoListesi();
            depoListesi.ShowDialog();
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisListesi siparisListesi = new SiparisListesi();
            siparisListesi.ShowDialog();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kapatmak İstediğinize Emin misiniz ?", "UYARI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kapatmak İstediğinize Emin misiniz ?", "UYARI", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void stokTransferleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokTransferListesi stokTransferListesi = new StokTransferListesi();
            stokTransferListesi.ShowDialog();
        }

        private void makinaOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakineOlustur makineOlustur = new MakineOlustur();
            makineOlustur.ShowDialog();
        }

        private void makinaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakineListesi makineListesi = new MakineListesi();
            makineListesi.ShowDialog();
        }

        private void işlemOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemOlustur islemOlustur = new IslemOlustur();
            islemOlustur.ShowDialog();
        }

        private void işlemListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemListesi islemListesi = new IslemListesi();
            islemListesi.ShowDialog();
        }

        private void operatörOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorOlustur operatorOlustur = new OperatorOlustur();
            operatorOlustur.ShowDialog();
        }

        private void operatörListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorListesi operatorListesi = new OperatorListesi();
            operatorListesi.ShowDialog();
        }
    }
}
