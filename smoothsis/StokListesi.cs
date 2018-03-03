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

namespace smoothsis
{
    public partial class StokListesi : Form
    {
        // item1 is e.RowIndex, item2 is stokIncKey
        private  Tuple<int, DataGridViewCellCollection> selectedItem;

        public StokListesi()
        {
            InitializeComponent();
        }

        private void StokListeleDuzenle_Load(object sender, EventArgs e)
        {
            Program.controllerClass.gridViewCommonStyle(stokListGridView);
            listStok();
        }

        public DataGridView getDataGrid()
        {
            return stokListGridView;
        }

        private void listStok()
        {
            try
            {
                DataTable stokListDTable = new DataTable();
                string query = "SELECT "+
                                  "STOK_INCKEY, STOK_KOD STOK_KODU, STOK_ADI, MIKTAR, MIKTAR_BIRIM, BIRIM_FIYAT, FORMAT(GELIS_TARIH, 'dd.MM.yyyy') GELIS_TARIHI, AMBALAJ_BILGI, MALZ_SERISI MALZEME_SERISI, " +
                                  "MALZ_CINSI MALZEME_CINSI, MALZ_OLCU MALZEME_OLCU, ETIKET_BILGI, ACIKLAMA, K1.ADSOYAD KAYIT_YAPAN_KULLANICI, KAYIT_TARIH KAYIT_TARIHI, K2.ADSOYAD DUZELTME_YAPAN_KULLANICI, "+
                                  "DUZELTME_TARIH DUZELTME_TARIHI FROM STOK INNER JOIN KULLANICI K1 ON STOK.KAYIT_YAPAN_KUL = K1.KUL_INCKEY " +
                                  "LEFT JOIN KULLANICI K2 ON STOK.DUZELTME_YAPAN_KUL = K2.KUL_INCKEY" +
                                  " ORDER BY STOK_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(stokListDTable);
                stokListGridView.DataSource = stokListDTable;
                stokListGridView.Columns[0].Visible = false;
                stokListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
            }

        }

        public Tuple<int, DataGridViewCellCollection> getSelectedItem()
        {
            return selectedItem;
        }

        private void showStok(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, stokListGridView.Rows[e.RowIndex].Cells);
                StokDuzenle stokDuzenle = new StokDuzenle(this);
                stokDuzenle.ShowDialog();
            }
        }

        private void searchForStokKodu(object sender, EventArgs e)
        {
            if (txtAramaStokKodu.Text.Count() > 0)
            {
                Program.controllerClass.gridviewArama(txtAramaStokKodu.Text, "STOK_KODU", stokListGridView);
            }
            else
            {
                (stokListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                stokListGridView.Refresh();
            }
        }

        private void searchForStokAdi(object sender, EventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() > 0)
            {
                Program.controllerClass.gridviewArama(txtAramaStokAdi.Text, "STOK_ADI", stokListGridView);
            }
            else
            {
                (stokListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                stokListGridView.Refresh();
            }
        }

        private void searchForGelisTarih(object sender, EventArgs e)
        {
            Program.controllerClass.gridviewArama(dtAramaGelisTarih.Value.ToString("dd.MM.yyyy"), "GELIS_TARIHI", stokListGridView);
        }
    }
}
