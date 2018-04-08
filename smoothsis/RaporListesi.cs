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
    public partial class RaporListesi : Form
    {
        private SqlCommand sqlCmd;
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public RaporListesi()
        {
            InitializeComponent();
        }

        private void RaporListesi_Load(object sender, EventArgs e)
        {

            Styler.gridViewCommonStyle(raporListGridView);
            listRapor();
        }
        
        private void listRapor()
        {
            try
            {
                DataTable raporListDTable = new DataTable();
                sqlCmd = new SqlCommand("dbo.Rapor_Listesi", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(raporListDTable);
                raporListGridView.DataSource = raporListDTable;
                raporListGridView.Columns[0].Visible = false;
                raporListGridView.Columns[1].Visible = false;
                raporListGridView.Columns[2].Visible = false;
                raporListGridView.Columns[3].Visible = false;
                raporListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        private void searchForOperatorAdi(object sender, EventArgs e)
        {
            if (txtAramaOperatorAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaOperatorAdi.Text, raporListGridView, "OPERATOR_ADI");
            else
                Search.gridviewArama("", raporListGridView);

        }

        private void searchForRaporVardiya(object sender, EventArgs e)
        {
            if (txtAramaRaporVardiya.Text.Count() > 1)
                Search.gridviewArama(txtAramaRaporVardiya.Text, raporListGridView, "RAPOR_VARDIYA");
            else
                Search.gridviewArama("", raporListGridView);

        }

        private void searchForRaporTarih(object sender, EventArgs e)
        {
            Search.gridviewArama(dtAramaRaporTarih.Value.ToString("dd.MM.yyyy"), raporListGridView, "RAPOR_TARIHI");
        }

        private void btnRaporListesiGetir_Click(object sender, EventArgs e)
        {
            listRapor();
        }

        private void duzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (raporListGridView.SelectedRows.Count == 1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(raporListGridView.SelectedRows[0].Index, raporListGridView.SelectedRows[0].Cells);
                RaporDuzenle raporDuzenle = new RaporDuzenle(this);
                raporDuzenle.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ!");
            }
            
        }

        private void raporListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (raporListGridView.SelectedRows.Count == 1))
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, raporListGridView.Rows[e.RowIndex].Cells);
                    raporListGridView.ClearSelection();
                    this.raporListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        public DataGridView getDataGrid()
        {
            return raporListGridView;
        }

        public Tuple<int, DataGridViewCellCollection> getSelectedItem()
        {
            return selectedItem;
        }

        private void uretimBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operatorBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "SELECT OP_INCKEY, ADSOYAD ADI_SOYADI, CASE WHEN OP_DURUMU = 1 THEN 'Aktif' ELSE 'Pasif' END AS OPERATOR_DURUMU, FORMAT(ISE_BAS_TARIH, 'dd.MM.yyyy') ISE_BASLAMA_TARIHI FROM OPERATOR " +
                " WHERE OP_INCKEY = @op_inckey";
            sqlCmd = new SqlCommand(query, Program.connection);
            sqlCmd.Parameters.Add("@op_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedItem.Item2[2].Value.ToString());
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            OperatorBilgileri operatorBilgileri = new OperatorBilgileri(new string[]{
                    reader["OP_INCKEY"].ToString(),
                    reader["ADI_SOYADI"].ToString(),
                    reader["OPERATOR_DURUMU"].ToString(),
                    reader["ISE_BASLAMA_TARIHI"].ToString()
            });
            operatorBilgileri.ShowDialog();
        }
    }
}
