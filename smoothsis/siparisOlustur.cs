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
    public partial class SiparisOlustur : Form
    {
        private SqlCommand sqlCmd;

        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            siparisTipi.SelectedIndex = 0;
            txtSiparisTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtSiparisTeslimTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");

            siparisListesiGridView.ColumnCount = 5;

            siparisListesiGridView.Columns[0].Name = "STOK_INCKEY";
            siparisListesiGridView.Columns[1].Name = "STOK_ADI";
            siparisListesiGridView.Columns[2].Name = "MIKTAR";
            siparisListesiGridView.Columns[3].Name = "BIRIM_FIYAT";
            siparisListesiGridView.Columns[4].Name = "TUTAR";
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Program.controllerClass.ActionAllControls(groupBox1, "clear");
            Program.controllerClass.ActionAllControls(groupBox2, "clear");
            Program.controllerClass.ActionAllControls(groupBox3, "clear");
        }

        private void btnSiparisKoduOlustur_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSiparisKodu.Text))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT TOP 1 SIPARIS_INCKEY FROM SIPARIS ORDER BY SIPARIS_INCKEY DESC", Program.connection);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtSiparisKodu.Text = "SP" +  (int.Parse(sqlReader["SIPARIS_INCKEY"].ToString()) + 1).ToString("D10");
                        sqlReader.Close();

                    }
                    else
                        txtSiparisKodu.Text = "SP0000000001";
                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }
            }
        }

        private void txtCariKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT ADSOYAD, TICARI_UNVAN, IL, ILCE FROM CARI WHERE CARI_KOD=@cari_kod", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_kod", txtCariKod.Text.Trim());
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtCariIsim.Text    = sqlReader["ADSOYAD"].ToString().ToUpper();
                        txtTicariUnvan.Text = sqlReader["TICARI_UNVAN"].ToString().ToUpper();
                        txtIlIlce.Text      = sqlReader["IL"].ToString().ToUpper() + " / " + sqlReader["ILCE"].ToString().ToUpper();
                        sqlReader.Close();
                    }
                    else
                    {
                        Program.controllerClass.messageBoxError("KAYIT BULUNAMADI");
                    }
                }catch(Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }
            }
        }

        private void btnCariListeAc_Click(object sender, EventArgs e)
        {

            CariListesi cariList = new CariListesi(1);
            cariList.ShowDialog();
            try
            {
                Tuple<int, string> secilenCari = cariList.passingCari;

                if (secilenCari != null)
                {
                    txtCariKod.Text = secilenCari.Item2;


                    sqlCmd = new SqlCommand("SELECT ADSOYAD, TICARI_UNVAN, IL, ILCE FROM CARI WHERE CARI_INCKEY=@cari_inckey", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_inckey", secilenCari.Item1);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtCariIsim.Text = sqlReader["ADSOYAD"].ToString().ToUpper();
                        txtTicariUnvan.Text = sqlReader["TICARI_UNVAN"].ToString().ToUpper();
                        txtIlIlce.Text = sqlReader["IL"].ToString().ToUpper() + " / " + sqlReader["ILCE"].ToString().ToUpper();
                        sqlReader.Close();
                    }
                }
            }catch(Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
            }
        }

        private void txtSiparisTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != '.'))
                e.Handled = true;
            else
                if ((sender as TextBox).Text.Count(Char.IsDigit) > 10 && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        private void txtSiparisTeslimTarih_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != '.'))
                e.Handled = true;
            else
                if ((sender as TextBox).Text.Count(Char.IsDigit) > 10 && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        private void txtStokKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT STOK_INCKEY, STOK_KOD, STOK_ADI, MIKTAR_BIRIM, BIRIM_FIYAT FROM STOK WHERE STOK_KOD=@stok_kod", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@stok_kod", txtStokKodu.Text.Trim());
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtStokAdi.Text = sqlReader["STOK_ADI"].ToString().ToUpper();
                        txtStokBirim.Text = sqlReader["MIKTAR_BIRIM"].ToString().ToUpper();
                        txtBirimFiyat.Text = sqlReader["BIRIM_FIYAT"].ToString().ToUpper();
                        sqlReader.Close();
                    }
                    else
                    {
                        Program.controllerClass.messageBoxError("KAYIT BULUNAMADI");
                    }
                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }
            }
        }

        private void txtStokMiktar_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBirimFiyat.Text) && !String.IsNullOrEmpty(txtStokMiktar.Text))
            {
                decimal toplamFiyat = decimal.Parse(txtStokMiktar.Text.Trim()) * decimal.Parse(txtBirimFiyat.Text.Trim());
                txtToplamFiyat.Text = toplamFiyat.ToString("#.####");
            }
        }

        private void txtStokMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStokKodu.Text))
            {
                Program.controllerClass.messageBoxError("STOK SEÇİNİZ");
            }
            else
            {
                // siparisListesiGridView.Rows.Add();
            }
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {

        }
    }
}
