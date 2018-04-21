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
            cariKayit.Show();
        }

        private void cariListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariListesi cariListe = new CariListesi(0);
            cariListe.Show();
        }

        private void kullaniciEklePage(object sender, EventArgs e)
        {
            KullaniciOlustur kullaniciOlustur = new KullaniciOlustur();
            kullaniciOlustur.Show();
        }

        private void kullaniciListesiPage(object sender, EventArgs e)
        {
            KullaniciListeleDuzenle kullaniciListeleDuzenle = new KullaniciListeleDuzenle();
            kullaniciListeleDuzenle.Show();
        }

        private void grupPage(object sender, EventArgs e)
        {
            Grup grup = new Grup();
            grup.Show();
        }

        private void cariDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CariDuzenle cariDuzen = new CariDuzenle();
            cariDuzen.Show();
        }

        private void siparişEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisPaneli siparisPaneli = new SiparisPaneli();
            siparisPaneli.Show();
        }

        private void stokOlusturPage(object sender, EventArgs e)
        {
            StokOlustur stokOlustur = new StokOlustur();
            stokOlustur.Show();
        }

        private void stokListeleDuzenlePage(object sender, EventArgs e)
        {
            StokListesi stokListeleDuzenle = new StokListesi(0);
            stokListeleDuzenle.Show();
        }

        private void showDepoOlusturPage(object sender, EventArgs e)
        {
            DepoOlustur depoOlustur = new DepoOlustur();
            depoOlustur.Show();
        }

        private void depoListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepoListesi depoListesi = new DepoListesi();
            depoListesi.Show();
        }

        private void siparişListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisListesi siparisListesi = new SiparisListesi();
            siparisListesi.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {            
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
            stokTransferListesi.Show();
        }

        private void operatörOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorOlustur operatorOlustur = new OperatorOlustur();
            operatorOlustur.Show();
        }

        private void operatörListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OperatorListesi operatorListesi = new OperatorListesi();
            operatorListesi.Show();
        }

        private void MakineOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakineOlustur makineOlustur = new MakineOlustur();
            makineOlustur.Show();
        }

        private void MakineListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakineListesi makineListesi = new MakineListesi();
            makineListesi.Show();
        }

        private void IslemOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemOlustur islemOlustur = new IslemOlustur();
            islemOlustur.Show();
        }

        private void IslemListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemListesi islemListesi = new IslemListesi();
            islemListesi.Show();
        }

        private void UretimListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UretimListesi urListesi = new UretimListesi();
            urListesi.Show();
        }

        private void MakineRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakineRaporu makRapor = new MakineRaporu();
            makRapor.Show();
        }

        private void OperatorCalismaRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
