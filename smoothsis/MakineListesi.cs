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
    public partial class MakineListesi : Form
    {
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public MakineListesi()
        {
            InitializeComponent();
        }

        private void MakineListesi_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(makListGridView);
            listMakine();
        }

        private void listMakine()
        {
            try
            {
                DataTable makineListDTable = new DataTable();

                string query = "SELECT MAK_INCKEY, MAK_ADI MAKINE_ADI, ACIKLAMA FROM MAKINE ORDER BY MAK_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(makineListDTable);
                makListGridView.DataSource = makineListDTable;
                makListGridView.Columns[0].Visible = false;
                makListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            return makListGridView;
        }

        private void makineDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (makListGridView.SelectedRows.Count == 1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(makListGridView.SelectedRows[0].Index, makListGridView.SelectedRows[0].Cells);
                MakineDuzenle makineDuzenle = new MakineDuzenle(this);
                makineDuzenle.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void showMakine(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, makListGridView.Rows[e.RowIndex].Cells);
                MakineDuzenle makineDuzenle = new MakineDuzenle(this);
                makineDuzenle.ShowDialog();
            }
        }

        private void searchForMakAdi(object sender, EventArgs e)
        {
            if (txtAramaMakAdi.Text.Count() > 0)
            {
                Search.gridviewArama(txtAramaMakAdi.Text, makListGridView, "MAKINE_ADI");
            }
            else
            {
                (makListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                makListGridView.Refresh();
            }
        }
        
        private void makineListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (makListGridView.SelectedRows.Count == 1))
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, makListGridView.Rows[e.RowIndex].Cells);
                    makListGridView.ClearSelection();
                    this.makListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void MakineListesi_Shown(object sender, EventArgs e)
        {
            makListGridView.ClearSelection();
        }
    }
}

