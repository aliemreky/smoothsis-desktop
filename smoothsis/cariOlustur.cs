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

namespace smoothsis
{
    public partial class CariOlustur : Form
    {
        private SqlCommand sqlCmd;

        public CariOlustur()
        {
            InitializeComponent();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtCariKod.Text) ||
                String.IsNullOrEmpty(txtTicariUnvan.Text) ||
                String.IsNullOrEmpty(txtIl.Text) ||
                String.IsNullOrEmpty(txtIlce.Text) ||
                String.IsNullOrEmpty(txtAdSoyad.Text) ||
                String.IsNullOrEmpty(txtAdres.Text) ||
                String.IsNullOrEmpty(txtTelefonNo.Text))
            {
                Program.controllerClass.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ !");
            }
            else
            {
                try
                {
                    string cariKayitSQL = "INSERT INTO CARI (CARI_KOD, ADSOYAD, IL, ILCE, ADRES, TICARI_UNVAN, VERGI_DAIRE, VERGI_NO, TEL_NO, EPOSTA, CEP_TEL, FAX_NO, TC_NO, CARI_DURUM, KAYIT_YAPAN_KUL, DUZELTME_YAPAN_KUL, DUZELTME_TARIH, GERCEK_TUZEL_DURUM) VALUES (@cari_kod, @adsoyad, @il, @ilce, @adres, @ticari_unvan, @vergi_daire, @vergi_no, @tel_no, @eposta, @cep_tel, @fax_no, @tc_no, @cari_durum, @kayit_yapan_kul, NULL, NULL, @gercek_tuzel_durum )";
                    sqlCmd = new SqlCommand(cariKayitSQL, Program.connection);
                    sqlCmd.Parameters.Add("@cari_kod", SqlDbType.VarChar).Value = txtCariKod.Text;
                    sqlCmd.Parameters.Add("@adsoyad", SqlDbType.VarChar).Value = txtAdSoyad.Text;
                    sqlCmd.Parameters.Add("@il", SqlDbType.VarChar).Value = txtIl.Text;
                    sqlCmd.Parameters.Add("@ilce", SqlDbType.VarChar).Value = txtIlce.Text;
                    sqlCmd.Parameters.Add("@adres", SqlDbType.Text).Value = txtAdres.Text;
                    sqlCmd.Parameters.Add("@ticari_unvan", SqlDbType.VarChar).Value = txtTicariUnvan.Text;
                    sqlCmd.Parameters.Add("@vergi_daire", SqlDbType.VarChar).Value = txtVergiDaire.Text;
                    sqlCmd.Parameters.Add("@vergi_no", SqlDbType.VarChar).Value = txtVergiNo.Text;
                    sqlCmd.Parameters.Add("@tel_no", SqlDbType.VarChar).Value = txtTelefonNo.Text;
                    sqlCmd.Parameters.Add("@eposta", SqlDbType.VarChar).Value = txtEposta.Text;
                    sqlCmd.Parameters.Add("@cep_tel", SqlDbType.VarChar).Value = txtCepTel.Text;
                    sqlCmd.Parameters.Add("@fax_no", SqlDbType.VarChar).Value = txtFaxNo.Text;
                    sqlCmd.Parameters.Add("@tc_no", SqlDbType.Char).Value = txtTcKimlik.Text;
                    sqlCmd.Parameters.Add("@cari_durum", SqlDbType.Bit).Value = (hesapDurumuAktif.Checked) ? 1 : 0;
                    sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    sqlCmd.Parameters.Add("@gercek_tuzel_durum", SqlDbType.Bit).Value = (gercekKisiRadio.Checked) ? 1 : 0;


                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }

                if (sqlCmd.ExecuteNonQuery() > 0)
                {
                    Program.controllerClass.messageBox("CARİ BAŞARIYLA OLUŞTURULDU");
                }

            }
        }

        private void gercekKisiRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (gercekKisiRadio.Checked)
            {
                txtVergiDaire.Clear();
                txtVergiNo.Clear();

                txtVergiDaire.Enabled = false;
                txtVergiDaire.ReadOnly = true;
                txtVergiNo.Enabled = false;
                txtVergiNo.ReadOnly = true;
                txtTcKimlik.Enabled = true;
                txtTcKimlik.ReadOnly = false;
            }
            else
            {
                txtTcKimlik.Clear();

                txtTcKimlik.Enabled = false;
                txtTcKimlik.ReadOnly = true;
                txtVergiDaire.Enabled = true;
                txtVergiDaire.ReadOnly = false;
                txtVergiNo.Enabled = true;
                txtVergiNo.ReadOnly = false;
            }
        }

        private void CariOlustur_Load(object sender, EventArgs e)
        {

        }

        private void btnCariKodOlustur_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCariKod.Text))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT TOP 1 CARI_INCKEY FROM CARI ORDER BY CARI_INCKEY DESC", Program.connection);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtCariKod.Text = "M" + (int.Parse(sqlReader["CARI_INCKEY"].ToString()) + 1).ToString("D8");
                        sqlReader.Close();

                    }
                    else
                        txtCariKod.Text = "M00000001";
                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.controllerClass.ActionAllControls(this, "clear");
        }

        private void txtTcKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                if ((sender as TextBox).Text.Count(Char.IsDigit) > 11 && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        private void txtVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',');
        }
    }
}
