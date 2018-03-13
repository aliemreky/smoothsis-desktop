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

        private void StokListele_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(stokListGridView);
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
                                  "STOK_DEPO.STOK_DEPO_INCKEY, STOK.STOK_KOD STOK_KODU, STOK.STOK_ADI, DEPO.DEPO_ADI, STOK_DEPO.MIKTAR, STOK.MIKTAR_BIRIM, " +
                                  "STOK.BIRIM_FIYAT, FORMAT(STOK.GELIS_TARIH, 'dd.MM.yyyy') GELIS_TARIHI, STOK.AMBALAJ_BILGI, " +
                                  "STOK.MALZ_SERISI MALZEME_SERISI, STOK.MALZ_CINSI MALZEME_CINSI, " +
                                  "STOK.MALZ_OLCU MALZEME_OLCU, STOK.ETIKET_BILGI, STOK.ACIKLAMA, K1.ADSOYAD KAYIT_YAPAN_KULLANICI, STOK.KAYIT_TARIH KAYIT_TARIHI, K2.ADSOYAD DUZELTME_YAPAN_KULLANICI, "+
                                  "STOK.DUZELTME_TARIH DUZELTME_TARIHI FROM STOK_DEPO " +
                                  "INNER JOIN STOK ON STOK_DEPO.STOK_INCKEY = STOK.STOK_INCKEY " +
                                  "INNER JOIN DEPO ON STOK_DEPO.DEPO_INCKEY = DEPO.DEPO_INCKEY " +
                                  "INNER JOIN KULLANICI K1 ON STOK.KAYIT_YAPAN_KUL = K1.KUL_INCKEY " +
                                  "LEFT JOIN KULLANICI K2 ON STOK.DUZELTME_YAPAN_KUL = K2.KUL_INCKEY " +
                                  "ORDER BY STOK_DEPO.STOK_DEPO_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(stokListDTable);
                stokListGridView.DataSource = stokListDTable;
                stokListGridView.Columns[0].Visible = false;
                stokListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
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
                Search.gridviewArama(txtAramaStokKodu.Text, "STOK_KODU", stokListGridView);
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
                Search.gridviewArama(txtAramaStokAdi.Text, "STOK_ADI", stokListGridView);
            }
            else
            {
                (stokListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                stokListGridView.Refresh();
            }
        }

        private void searchForGelisTarih(object sender, EventArgs e)
        {
            Search.gridviewArama(dtAramaGelisTarih.Value.ToString("dd.MM.yyyy"), "GELIS_TARIHI", stokListGridView);
        }

        private void stokListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if ((e.Button == MouseButtons.Right) && (stokListGridView.SelectedRows.Count == 1))
                {
                    stokListGridView.ClearSelection();
                    this.stokListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        private void allStokList_Click(object sender, EventArgs e)
        {
            StokListele_Load(sender, e);
        }

        private void stokTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StokTransfer stokTransfer = new StokTransfer(this);
            stokTransfer.ShowDialog();
        }
        
        private void selectRowWithRightMenu(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, stokListGridView.Rows[e.RowIndex].Cells);
            }
        }
    }
}
