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
using System.Text.RegularExpressions;
using smoothsis.Services;

namespace smoothsis
{
    public partial class StokOlustur : Form
    {
        private SqlCommand sqlCmd;

        public StokOlustur()
        {
            InitializeComponent();
        }

        private void StokOlustur_Load(object sender, EventArgs e)
        {
            cbMiktarBirim.DataSource = Enum.GetNames(typeof(smoothsis.Services.Enums.MalzemeMiktarBirim));
        }
        
        private void btnStokKodOlustur_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStokKod.Text))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT TOP 1 STOK_INCKEY FROM STOK ORDER BY STOK_INCKEY DESC", Program.connection);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtStokKod.Text = "S0000000" + sqlReader["STOK_INCKEY"].ToString();
                        sqlReader.Close();
                    }
                    else
                    {
                        txtStokKod.Text = "S00000001";
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStokKod.Text) ||
                String.IsNullOrEmpty(txtStokAdi.Text) ||
                String.IsNullOrEmpty(txtMiktar.Text) ||
                String.IsNullOrEmpty(txtBirimFiyat.Text) )
            {
                Notification.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ !");
            }
            else
            {
                try
                {
                    string stokKayitSQL = "INSERT INTO " +
                        "STOK(STOK_KOD, STOK_ADI, MIKTAR, MIKTAR_BIRIM, BIRIM_FIYAT, GELIS_TARIH, AMBALAJ_BILGI," +
                        " MALZ_SERISI, MALZ_CINSI, MALZ_OLCU, ETIKET_BILGI, ACIKLAMA, KAYIT_YAPAN_KUL) " +
                        "VALUES (@stok_kod, @stok_adi, @miktar, @miktar_birim, @birim_fiyat," +
                        " @gelis_tarih, @ambalaj_bilgi, @malz_serisi, @malz_cinsi, @malz_olcu, @etiket_bilgi, " +
                        "@aciklama, @kayit_yapan_kul)";
                    sqlCmd = new SqlCommand(stokKayitSQL, Program.connection);
                    sqlCmd.Parameters.Add("@stok_kod", SqlDbType.VarChar).Value = txtStokKod.Text;
                    sqlCmd.Parameters.Add("@stok_adi", SqlDbType.VarChar).Value = txtStokAdi.Text;
                    sqlCmd.Parameters.Add("@miktar", SqlDbType.Float).Value = float.Parse(txtMiktar.Text);
                    sqlCmd.Parameters.Add("@miktar_birim", SqlDbType.VarChar).Value = cbMiktarBirim.SelectedValue;
                    sqlCmd.Parameters.Add("@birim_fiyat", SqlDbType.Float).Value = float.Parse(txtBirimFiyat.Text);
                    sqlCmd.Parameters.Add("@gelis_tarih", SqlDbType.Date).Value = dtpGelisTarih.Value;
                    sqlCmd.Parameters.Add("@ambalaj_bilgi", SqlDbType.VarChar).Value = txtAmbalajBilgi.Text;
                    sqlCmd.Parameters.Add("@malz_serisi", SqlDbType.VarChar).Value = txtMalzSerisi.Text;
                    sqlCmd.Parameters.Add("@malz_cinsi", SqlDbType.VarChar).Value = txtMalzCinsi.Text;
                    sqlCmd.Parameters.Add("@malz_olcu", SqlDbType.VarChar).Value = txtMalzOlcu.Text;
                    sqlCmd.Parameters.Add("@etiket_bilgi", SqlDbType.VarChar).Value = txtEtiketBilgi.Text;
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text;
                    sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;

                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        Notification.messageBox("STOK BAŞARIYLA OLUŞTURULDU");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
           ActionControl.ActionAllControls(this, "clear");
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void numericValidate(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForNumeric(sender, e);
        }
    }
}
