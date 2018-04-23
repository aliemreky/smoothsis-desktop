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
    public partial class SevkListesi : Form
    {
        int siparis_inckey = -1;
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public SevkListesi(int siparis_inckey = -1)
        {
            InitializeComponent();
            this.siparis_inckey = siparis_inckey;
        }

        private void SevkListesi_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(sevkListGridView);
            listSevk();
        }

        public DataGridView getDataGrid()
        {
            return sevkListGridView;
        }

        private void listSevk()
        {
            try
            {
                DataTable sevkListDTable = new DataTable();
                SqlCommand command = new SqlCommand("dbo.Sevk_Listesi", Program.connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@siparis_inckey", siparis_inckey);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(sevkListDTable);
                sevkListGridView.DataSource = sevkListDTable;
                sevkListGridView.Columns[0].Visible = false;
                sevkListGridView.Columns[1].Visible = false;
                sevkListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        private void searchForSiparisKod(object sender, EventArgs e)
        {
            if (txtAramaSiparisKodu.Text.Count() > 0)
                Search.gridviewArama(txtAramaSiparisKodu.Text, sevkListGridView, "SIPARIS_KODU");
            else
                Search.gridviewArama("", sevkListGridView);

        }

        private void searchForIrsaliyeNo(object sender, EventArgs e)
        {
            if (txtAramaIrsaliyeNo.Text.Count() > 0)
                Search.gridviewArama(txtAramaIrsaliyeNo.Text, sevkListGridView, "IRSALIYE_NO");
            else
                Search.gridviewArama("", sevkListGridView);

        }

        private void searchForSevkTarih(object sender, EventArgs e)
        {
            Search.gridviewArama(dtAramaSevkTarih.Value.ToString("dd.MM.yyyy"), sevkListGridView, "SEVK_TARIHI");
        }

        private void btnSevkListesiGetir_Click(object sender, EventArgs e)
        {
            listSevk();
        }

        private void sevkListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (sevkListGridView.SelectedRows.Count == 1))
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, sevkListGridView.Rows[e.RowIndex].Cells);
                    sevkListGridView.ClearSelection();
                    this.sevkListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sevkListGridView.SelectedRows.Count == 1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(sevkListGridView.SelectedRows[0].Index, sevkListGridView.SelectedRows[0].Cells);
                SevkDuzenle sevkDuzenle = new SevkDuzenle(this, selectedItem);
                sevkDuzenle.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }
    }
}
