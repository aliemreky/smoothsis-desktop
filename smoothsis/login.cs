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
    public partial class login : Form
    {
        private SqlCommand sqlCmd;

        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            sirketCombo.Items.Add("SMOOTHSIS2018");
            sirketCombo.SelectedIndex = 0;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                String.IsNullOrEmpty(txtSifre.Text))
            {
                Program.controllerClass.messageBoxError("KULLANICI ADI VEYA ŞİFRE ALANLARINI BOŞ BIRAKMAYINIZ !");

            }
            else
            {

                sqlCmd = new SqlCommand("SELECT * FROM KULLANICI WHERE ADSOYAD=@adsoyad AND SIFRE=@sifre", Program.connection);
                sqlCmd.Parameters.AddWithValue("@adsoyad", txtKullaniciAdi.Text.ToLower());
                sqlCmd.Parameters.AddWithValue("@sifre", txtSifre.Text.ToLower());

                SqlDataReader sqlRead = sqlCmd.ExecuteReader();

                if (sqlRead.HasRows)
                {
                    try
                    {
                        sqlRead.Read();
                        Program.kullanici = new Tuple<int, string>(Convert.ToInt32(sqlRead["KUL_INCKEY"].ToString()), sqlRead["ADSOYAD"].ToString().ToLower());
                        sqlRead.Close();
                    }
                    catch (Exception ex)
                    {
                        Program.controllerClass.messageBoxError(ex.Message);
                    }

                    Program.sirket = sirketCombo.SelectedItem.ToString();
                    main anasayfa = new main();
                    anasayfa.ShowDialog();                    

                }
                else
                    Program.controllerClass.messageBoxError("KULLANICI ADI VEYA ŞİFRE YANLIŞ !");


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
