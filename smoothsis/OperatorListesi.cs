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
using smoothsis.Services.Enums;

namespace smoothsis
{
    public partial class OperatorListesi : Form
    {
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public OperatorListesi()
        {
            InitializeComponent();
        }

        private void OperatorListesi_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(operatorListGridView);
            cbOperatorDurum.DataSource = Enum.GetValues(typeof(Condition));
            listOperator();
            

        }

        private void listOperator()
        {
            try
            {
                DataTable operatorListDTable = new DataTable();
                string query = "SELECT OP_INCKEY, ADSOYAD ADI_SOYADI, CASE WHEN OP_DURUMU = 1 THEN 'Aktif' ELSE 'Pasif' END AS OPERATOR_DURUMU, FORMAT(ISE_BAS_TARIH, 'dd.MM.yyyy') ISE_BASLAMA_TARIHI FROM OPERATOR ORDER BY OP_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(operatorListDTable);
                operatorListGridView.DataSource = operatorListDTable;
                operatorListGridView.Columns[0].Visible = false;
                operatorListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            return operatorListGridView;
        }

        private void operatorDuzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (operatorListGridView.SelectedRows.Count == 1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(operatorListGridView.SelectedRows[0].Index, operatorListGridView.SelectedRows[0].Cells);
                OperatorDuzenle operatorDuzenle = new OperatorDuzenle(this);
                operatorDuzenle.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void showOperator(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, operatorListGridView.Rows[e.RowIndex].Cells);
                OperatorDuzenle operatorDuzenle = new OperatorDuzenle(this);
                operatorDuzenle.ShowDialog();
            }
        }

        private void searchForAdSoyad(object sender, EventArgs e)
        {
            if (txtAramaAdiSoyadi.Text.Count() > 0)
            {
                Search.gridviewArama(txtAramaAdiSoyadi.Text, operatorListGridView, "ADI_SOYADI");
            }
            else
            {
                (operatorListGridView.DataSource as DataTable).DefaultView.RowFilter = "";
                operatorListGridView.Refresh();
            }
        }

        private void operatorListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (operatorListGridView.SelectedRows.Count == 1))
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, operatorListGridView.Rows[e.RowIndex].Cells);
                    operatorListGridView.ClearSelection();
                    this.operatorListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            Search.gridviewArama(dtpIseBaslamaTarihi.Value.ToString("dd.MM.yyyy"), operatorListGridView, "ISE_BASLAMA_TARIHI");
        }

        private void btnOperatorListesiGetir_Click(object sender, EventArgs e)
        {
            listOperator();
        }

        private void cbOperatorDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbOperatorDurum.SelectedValue.ToString()) && operatorListGridView.DataSource != null)
            {
                Search.gridviewArama(cbOperatorDurum.SelectedValue.ToString(), operatorListGridView, "OPERATOR_DURUMU");
            }
        }
    }
}
