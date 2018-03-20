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
    public partial class StokListesi : Form
    {
        // item1 is e.RowIndex, item2 is stokIncKey
        private Tuple<int, DataGridViewCellCollection> selectedItem;
        private int listType;

        public StokListesi(int listType)
        {
            this.listType = listType;
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
                string query = "SELECT " +
                                  "STOK_INCKEY, STOK_KOD STOK_KODU, STOK_ADI, MIKTAR, MIKTAR_BIRIM, BIRIM_FIYAT, FORMAT(GELIS_TARIH, 'dd.MM.yyyy') GELIS_TARIHI, AMBALAJ_BILGI, MALZ_SERISI MALZEME_SERISI, " +
                                  "MALZ_CINSI MALZEME_CINSI, MALZ_OLCU MALZEME_OLCU, ETIKET_BILGI, ACIKLAMA, KAYIT_TARIH FROM STOK ORDER BY STOK_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(stokListDTable);

                typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   stokListGridView,
                   new object[] { true });

                Styler.gridViewCommonStyle(stokListGridView);

                stokListGridView.DataSource = stokListDTable;
                stokListGridView.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        public Tuple<int, DataGridViewCellCollection> getSelectedItem() { return selectedItem; }        

        private void btnStokListesiGetir_Click(object sender, EventArgs e)
        {
            listStok();
        }

        private void stokListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listType == 1)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(Convert.ToInt32(stokListGridView["STOK_INCKEY", e.RowIndex].Value.ToString()), stokListGridView.Rows[e.RowIndex].Cells);
                    this.Close();
                }
            }
        }

        private void searchForStokKodu(object sender, EventArgs e)
        {
            if (txtAramaStokKodu.Text.Count() > 1)            
                Search.gridviewArama(txtAramaStokKodu.Text, stokListGridView, "STOK_KODU");            
            else
                Search.gridviewArama("", stokListGridView);
        }

        private void searchForStokAdi(object sender, EventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaStokAdi.Text, stokListGridView, "STOK_ADI");
            else
                Search.gridviewArama("", stokListGridView);

        }

        private void searchForGelisTarih(object sender, EventArgs e)
        {
            Search.gridviewArama(dtAramaGelisTarih.Value.ToString("dd.MM.yyyy"), stokListGridView, "GELIS_TARIHI");
        }

        private void txtAramaMalzemeSerisi_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaMalzemeSerisi.Text.Count() > 1)
                Search.gridviewArama(txtAramaMalzemeSerisi.Text, stokListGridView, "MALZ_SERISI");
            else
                Search.gridviewArama("", stokListGridView);
        }

        private void txtAramaMalzemeCinsi_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaMalzemeCinsi.Text.Count() > 1)
                Search.gridviewArama(txtAramaMalzemeCinsi.Text, stokListGridView, "MALZ_CINSI");
            else
                Search.gridviewArama("", stokListGridView);
        }

        private void txtMalzemeEtiketBilgi_TextChanged(object sender, EventArgs e)
        {
            Search.gridviewArama(dtAramaGelisTarih.Value.ToString("dd.MM.yyyy"), stokListGridView, "GELIS_TARIHI");
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
