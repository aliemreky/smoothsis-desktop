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
    public partial class UretimListesi : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;
        private Tuple<int, DataGridViewCellCollection> selectedItem;
        public DataTable siparisListe;

        public UretimListesi()
        {
            InitializeComponent();
        }

        private void UretimListesi_Load(object sender, EventArgs e)
        {            
            getUretimListesi();
            uretimListGridView.ClearSelection();
        }

        public void getUretimListesi()
        {
            siparisListe = new DataTable();
            sqlCmd = new SqlCommand("dbo.Uretim_Listesi", Program.connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter = new SqlDataAdapter(sqlCmd);
            sqlDataAdapter.Fill(siparisListe);

            typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   uretimListGridView,
                   new object[] { true });

            uretimListGridView.DataSource = siparisListe;

            Styler.gridViewCommonStyle(uretimListGridView);

            uretimListGridView.Columns[0].Visible = false;
        }

        private void txtAramaStokKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaStokKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaStokKodu.Text, uretimListGridView, "STOK_KODU");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void txtAramaStokAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaStokAdi.Text, uretimListGridView, "STOK_ADI");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void txtAramaIslem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaIslem.Text.Count() > 1)
                Search.gridviewArama(txtAramaIslem.Text, uretimListGridView, "ISLEM");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void txtAramaMakine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaMakine.Text.Count() > 1)
                Search.gridviewArama(txtAramaMakine.Text, uretimListGridView, "MAKINE");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void btnUretimListesiGetir_Click(object sender, EventArgs e)
        {
            getUretimListesi();
        }

        private void uretimListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right && (uretimListGridView.SelectedRows.Count == 1))
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, uretimListGridView.Rows[e.RowIndex].Cells);
                uretimListGridView.ClearSelection();
                this.uretimListGridView.Rows[e.RowIndex].Selected = true;

            }
        }

        private void raporOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uretimListGridView.SelectedRows.Count == 1)
            {
                decimal uretimYuzde = decimal.Parse(selectedItem.Item2["YUZDE"].Value.ToString());

                if (uretimYuzde >= 100)
                {
                    Notification.messageBox("Üretim Kapanmıştır. Rapor Girişi Yapılamaz !");
                }
                else
                {
                    selectedItem = new Tuple<int, DataGridViewCellCollection>(uretimListGridView.SelectedRows[0].Index, uretimListGridView.SelectedRows[0].Cells);
                    RaporOlustur raporOlustur = new RaporOlustur(this);
                    raporOlustur.ShowDialog();
                }
            }
            else
            {
                Notification.messageBoxError("Bir sorun oluştu, geçerli bir kayıt seçilemedi !");
            }
        }

        public Tuple<int, DataGridViewCellCollection> getSelectedItem()
        {
            return selectedItem;
        }

        private void raporListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uretimListGridView.SelectedRows.Count == 1)
            {
                RaporListesi raporListesi = new RaporListesi(Convert.ToInt32(selectedItem.Item2[0].Value.ToString()));
                raporListesi.ShowDialog();
            }
            else
            {
                Notification.messageBoxError("Bir sorun oluştu, geçerli bir kayıt seçilemedi !");
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.uretimListGridView.Rows.Count <= 0 || this.uretimListGridView.SelectedRows.Count <= 0;
        }

        private void uretimListGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            decimal uretimYuzde = decimal.Parse(uretimListGridView.Rows[e.RowIndex].Cells["YUZDE"].Value.ToString());

            if (e.Value != null && uretimYuzde >= 100)
            {
                uretimListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                uretimListGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else if (e.Value != null && uretimYuzde == 0)
            {
                uretimListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                uretimListGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else if (e.Value != null && uretimYuzde > 0 | uretimYuzde < 100)
            {
                uretimListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                uretimListGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        public void updateColors(int RowIndex)
        {
            decimal uretimYuzde = decimal.Parse(uretimListGridView.Rows[RowIndex].Cells["YUZDE"].Value.ToString());

            if (uretimYuzde >= 100)
            {
                uretimListGridView.Rows[RowIndex].DefaultCellStyle.BackColor = Color.Green;
                uretimListGridView.Rows[RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else if (uretimYuzde == 0)
            {
                uretimListGridView.Rows[RowIndex].DefaultCellStyle.BackColor = Color.DarkGoldenrod;
                uretimListGridView.Rows[RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            else if (uretimYuzde > 0 | uretimYuzde < 100)
            {
                uretimListGridView.Rows[RowIndex].DefaultCellStyle.BackColor = Color.Red;
                uretimListGridView.Rows[RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void UretimListesi_Shown(object sender, EventArgs e)
        {
            uretimListGridView.ClearSelection();
        }

        public DataGridView getDataGrid()
        {
            return uretimListGridView;
        }
    }
}
