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
    public partial class DepoStokListesi : Form
    {
        private SqlCommand sqlCmd;
        private DepoListesi depoListesi;
        private DataGridViewCellCollection cellsOfSelectedItem;
        private Tuple<int, DataGridViewCellCollection> depoStokSelectedItem;
        private int rowIndex;

        public DepoStokListesi(DepoListesi depoListesi)
        {
            InitializeComponent();
            this.depoListesi = depoListesi;
        }

        private void DepoStokListesi_Load(object sender, EventArgs e)
        {
            cellsOfSelectedItem = depoListesi.getSelectedItem().Item2;
            Styler.gridViewCommonStyle(depoStokListGridView);
            listDepoStok();
        }

        public void listDepoStok()
        {
            try
            {
                DataTable depoStokListTable = new DataTable();
                string query = "SELECT STOK_DEPO.STOK_DEPO_INCKEY, DEPO.DEPO_ADI, DEPO.DEPO_LOKASYON, STOK_DEPO.MIKTAR, STOK_DEPO.DEPO_INCKEY, STOK.MIKTAR_BIRIM BIRIM, STOK.STOK_KOD, STOK.STOK_ADI FROM STOK_DEPO " +
                    "INNER JOIN DEPO ON STOK_DEPO.DEPO_INCKEY = DEPO.DEPO_INCKEY " +
                    "INNER JOIN STOK ON STOK_DEPO.STOK_INCKEY = STOK.STOK_INCKEY " +
                    "WHERE STOK_DEPO.DEPO_INCKEY = @depo_inckey ORDER BY STOK_DEPO_INCKEY DESC";
                sqlCmd = new SqlCommand(query, Program.connection);
                sqlCmd.Parameters.Add("@depo_inckey", SqlDbType.VarChar).Value = cellsOfSelectedItem[0].Value.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(depoStokListTable);
                depoStokListGridView.DataSource = depoStokListTable;
                depoStokListGridView.Columns[0].Visible = false;
                depoStokListGridView.Columns[1].Visible = false;
                depoStokListGridView.Columns[2].Visible = false;
                depoStokListGridView.Columns[4].Visible = false;
                label3.Text = cellsOfSelectedItem[1].Value.ToString();
                label4.Text = cellsOfSelectedItem[2].Value.ToString();
                depoStokListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        public Tuple<int, DataGridViewCellCollection> getDepoStokSelectedItem()
        {
            return depoStokSelectedItem;
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void silBttn_Click(object sender, EventArgs e)
        {
            if (depoStokListGridView.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "UYARI", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int deletedStokDepoInckey = Int32.Parse(depoStokListGridView.SelectedRows[0].Cells[0].Value.ToString());
                        sqlCmd = new SqlCommand("DELETE FROM STOK_DEPO WHERE STOK_DEPO_INCKEY = @stok_depo_inckey", Program.connection);
                        sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = deletedStokDepoInckey;
                        int affectedRows = sqlCmd.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            sqlCmd = new SqlCommand("SELECT COUNT(STOK_DEPO_INCKEY) FROM STOK_DEPO WHERE STOK_INCKEY = @stok_inckey", Program.connection);
                            sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
                            if (Convert.ToInt32(sqlCmd.ExecuteScalar()) == 0)
                            {
                                sqlCmd = new SqlCommand("DELETE FROM STOK WHERE STOK_INCKEY = @stok_inckey", Program.connection);
                                sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
                                sqlCmd.ExecuteNonQuery();
                            }

                            depoStokListGridView.Rows.RemoveAt(rowIndex);
                            Notification.messageBox("STOK DEPO KAYDI BAŞARIYLA SİLİNDİ.");
                        }
                        else
                        {
                            Notification.messageBoxError("Bir sorun oluştu, stok depo silinemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void selectRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                rowIndex = e.RowIndex;
                depoStokSelectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, depoStokListGridView.Rows[e.RowIndex].Cells);
            }
        }

        private void transferYapBttn_Click(object sender, EventArgs e)
        {
            if (depoStokListGridView.SelectedRows.Count == 1)
            {
                depoStokSelectedItem = new Tuple<int, DataGridViewCellCollection>(depoStokListGridView.SelectedRows[0].Index, depoStokListGridView.SelectedRows[0].Cells);
                StokTransfer stokTransfer = new StokTransfer(this);
                stokTransfer.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void searchForStokKod(object sender, EventArgs e)
        {
            if (txtAramaStokKod.Text.Count() >= 1)
                Search.gridviewArama(txtAramaStokKod.Text, depoStokListGridView, "STOK_KOD");
            else
                Search.gridviewArama("", depoStokListGridView);

        }

        private void searchForStokAdi(object sender, EventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() >= 1)
                Search.gridviewArama(txtAramaStokAdi.Text, depoStokListGridView, "STOK_ADI");
            else
                Search.gridviewArama("", depoStokListGridView);
        }

        private void searchForMiktar(object sender, EventArgs e)
        {
            if (txtAramaMiktar.Text.Count() >= 1)
                Search.gridviewArama(txtAramaMiktar.Text, depoStokListGridView, "MIKTAR");
            else
                Search.gridviewArama("", depoStokListGridView);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
