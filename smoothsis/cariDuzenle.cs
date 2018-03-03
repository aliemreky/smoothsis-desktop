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
using System.Reflection;
using smoothsis.Services;

namespace smoothsis
{
    public partial class cariDuzenle : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable cariListe = new DataTable();
        private Tuple<int, string> secilenCari;

        public cariDuzenle()
        {
            InitializeComponent();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.controllerClass.ActionAllControls(this, "clear");
        }

        private void cariListeleDuzenle_Load(object sender, EventArgs e)
        {
            Program.controllerClass.ActionAllControls(groupBox1, "disable");
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

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCariKod.Text))
            {
                Program.controllerClass.messageBoxError("LÜTFEN BİR KAYIT SEÇİNİZ !");
            }
            else
            {
                if (String.IsNullOrEmpty(txtTicariUnvan.Text) &&
                String.IsNullOrEmpty(txtIl.Text) &&
                String.IsNullOrEmpty(txtIlce.Text) &&
                String.IsNullOrEmpty(txtAdSoyad.Text) &&
                String.IsNullOrEmpty(txtAdres.Text) &&
                String.IsNullOrEmpty(txtTelefonNo.Text))
                {
                    Program.controllerClass.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ !");
                }
                else
                {
                    try
                    {
                        string cariKayitSQL = "UPDATE CARI SET ADSOYAD=@adsoyad, IL=@il, ILCE=@ilce, ADRES=@adres, TICARI_UNVAN=@ticari_unvan, VERGI_DAIRE=@vergi_daire, VERGI_NO=@vergi_no, TEL_NO=@tel_no, EPOSTA=@eposta, CEP_TEL=@cep_tel, FAX_NO=@fax_no, TC_NO=@tc_no, CARI_DURUM=@cari_durum, DUZELTME_YAPAN_KUL=@duzeltme_yapan_kul, DUZELTME_TARIH=GETDATE(), GERCEK_TUZEL_DURUM=@gercek_tuzel_durum WHERE CARI_KOD=@cari_kod";
                        sqlCmd = new SqlCommand(cariKayitSQL, Program.connection);
                        sqlCmd.Parameters.Add("@cari_kod", SqlDbType.VarChar).Value = secilenCari.Item2;
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
                        sqlCmd.Parameters.Add("@duzeltme_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                        sqlCmd.Parameters.Add("@gercek_tuzel_durum", SqlDbType.Bit).Value = (gercekKisiRadio.Checked) ? 1 : 0;
                    }
                    catch (Exception ex)
                    {
                        Program.controllerClass.messageBoxError(ex.Message);
                    }


                    if (sqlCmd.ExecuteNonQuery() > 0)
                        Program.controllerClass.messageBox("CARİ BAŞARIYLA DÜZENLENDİ");

                }
            }

        }


        private void txtTcKimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextValidate.tcKimlikValidate(sender,e);
        }

        private void txtVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForNumericWithDot(sender,e);
        }

        private void kayitSilBtn_Click(object sender, EventArgs e)
        {
            if (secilenCari != null)
            {
                DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlCmd = new SqlCommand("DELETE FROM CARI WHERE CARI_INCKEY=@cari_inckey", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_inckey", secilenCari.Item1);
                    if (sqlCmd.ExecuteNonQuery() > 0)
                        Program.controllerClass.messageBox("CARİ BAŞARIYLA SİLİNDİ");

                }
            }

        }

        private void btnCariListeAc_Click(object sender, EventArgs e)
        {
            cariListesi cariList = new cariListesi(1);
            cariList.ShowDialog();
            secilenCari = cariList.passingCari;
            txtCariKod.Text = secilenCari.Item2;
        }

        private void txtCariKod_TextChanged(object sender, EventArgs e)
        {

            Program.controllerClass.ActionAllControls(groupBox1, "enable");

            try
            {

                sqlCmd = new SqlCommand("SELECT * FROM CARI WHERE CARI_KOD=@cari_kod", Program.connection);
                sqlCmd.Parameters.AddWithValue("@cari_kod", secilenCari.Item1);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                sqlReader.Read();

                if (!String.IsNullOrEmpty(sqlReader["TC_NO"].ToString()))
                {
                    gercekKisiRadio.Checked = true;
                    tuzelKisiRadio.Checked = false;

                    txtVergiDaire.Enabled = false;
                    txtVergiDaire.ReadOnly = true;
                    txtVergiNo.Enabled = false;
                    txtVergiNo.ReadOnly = true;
                    txtTcKimlik.Enabled = true;
                    txtTcKimlik.ReadOnly = false;
                }
                else
                {
                    tuzelKisiRadio.Checked = true;
                    gercekKisiRadio.Checked = false;

                    txtTcKimlik.Enabled = false;
                    txtTcKimlik.ReadOnly = true;
                    txtVergiDaire.Enabled = true;
                    txtVergiDaire.ReadOnly = false;
                    txtVergiNo.Enabled = true;
                    txtVergiNo.ReadOnly = false;
                }

                txtTicariUnvan.Text = sqlReader["TICARI_UNVAN"].ToString();
                txtAdSoyad.Text = sqlReader["ADSOYAD"].ToString();
                txtTcKimlik.Text = sqlReader["TC_NO"].ToString();
                txtIl.Text = sqlReader["IL"].ToString();
                txtIlce.Text = sqlReader["ILCE"].ToString();
                txtVergiDaire.Text = sqlReader["VERGI_DAIRE"].ToString();
                txtVergiNo.Text = sqlReader["VERGI_NO"].ToString();
                txtEposta.Text = sqlReader["EPOSTA"].ToString();
                txtTelefonNo.Text = sqlReader["TEL_NO"].ToString();
                txtFaxNo.Text = sqlReader["FAX_NO"].ToString();
                txtAdres.Text = sqlReader["ADRES"].ToString();
                if (bool.Parse(sqlReader["CARI_DURUM"].ToString()))
                {
                    hesapDurumuAktif.Checked = true;
                    hesapDurumuPasif.Checked = false;
                }
                else
                {
                    hesapDurumuAktif.Checked = false;
                    hesapDurumuPasif.Checked = true;
                }

            }
            catch (Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
            }
        }
    }
}
