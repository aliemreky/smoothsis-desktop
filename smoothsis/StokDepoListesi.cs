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
    public partial class StokDepoListesi : Form
    {
        private SqlCommand sqlCmd;
        private StokListesi stokListesi;
        DataGridViewCellCollection cellsOfSelectedItem;
        private Tuple<int, DataGridViewCellCollection> stokDepoSelectedItem;
        private int rowIndex;

        public StokDepoListesi(StokListesi stokListesi)
        {
            InitializeComponent();
            this.stokListesi = stokListesi;
        }

        private void StokDepoListesi_Load(object sender, EventArgs e)
        {
            cellsOfSelectedItem = stokListesi.getSelectedItem().Item2;
            txtStokKod.Text = cellsOfSelectedItem[1].Value.ToString();
            txtStokAdi.Text = cellsOfSelectedItem[2].Value.ToString();
            txtStokBirim.Text = cellsOfSelectedItem[3].Value.ToString();
            Styler.gridViewCommonStyle(stokDepoListGridView);
            listStokDepo();
        }

        public void listStokDepo()
        {
            try
            {
                DataTable stokListDepoTable = new DataTable();
                string query = "SELECT STOK_DEPO.STOK_DEPO_INCKEY, DEPO.DEPO_ADI, DEPO.DEPO_LOKASYON, " +
                    "STOK_DEPO.MIKTAR, STOK_DEPO.DEPO_INCKEY FROM STOK_DEPO " +
                    "INNER JOIN DEPO ON STOK_DEPO.DEPO_INCKEY = DEPO.DEPO_INCKEY " +
                    "WHERE STOK_DEPO.STOK_INCKEY = @stok_inckey ORDER BY STOK_DEPO_INCKEY DESC";
                sqlCmd = new SqlCommand(query, Program.connection);
                sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.VarChar).Value = cellsOfSelectedItem[0].Value.ToString();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(stokListDepoTable);
                stokDepoListGridView.DataSource = stokListDepoTable;
                stokDepoListGridView.Columns[0].Visible = false;
                stokDepoListGridView.Columns[4].Visible = false;
                stokDepoListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        public Tuple<int, DataGridViewCellCollection> getStokDepoSelectedItem()
        {
            return stokDepoSelectedItem;
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transferYapBttn_Click(object sender, EventArgs e)
        {
            if (stokDepoListGridView.SelectedRows.Count == 1)
            {
                stokDepoSelectedItem = new Tuple<int, DataGridViewCellCollection>(stokDepoListGridView.SelectedRows[0].Index, stokDepoListGridView.SelectedRows[0].Cells);
                StokTransfer stokTransfer = new StokTransfer(this);
                stokTransfer.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void silBttn_Click(object sender, EventArgs e)
        {
            if (stokDepoListGridView.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "UYARI", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int deletedStokDepoInckey = Int32.Parse(stokDepoListGridView.SelectedRows[0].Cells[0].Value.ToString());
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

                            stokDepoListGridView.Rows.RemoveAt(rowIndex);
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
                stokDepoSelectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, stokDepoListGridView.Rows[e.RowIndex].Cells);
            }
        }

        public DataGridView getDataGrid()
        {
            return stokDepoListGridView;
        }

        private void stokDepoListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                contextMenuStrip1.Enabled = true;
                if ((e.Button == MouseButtons.Right) && (stokDepoListGridView.SelectedRows.Count == 1))
                {
                    stokDepoSelectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, stokDepoListGridView.Rows[e.RowIndex].Cells);
                    stokDepoListGridView.ClearSelection();
                    this.stokDepoListGridView.Rows[e.RowIndex].Selected = true;
                }
            }
            else
            {
                contextMenuStrip1.Enabled = false;
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stokDepoListGridView.SelectedRows.Count == 1)
            {
                stokDepoSelectedItem = new Tuple<int, DataGridViewCellCollection>(stokDepoListGridView.SelectedRows[0].Index, stokDepoListGridView.SelectedRows[0].Cells);
                StokDepoDuzenle stokDepoDuzenle = new StokDepoDuzenle(this);
                stokDepoDuzenle.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }
    }
}
