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
    public partial class SiparisListesi : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;

        int gridviewClickedRow, gridviewClickedColumn;
        int stokInckey = -1;


        public SiparisListesi(int stokInckey = -1)
        {
            InitializeComponent();
            this.stokInckey = stokInckey;
        }

        private void SiparisListesi_Load(object sender, EventArgs e)
        {
            DataTable siparisListe = new DataTable();
            sqlCmd = new SqlCommand("dbo.Siparis_Listesi", Program.connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@stok_inckey", stokInckey);
            sqlDataAdapter = new SqlDataAdapter(sqlCmd);
            sqlDataAdapter.Fill(siparisListe);

            typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   siparisListGridView,
                   new object[] { true });

            siparisListGridView.DataSource = siparisListe;

            Styler.gridViewCommonStyle(siparisListGridView);

            siparisListGridView.Columns[0].Visible = false;

        }

        private void txtAramaSiparisKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaSiparisKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaSiparisKodu.Text, siparisListGridView, "SIPARIS_KOD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void cmbAramaSiparisTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbAramaSiparisTipi.SelectedItem.ToString()))
                Search.gridviewArama(cmbAramaSiparisTipi.SelectedItem.ToString(), siparisListGridView, "SIPARIS_TIPI");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaProjeKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaProjeKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaProjeKodu.Text, siparisListGridView, "PROJE_KOD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaProjeAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaProjeAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaProjeAdi.Text, siparisListGridView, "PROJE_ADI");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaCariKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaCariKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaCariKodu.Text, siparisListGridView, "CARI_KOD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void txtAramaCariAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaCariAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaCariAdi.Text, siparisListGridView, "ADSOYAD");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void cmbAramaUretimDetay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbAramaUretimDetay.SelectedItem.ToString()))
                Search.gridviewArama(cmbAramaUretimDetay.SelectedItem.ToString(), siparisListGridView, "URETIM_DETAY");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void cmbAramaSiparisDurumu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cmbAramaSiparisDurumu.SelectedItem.ToString()))
                Search.gridviewArama(cmbAramaSiparisDurumu.SelectedItem.ToString(), siparisListGridView, "SIP_DURUM");
            else
                Search.gridviewArama("", siparisListGridView);
        }

        private void siparisListesiMenu_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = this.siparisListGridView.Rows.Count <= 0;
        }

        private void siparisListGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && (e.Button == MouseButtons.Right) && (siparisListGridView.SelectedRows.Count == 1))
            {
                gridviewClickedRow = e.RowIndex;
                gridviewClickedColumn = e.ColumnIndex;

                siparisListGridView.ClearSelection();
                this.siparisListGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void siparisSevkEt(object sender, EventArgs e)
        {
            if (siparisListGridView.SelectedRows.Count == 1)
            {
                sqlCmd = new SqlCommand("dbo.Siparis_UretimMiktar_Durum", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@siparis_inckey", Convert.ToInt32(siparisListGridView.SelectedRows[0].Cells[0].Value.ToString()));

                
                var returnParameter = sqlCmd.Parameters.Add("@rt", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                sqlCmd.ExecuteNonQuery();
                int result = (int)returnParameter.Value;
                if (result == -1)
                {
                    Notification.messageBoxError("Sipariş'e henüz rapor girilmemiş.");
                }
                else if (result == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Sipariş için üretilecek miktara ulaşılamadı, Yine de sevk etmek istoyor musunuz?", "UYARI", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SevkOlustur sevkOlustur = new SevkOlustur(siparisListGridView.SelectedRows[0].Cells);
                        sevkOlustur.ShowDialog();
                    }
                } else
                {
                    SevkOlustur sevkOlustur = new SevkOlustur(siparisListGridView.SelectedRows[0].Cells);
                    sevkOlustur.ShowDialog();
                }
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void sevkListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparisListGridView.SelectedRows.Count == 1)
            {
                int siparisInckey = Convert.ToInt32(siparisListGridView.SelectedRows[0].Cells[0].Value.ToString());
                
                string query = "SELECT COUNT(SEVK_INCKEY) NUMBER_OF_SEVK FROM SEVK " +
                    "WHERE SIPARIS_INCKEY = @siparis_inckey";
                sqlCmd = new SqlCommand(query, Program.connection);
                sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = siparisInckey;
                SqlDataReader reader = sqlCmd.ExecuteReader();
                reader.Read();
                if (((int)reader["NUMBER_OF_SEVK"]) > 0)
                {
                    SevkListesi sevkListesi = new SevkListesi(siparisInckey);
                    sevkListesi.ShowDialog();
                } else
                {
                    Notification.messageBox("BU SİPARİŞ E AİT SEVK BULUNMAMAKTADIR.");
                }                
            }
            else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
            
        }

        private void SiparisListesi_Shown(object sender, EventArgs e)
        {
            siparisListGridView.ClearSelection();
        }

        private void UretimKaydiOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (siparisListGridView.SelectedRows.Count == 1)
            {
                int siparisInckey = int.Parse(siparisListGridView["SIPARIS_INCKEY", gridviewClickedRow].Value.ToString());

                string uretimCheckSQL = "SELECT COUNT(*) FROM URETIM U JOIN SIPARIS_DETAY S ON S.SIP_DETAY_INCKEY = U.SIP_DETAY_INCKEY WHERE S.SIPARIS_INCKEY = @siparis_inckey";
                sqlCmd = new SqlCommand(uretimCheckSQL, Program.connection);
                sqlCmd.Parameters.AddWithValue("@siparis_inckey", siparisInckey);
                if ((int)sqlCmd.ExecuteScalar() > 0)
                {
                    UretimKayitPaneli uretimKaydiOlustur = new UretimKayitPaneli(siparisInckey, true);
                    uretimKaydiOlustur.ShowDialog();
                }
                else
                {
                    UretimKayitPaneli uretimKaydiOlustur = new UretimKayitPaneli(siparisInckey, false);
                    uretimKaydiOlustur.ShowDialog();
                }
            }
        }
    }
}
