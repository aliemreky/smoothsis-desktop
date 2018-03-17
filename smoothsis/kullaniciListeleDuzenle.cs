using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using smoothsis.Services;

namespace smoothsis
{
    public partial class KullaniciListeleDuzenle : Form
    {
        // item1 is e.RowIndex, item2 is kullaniciIncKey
        private Tuple<int, int> selectedItem;

        public KullaniciListeleDuzenle()
        {
            InitializeComponent();
        }

        private void KullaniciListeleDuzenle_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(kullaniciListesiGridView);
            cbGrupKey.DataSource = KullaniciOlustur.getGrupDataTableForBindToComboBox();
            cbGrupKey.DisplayMember = "GRUP_ADI";
            cbGrupKey.ValueMember = "GRUP_INCKEY";
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
                kullaniciListesiGridView.Columns[0].Visible = false;
                kullaniciListesiGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        private void silBttn_Click(object sender, EventArgs e)
        {
            if (kullaniciListesiGridView.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "UYARI", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int kullaniciId = Int32.Parse(kullaniciListesiGridView.SelectedRows[0].Cells[0].Value.ToString());
                        SqlCommand command = new SqlCommand("DELETE FROM KULLANICI WHERE KUL_INCKEY = @kul_inckey", Program.connection);
                        command.Parameters.Add("@kul_inckey", SqlDbType.Int).Value = kullaniciId;
                        int affectedRows = command.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            kullaniciListesiGridView.Rows.RemoveAt(selectedItem.Item1);
                            ActionControl.ActionAllControls(this, "clear");
                            textTemizle();
                            Notification.messageBox("Kullanıcı silindi.");
                        }
                        else
                        {
                            Notification.messageBoxError("Bir sorun oluştu, grup silinemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Source);
                }
            }
        }
        
        private void fillDataToTextBoxs(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, int>(e.RowIndex, Int32.Parse(kullaniciListesiGridView[0, e.RowIndex].Value.ToString()));
                cbGrupKey.SelectedIndex = cbGrupKey.FindString(kullaniciListesiGridView[1, selectedItem.Item1].Value.ToString());
                txtAdSoyad.Text = kullaniciListesiGridView[2, selectedItem.Item1].Value.ToString();
                txtSifre.Text = kullaniciListesiGridView[3, selectedItem.Item1].Value.ToString();
                txtTelefon.Text = kullaniciListesiGridView[4, selectedItem.Item1].Value.ToString();
                txtEmail.Text = kullaniciListesiGridView[5, selectedItem.Item1].Value.ToString();
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
                    command.Parameters.Add("@kul_inckey", SqlDbType.Int).Value = selectedItem.Item2;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Notification.messageBox("Kullanıcı güncellendi.");
                        kullaniciListesiGridView[1, selectedItem.Item1].Value = grupAd;
                        kullaniciListesiGridView[2, selectedItem.Item1].Value = adSoyad;
                        kullaniciListesiGridView[3, selectedItem.Item1].Value = sifre;
                        kullaniciListesiGridView[4, selectedItem.Item1].Value = telefon;
                        kullaniciListesiGridView[5, selectedItem.Item1].Value = email;
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, Kullanıcı güncellenemedi.");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
            else
            {
                Notification.messageBox("Lütfen zorunlu alanları boş geçmeyin.");
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

        private void checkIsTel(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForNumericWithSpace(sender, e);
        }
    }
}
