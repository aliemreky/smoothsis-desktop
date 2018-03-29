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
    public partial class Login : Form
    {
        private SqlCommand sqlCmd;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            sirketCombo.Items.Add("SMOOTHSIS2018");
            sirketCombo.SelectedIndex = 0;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                String.IsNullOrEmpty(txtSifre.Text))
            {
                Notification.messageBoxError("KULLANICI ADI VEYA ŞİFRE ALANLARINI BOŞ BIRAKMAYINIZ !");

            }
            else
            {
                bool loginControl = false;

                try
                {                    
                    sqlCmd = new SqlCommand("SELECT * FROM KULLANICI WHERE ADSOYAD=@adsoyad AND SIFRE=@sifre", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@adsoyad", txtKullaniciAdi.Text.ToLower());
                    sqlCmd.Parameters.AddWithValue("@sifre", txtSifre.Text.ToLower());

                    SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                    if (sqlRead.HasRows)
                    {

                        sqlRead.Read();
                        Program.kullanici = new Tuple<int, string>(Convert.ToInt32(sqlRead["KUL_INCKEY"].ToString()), sqlRead["ADSOYAD"].ToString().ToLower());
                        sqlRead.Close();

                        Program.sirket = sirketCombo.SelectedItem.ToString();
                        loginControl = true;

                    }
                    else
                        Notification.messageBoxError("KULLANICI ADI VEYA ŞİFRE YANLIŞ !");

                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }

                if (loginControl)
                {
                    Main anasayfa = new Main();
                    anasayfa.ShowDialog();
                }

            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                btnGirisYap.PerformClick();
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                btnGirisYap.PerformClick();
        }
    }
}
