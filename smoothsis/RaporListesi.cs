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
        private int uretimInckey;

        public RaporListesi(int uretimInckey = -1)
        {
            InitializeComponent();
            this.uretimInckey = uretimInckey;
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
                if (this.uretimInckey == -1)
                {
                    sqlCmd = new SqlCommand("dbo.Rapor_Listesi", Program.connection);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                } else
                {
                    string query = "SELECT RAPOR.RAPOR_INCKEY, URETIM.UR_INCKEY, FORMAT(RAPOR.RAPOR_TARIH, 'dd.MM.yyyy') RAPOR_TARIHI, " +
                                    "RAPOR.RAPOR_VARDIYA, RAPOR.BESLENEN_MIK BESLENEN_MIKTAR, RAPOR.URETILEN_MIK URETILEN_MIKTAR, RAPOR.FIRE_MIK FIRE_MIKTAR, " +
                                    "RAPOR.FIRE_NEDENI, RAPOR.ISKARTA_MIK ISKARTA_MIKTAR, RAPOR.ISKARTA_NEDENI, RAPOR.ACIKLAMA, K1.ADSOYAD KAYIT_YAPAN_KULLANICI, " +
                                    "FORMAT(RAPOR.KAYIT_TARIH, 'dd.MM.yyyy') KAYIT_TARIHI, K2.ADSOYAD DUZELTME_YAPAN_KULLANICI, FORMAT(RAPOR.DUZELTME_TARIH, 'dd.MM.yyyy') DUZELTME_TARIHI " +
                                    "FROM RAPOR "+
                                    "INNER JOIN URETIM ON RAPOR.UR_INCKEY = URETIM.UR_INCKEY " +
                                    "INNER JOIN KULLANICI K1 ON RAPOR.KAYIT_YAPAN_KUL = K1.KUL_INCKEY " +
                                    "LEFT JOIN KULLANICI K2 ON RAPOR.DUZELTME_YAPAN_KUL = K2.KUL_INCKEY " +
                                    "WHERE RAPOR.UR_INCKEY = @ur_inckey "+
                                    "ORDER BY RAPOR.RAPOR_INCKEY DESC";
                    sqlCmd = new SqlCommand(query, Program.connection);
                    sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = this.uretimInckey;
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(raporListDTable);
                raporListGridView.DataSource = raporListDTable;
                raporListGridView.Columns[0].Visible = false;
                raporListGridView.Columns[1].Visible = false;
                raporListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

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
            string query = "SELECT OPERATOR.OP_INCKEY, OPERATOR.ADSOYAD ADI_SOYADI, CASE WHEN OPERATOR.OP_DURUMU = 1 THEN 'Aktif' ELSE 'Pasif' END AS OPERATOR_DURUMU, " +
                        "FORMAT(OPERATOR.ISE_BAS_TARIH, 'dd.MM.yyyy') ISE_BASLAMA_TARIHI FROM OPERATOR_TO_RAPOR " +
                        "INNER JOIN OPERATOR ON OPERATOR_TO_RAPOR.OP_INCKEY = OPERATOR.OP_INCKEY " +
                        "WHERE OPERATOR_TO_RAPOR.RAPOR_INCKEY = " + Convert.ToInt32(selectedItem.Item2[0].Value.ToString()) + " ORDER BY OPERATOR.OP_INCKEY DESC";
            OperatorListesi operatorListesi = new OperatorListesi();
            operatorListesi.Text = "SMOOTHSIS [ " + selectedItem.Item2[3].Value.ToString() + " VARDİYA RAPORU OPERATÖR LİSTESİ ]";
            operatorListesi.ShowDialog();
            operatorListesi.listOperator(query);
        }
    }
}
