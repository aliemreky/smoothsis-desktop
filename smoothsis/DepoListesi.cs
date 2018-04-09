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
    public partial class DepoListesi : Form
    {
        // item1 is e.RowIndex, item2 is depoIncKey
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public DepoListesi()
        {
            InitializeComponent();
        }

        private void DepoListesi_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(depoListGridView);
            listDepo();
        }

        private void listDepo()
        {
            try
            {
                DataTable depoListDTable = new DataTable();

                string query = "SELECT DEPO_INCKEY, DEPO_ADI, DEPO_LOKASYON, K1.ADSOYAD KAYIT_YAPAN_KULLANICI, KAYIT_TARIH KAYIT_TARIHI," +
                    " K2.ADSOYAD DUZELTME_YAPAN_KULLANICI, DUZELTME_TARIH DUZELTME_TARIHI " +
                    "FROM DEPO INNER JOIN KULLANICI K1 ON DEPO.KAYIT_YAPAN_KUL = K1.KUL_INCKEY " +
                    "LEFT JOIN KULLANICI K2 ON DEPO.DUZELTME_YAPAN_KUL = K2.KUL_INCKEY ORDER BY DEPO_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(depoListDTable);
                depoListGridView.DataSource = depoListDTable;
                depoListGridView.Columns[0].Visible = false;
                depoListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        public DataGridView getDataGrid()
        {
            return depoListGridView;
        }

        private void showDepo(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, depoListGridView.Rows[e.RowIndex].Cells);
                DepoDuzenle depoDuzenle = new DepoDuzenle(this);
                depoDuzenle.ShowDialog();
            }
        }

        private void searchForDepoAdi(object sender, EventArgs e)
        {
            if (txtAramaDepoAdi.Text.Count() > 0)
            {
                Search.gridviewArama(txtAramaDepoAdi.Text, depoListGridView, "DEPO_ADI");
            }
            else
            {
                (depoListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                depoListGridView.Refresh();
            }
        }

        private void searchForDepoLokasyon(object sender, EventArgs e)
        {
            if (txtAramaDepoLokasyon.Text.Count() > 0)
            {
                Search.gridviewArama(txtAramaDepoLokasyon.Text, depoListGridView , "DEPO_LOKASYON");
            }
            else
            {
                (depoListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                depoListGridView.Refresh();
            }
        }
        
        private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedItem = new Tuple<int, DataGridViewCellCollection>(depoListGridView.SelectedRows[0].Index, depoListGridView.SelectedRows[0].Cells);
            DepoStokListesi depoStokListesi = new DepoStokListesi(this);
            depoStokListesi.ShowDialog();
        }

        private void depoListGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void depoListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (depoListGridView.SelectedRows.Count == 1))
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, depoListGridView.Rows[e.RowIndex].Cells);
                    depoListGridView.ClearSelection();
                    this.depoListGridView.Rows[e.RowIndex].Selected = true;
                }
                
            } else
            {
                contextMenuStrip1.Enabled = false;
            }
        }
    }
}
