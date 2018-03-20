using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using smoothsis.Services;
using System.Reflection;

namespace smoothsis
{
    public partial class SiparisListesi : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;
        

        public SiparisListesi()
        {
            InitializeComponent();
        }

        private void SiparisListesi_Load(object sender, EventArgs e)
        {
            DataTable siparisListe = new DataTable();
            sqlCmd = new SqlCommand("dbo.Siparis_Listesi", Program.connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter = new SqlDataAdapter(sqlCmd);
            sqlDataAdapter.Fill(siparisListe);

            typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   siparisListGridView,
                   new object[] { true });

            siparisListGridView.DataSource = siparisListe;

            Styler.gridViewCommonStyle(siparisListGridView);

            siparisListGridView.Columns[0].Visible = false;

        }

        private void txtAramaSiparisKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaSiparisKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaSiparisKodu.Text, siparisListGridView, "SIPARIS_KOD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void cmbAramaSiparisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbAramaSiparisTipi.SelectedItem.ToString()))
                Search.gridviewArama(cmbAramaSiparisTipi.SelectedItem.ToString(), siparisListGridView, "SIPARIS_TIPI");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaProjeKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaProjeKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaProjeKodu.Text, siparisListGridView, "PROJE_KOD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaProjeAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaProjeAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaProjeAdi.Text, siparisListGridView, "PROJE_ADI");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaCariKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaCariKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaCariKodu.Text, siparisListGridView, "CARI_KOD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaCariAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaCariAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaCariAdi.Text, siparisListGridView, "ADSOYAD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void cmbAramaUretimDetay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbAramaUretimDetay.SelectedItem.ToString()))
                Search.gridviewArama(cmbAramaUretimDetay.SelectedItem.ToString(), siparisListGridView, "URETIM_DETAY");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void cmbAramaSiparisDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbAramaSiparisDurumu.SelectedItem.ToString()))
                Search.gridviewArama(cmbAramaSiparisDurumu.SelectedItem.ToString(), siparisListGridView, "SIP_DURUM");
            else
                Search.gridviewArama("", siparisListGridView);
        }
    }
}
