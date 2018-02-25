using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace smoothsis
{
    public partial class kullaniciListeleDuzenle : Form
    {
        private int kullaniciInckey;
        private int rowIndex;

        public kullaniciListeleDuzenle()
        {
            InitializeComponent();
        }

        private void kullaniciListeleDuzenle_Load(object sender, EventArgs e)
        {
            Program.controllerClass.gridViewCommonStyle(kullaniciListesiGridView);
            listKullanici();
        }

        private void listKullanici()
        {
            try
            {
                DataTable kullaniciListDTable = new DataTable();

                string query = "SELECT " +
                    "K.KUL_INCKEY AS KULLANICI_ID, G.GRUP_ADI, K.ADSOYAD, K.SIFRE, K.TEL_NO, K.EMAIL " +
                    "FROM KULLANICI K INNER JOIN GRUP G ON " +
                    "K.GRUP_INCKEY = G.GRUP_INCKEY ORDER BY K.KUL_INCKEY DESC";

                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(kullaniciListDTable);
                kullaniciListesiGridView.DataSource = kullaniciListDTable;
                kullaniciListesiGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
            }

        }

        private void silBttn_Click(object sender, EventArgs e)
        {
            if (kullaniciListesiGridView.SelectedRows.Count == 1)
            {
                try
                {
                    int kullaniciId = Int32.Parse(kullaniciListesiGridView.SelectedRows[0].Cells[0].Value.ToString());
                    SqlCommand command = new SqlCommand("DELETE FROM KULLANICI WHERE KUL_INCKEY = @kul_inckey", Program.connection);
                    command.Parameters.Add("@kul_inckey", SqlDbType.Int).Value = kullaniciId;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        kullaniciListesiGridView.Rows.RemoveAt(rowIndex);
                        Program.controllerClass.ActionAllControls(this, "clear");
                        textTemizle();
                        Program.controllerClass.messageBox("Kullanıcı silindi.");
                    }
                    else
                    {
                        Program.controllerClass.messageBoxError("Bir sorun oluştu, grup silinemedi.");
                    }
                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Source);
                }
            }
        }
        
        private void fillDataToTextBoxs(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex != -1)
            {
                kullaniciInckey = Int32.Parse(kullaniciListesiGridView[0, rowIndex].Value.ToString());
                cbGrupKey.SelectedIndex = cbGrupKey.FindString(kullaniciListesiGridView[1, rowIndex].Value.ToString());
                txtAdSoyad.Text = kullaniciListesiGridView[2, rowIndex].Value.ToString();
                txtSifre.Text = kullaniciListesiGridView[3, rowIndex].Value.ToString();
                txtTelefon.Text = kullaniciListesiGridView[4, rowIndex].Value.ToString();
                txtEmail.Text = kullaniciListesiGridView[5, rowIndex].Value.ToString();
            }
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            int grupInckey = (int)cbGrupKey.SelectedValue;
            string grupAd = cbGrupKey.Text;
            string adSoyad = txtAdSoyad.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (!String.IsNullOrEmpty(adSoyad) && !String.IsNullOrEmpty(sifre))
            {
                try
                {
                    string query = "UPDATE KULLANICI SET " +
                        "GRUP_INCKEY = @grup_inckey, ADSOYAD = @adsoyad," +
                        " SIFRE = @sifre, TEL_NO = @tel_no, EMAIL = @email WHERE KUL_INCKEY = @kul_inckey";
                    SqlCommand command = new SqlCommand(query, Program.connection);
                    command.Parameters.Add("@grup_inckey", SqlDbType.Int).Value = grupInckey;
                    command.Parameters.Add("@adsoyad", SqlDbType.VarChar).Value = adSoyad;
                    command.Parameters.Add("@sifre", SqlDbType.VarChar).Value = sifre;
                    command.Parameters.Add("@tel_no", SqlDbType.VarChar).Value = telefon;
                    command.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    command.Parameters.Add("@kul_inckey", SqlDbType.Int).Value = kullaniciInckey;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Program.controllerClass.messageBox("Kullanıcı güncellendi.");
                        kullaniciListesiGridView[1, rowIndex].Value = grupAd;
                        kullaniciListesiGridView[2, rowIndex].Value = adSoyad;
                        kullaniciListesiGridView[3, rowIndex].Value = sifre;
                        kullaniciListesiGridView[4, rowIndex].Value = telefon;
                        kullaniciListesiGridView[5, rowIndex].Value = email;
                    }
                    else
                    {
                        Program.controllerClass.messageBoxError("Bir sorun oluştu, Kullanıcı güncellenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
                }
            }
            else
            {
                Program.controllerClass.messageBox("Lütfen zorunlu alanları boş geçmeyin.");
            }
        }

        private void textTemizle()
        {
            txtAdSoyad.Clear();
            txtSifre.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
