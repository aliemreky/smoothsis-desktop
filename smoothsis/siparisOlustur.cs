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
    public partial class siparisOlustur : Form
    {
        private SqlCommand sqlCmd;

        public siparisOlustur()
        {
            InitializeComponent();
        }

        private void siparisOlustur_Load(object sender, EventArgs e)
        {
            siparisTipi.SelectedIndex = 0;
            txtSiparisTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtSiparisTeslimTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
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

            cariListesi cariList = new cariListesi(1);
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
    }
}
