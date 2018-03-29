using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smoothsis.Services;
using System.Data.SqlClient;

namespace smoothsis
{
    public partial class StokDuzenle : Form
    {
        private SqlCommand sqlCmd;
        private StokListesi stokListesi;
        DataGridViewCellCollection cellsOfSelectedItem;

        public StokDuzenle(StokListesi stokListesi)
        {
            InitializeComponent();
            this.stokListesi = stokListesi;
        }

        private void StokDuzenle_Load(object sender, EventArgs e)
        {
            cbMiktarBirim.DataSource = Enum.GetNames(typeof(smoothsis.Services.Enums.MalzemeMiktarBirim));
            cellsOfSelectedItem = stokListesi.getSelectedItem().Item2;
            txtStokKod.Text = cellsOfSelectedItem[1].Value.ToString();
            txtStokAdi.Text = cellsOfSelectedItem[2].Value.ToString();
            cbMiktarBirim.SelectedIndex = cbMiktarBirim.FindString(cellsOfSelectedItem[3].Value.ToString());
            txtBirimFiyat.Text = cellsOfSelectedItem[5].Value.ToString();
            dtpGelisTarih.Value = DateTime.Parse(cellsOfSelectedItem[6].Value.ToString());
            txtAmbalajBilgi.Text = cellsOfSelectedItem[7].Value.ToString();
            txtMalzSerisi.Text = cellsOfSelectedItem[8].Value.ToString();
            txtMalzCinsi.Text = cellsOfSelectedItem[9].Value.ToString();
            txtMalzOlcu.Text = cellsOfSelectedItem[10].Value.ToString();
            txtEtiketBilgi.Text = cellsOfSelectedItem[11].Value.ToString();
            txtAciklama.Text = cellsOfSelectedItem[12].Value.ToString();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStokKod.Text) ||
                String.IsNullOrEmpty(txtStokAdi.Text) ||
                String.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                Notification.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ !");
            }
            else
            {
                try
                {
                    string stokKayitSQL = "UPDATE STOK SET " +
                            "STOK_KOD = @stok_kod, STOK_ADI = @stok_adi, MIKTAR_BIRIM = @miktar_birim, " +
                            "BIRIM_FIYAT = @birim_fiyat, GELIS_TARIH = @gelis_tarih, AMBALAJ_BILGI = @ambalaj_bilgi, " +
                            "MALZ_SERISI = @malz_serisi, MALZ_CINSI = @malz_cinsi, MALZ_OLCU = @malz_olcu, ETIKET_BILGI = @etiket_bilgi, " +
                            "ACIKLAMA = @aciklama, DUZELTME_YAPAN_KUL = @duzeltme_yapan_kul, DUZELTME_TARIH = @duzeltme_tarih WHERE STOK_INCKEY = @stok_inckey";
                    sqlCmd = new SqlCommand(stokKayitSQL, Program.connection);
                    sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = Convert.ToUInt32(cellsOfSelectedItem[0].Value.ToString());
                    sqlCmd.Parameters.Add("@stok_kod", SqlDbType.VarChar).Value = txtStokKod.Text;
                    sqlCmd.Parameters.Add("@stok_adi", SqlDbType.VarChar).Value = txtStokAdi.Text;
                    sqlCmd.Parameters.Add("@miktar_birim", SqlDbType.VarChar).Value = cbMiktarBirim.SelectedValue;
                    sqlCmd.Parameters.Add("@birim_fiyat", SqlDbType.Decimal).Value = decimal.Parse(txtBirimFiyat.Text);
                    sqlCmd.Parameters.Add("@gelis_tarih", SqlDbType.Date).Value = dtpGelisTarih.Value;
                    sqlCmd.Parameters.Add("@ambalaj_bilgi", SqlDbType.VarChar).Value = txtAmbalajBilgi.Text;
                    sqlCmd.Parameters.Add("@malz_serisi", SqlDbType.VarChar).Value = txtMalzSerisi.Text;
                    sqlCmd.Parameters.Add("@malz_cinsi", SqlDbType.VarChar).Value = txtMalzCinsi.Text;
                    sqlCmd.Parameters.Add("@malz_olcu", SqlDbType.VarChar).Value = txtMalzOlcu.Text;
                    sqlCmd.Parameters.Add("@etiket_bilgi", SqlDbType.VarChar).Value = txtEtiketBilgi.Text;
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text;
                    sqlCmd.Parameters.Add("@duzeltme_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    sqlCmd.Parameters.Add("@duzeltme_tarih", SqlDbType.DateTime).Value = DateTime.Now.ToString();

                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        updateItemOnList();
                        Notification.messageBox("STOK BAŞARIYLA GÜNCELLENDİ.");
                    }
                    else
                    {
                        Notification.messageBoxError("BİR SORUN OLUŞTU, STOK GÜNCELLENEMEDI.");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        private void numericValidate(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForNumeric(sender, e);
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = stokListesi.getDataGrid();
            int rowIndex = stokListesi.getSelectedItem().Item1;
            dataGridView[1, rowIndex].Value = txtStokKod.Text;
            dataGridView[2, rowIndex].Value = txtStokAdi.Text;
            dataGridView[3, rowIndex].Value = cbMiktarBirim.SelectedValue;
            dataGridView[5, rowIndex].Value = txtBirimFiyat.Text;
            dataGridView[6, rowIndex].Value = dtpGelisTarih.Value;
            dataGridView[7, rowIndex].Value = txtAmbalajBilgi.Text;
            dataGridView[8, rowIndex].Value = txtMalzSerisi.Text;
            dataGridView[9, rowIndex].Value = txtMalzCinsi.Text;
            dataGridView[10, rowIndex].Value = txtMalzOlcu.Text;
            dataGridView[11, rowIndex].Value = txtEtiketBilgi.Text;
            dataGridView[12, rowIndex].Value = txtAciklama.Text;
            dataGridView[15, rowIndex].Value = Program.kullanici.Item2;
            dataGridView[16, rowIndex].Value = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void silBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM STOK WHERE STOK_INCKEY = @stok_inckey", Program.connection);
                    command.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = (int)stokListesi.getSelectedItem().Item2[0].Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        stokListesi.getDataGrid().Rows.RemoveAt(stokListesi.getSelectedItem().Item1);
                        Notification.messageBox("Stok Başarıyla Silindi");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, stok silinemedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Source);
            }
        }
    }
}
