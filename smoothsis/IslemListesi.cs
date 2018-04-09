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
    public partial class IslemListesi : Form
    {
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public IslemListesi()
        {
            InitializeComponent();
        }

        private void IslemListesi_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(islemListGridView);
            listIslem();
        }

        private void listIslem()
        {
            try
            {
                DataTable islemListDTable = new DataTable();

                string query = "SELECT ISLEM_INCKEY, ISLEM_ADI, ACIKLAMA FROM ISLEM ORDER BY ISLEM_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(islemListDTable);
                islemListGridView.DataSource = islemListDTable;
                islemListGridView.Columns[0].Visible = false;
                islemListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            return islemListGridView;
        }

        private void makineDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (islemListGridView.SelectedRows.Count == 1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(islemListGridView.SelectedRows[0].Index, islemListGridView.SelectedRows[0].Cells);
                IslemDuzenle islemDuzenle = new IslemDuzenle(this);
                islemDuzenle.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void showIslem(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, islemListGridView.Rows[e.RowIndex].Cells);
                IslemDuzenle islemDuzenle = new IslemDuzenle(this);
                islemDuzenle.ShowDialog();
            }
        }

        private void searchForIslemAdi(object sender, EventArgs e)
        {
            if (txtAramaIslemAdi.Text.Count() > 0)
            {
                Search.gridviewArama(txtAramaIslemAdi.Text, islemListGridView, "ISLEM_ADI");
            }
            else
            {
                (islemListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                islemListGridView.Refresh();
            }
        }

        private void islemListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (islemListGridView.SelectedRows.Count == 1))
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, islemListGridView.Rows[e.RowIndex].Cells);
                    islemListGridView.ClearSelection();
                    this.islemListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }
    }
}

