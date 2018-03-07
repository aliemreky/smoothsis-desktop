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

        private void StokListeleDuzenle_Load(object sender, EventArgs e)
        {
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

                Program.controllerClass.gridViewCommonStyle(stokListGridView);

                stokListGridView.DataSource = stokListDTable;
                stokListGridView.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
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
                Program.controllerClass.gridviewArama(txtAramaStokKodu.Text, stokListGridView, "STOK_KODU");
            else
                Program.controllerClass.gridviewArama("", stokListGridView);
        }

        private void searchForStokAdi(object sender, EventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() > 1)
                Program.controllerClass.gridviewArama(txtAramaStokAdi.Text, stokListGridView, "STOK_ADI");
            else
                Program.controllerClass.gridviewArama("", stokListGridView);

        }

        private void searchForGelisTarih(object sender, EventArgs e)
        {
            Program.controllerClass.gridviewArama(dtAramaGelisTarih.Value.ToString("dd.MM.yyyy"), stokListGridView, "GELIS_TARIHI");
        }

        private void txtAramaMalzemeSerisi_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaMalzemeSerisi.Text.Count() > 1)
                Program.controllerClass.gridviewArama(txtAramaMalzemeSerisi.Text, stokListGridView, "MALZ_SERISI");
            else
                Program.controllerClass.gridviewArama("", stokListGridView);
        }

        private void txtAramaMalzemeCinsi_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaMalzemeCinsi.Text.Count() > 1)
                Program.controllerClass.gridviewArama(txtAramaMalzemeCinsi.Text, stokListGridView, "MALZ_CINSI");
            else
                Program.controllerClass.gridviewArama("", stokListGridView);
        }

        private void txtMalzemeEtiketBilgi_TextChanged(object sender, EventArgs e)
        {
            if (txtMalzemeEtiketBilgi.Text.Count() > 1)
                Program.controllerClass.gridviewArama(txtMalzemeEtiketBilgi.Text, stokListGridView, "ETIKET_BILGI");
            else
                Program.controllerClass.gridviewArama("", stokListGridView);
        }
    }
}
