using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using smoothsis.Services;

namespace smoothsis
{
    public partial class KullaniciOlustur : Form
    {
        public KullaniciOlustur()
        {
            InitializeComponent();
        }

        private void KullaniciOlustur_Load(object sender, EventArgs e)
        {
            cbGrupKey.DataSource = getGrupDataTableForBindToComboBox();
            cbGrupKey.DisplayMember = "GRUP_ADI";
            cbGrupKey.ValueMember = "GRUP_INCKEY";
        }

        public static DataTable getGrupDataTableForBindToComboBox()
        {
            string query = "SELECT * FROM GRUP";
            SqlCommand command = new SqlCommand(query, Program.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            int grupInckey = (int)cbGrupKey.SelectedValue;
            string adSoyad = txtAdSoyad.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (!String.IsNullOrEmpty(adSoyad) && !String.IsNullOrEmpty(sifre))
            {
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO KULLANICI(GRUP_INCKEY, ADSOYAD, SIFRE, TEL_NO, EMAIL)" +
                        " VALUES(@grup_inckey, @adsoyad, @sifre, @tel_no, @email)", Program.connection);
                    command.Parameters.Add("@grup_inckey", SqlDbType.Int).Value = grupInckey;
                    command.Parameters.Add("@adsoyad", SqlDbType.VarChar).Value = adSoyad;
                    command.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;
                    command.Parameters.Add("@tel_no", SqlDbType.VarChar).Value = telefon;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Program.controllerClass.messageBox("Kullanıcı oluşturuldu.");
                        this.Close();
                    } else
                    {
                        Program.controllerClass.messageBoxError("Bir sorun oluştu, Kullanıcı oluşturulamadı.");
                    }
                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }
            } else
            {
                Program.controllerClass.messageBox("Lütfen zorunlu alanları boş geçmeyin.");
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtSifre.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
        }

        private void checkIsTel(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForNumericWithSpace(sender, e);
        }
    }
}
