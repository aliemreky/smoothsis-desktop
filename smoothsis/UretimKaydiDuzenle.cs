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
    public partial class UretimKaydiDuzenle : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter dataAdapter;
        private int uretimIncKey, secilenSiparisDetayIncKey = -1;

        public UretimKaydiDuzenle(int uretimIncKey)
        {
            this.uretimIncKey = uretimIncKey;
            InitializeComponent();
        }

        private void UretimKaydiDuzenle_Load(object sender, EventArgs e)
        {
            txtUretimMik.Text = "0,000";           

            try
            {
                string siparisBilgileriSQL = "SELECT SIPARIS_KOD, PROJE_KOD, PROJE_ADI, SIP_TARIH, TESLIM_TARIH, SIPARIS_TIPI, C.CARI_KOD, ADSOYAD, CONCAT(C.IL,' / ',C.ILCE) AS IL_ILCE FROM SIPARIS SP " +
                                             "JOIN CARI C ON C.CARI_INCKEY = SP.CARI_KOD " +
                                             "JOIN SIPARIS_DETAY SPDT ON SPDT.SIPARIS_INCKEY= SP.SIPARIS_INCKEY " +
                                             "JOIN URETIM UR ON UR.SIP_DETAY_INCKEY=SPDT.SIP_DETAY_INCKEY " +
                                             "WHERE UR.UR_INCKEY=@uretim_inckey";
                SqlCmd = new SqlCommand(siparisBilgileriSQL, Program.connection);
                SqlCmd.Parameters.AddWithValue("@uretim_inckey", uretimIncKey);
                SqlDataReader dataReader = SqlCmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    txtSiparisKodu.Text = dataReader["SIPARIS_KOD"].ToString();
                    txtProjeKodu.Text = dataReader["PROJE_KOD"].ToString();
                    txtProjeAdi.Text = dataReader["PROJE_ADI"].ToString();
                    txtSiparisTarihi.Text = dataReader["SIP_TARIH"].ToString();
                    txtTeslimTarih.Text = dataReader["TESLIM_TARIH"].ToString();
                    txtSiparisTipi.Text = dataReader["SIPARIS_TIPI"].ToString();
                    txtCariKodu.Text = dataReader["CARI_KOD"].ToString();
                    txtCariAdiSoyadi.Text = dataReader["ADSOYAD"].ToString();
                    txtIlIlce.Text = dataReader["IL_ILCE"].ToString();

                    cbBirim.DataSource = Enum.GetNames(typeof(Services.Enums.MalzemeMiktarBirim));
                    cbBirim.SelectedIndex = 0;

                    string stokListSQL = "SELECT SPDT.SIP_DETAY_INCKEY, STOK_KOD, STOK_ADI, DEPO_ADI, CONCAT(SPDT.MIKTAR, ' ', SPDT.MIKTAR_BIRIM) AS MIKTAR FROM STOK_DEPO STD " +
                        "JOIN STOK ST ON ST.STOK_INCKEY = STD.STOK_INCKEY " +
                        "JOIN SIPARIS_DETAY SPDT ON SPDT.STOK_DEPO_INCKEY = STD.STOK_DEPO_INCKEY " +
                        "JOIN DEPO D ON D.DEPO_INCKEY = STD.DEPO_INCKEY " +
                        "JOIN URETIM UR ON UR.SIP_DETAY_INCKEY = SPDT.SIP_DETAY_INCKEY " +
                        "WHERE UR.UR_INCKEY = @uretim_inckey";
                    SqlCmd = new SqlCommand(stokListSQL, Program.connection);
                    SqlCmd.Parameters.AddWithValue("@uretim_inckey", uretimIncKey);
                    DataTable stokListTable = new DataTable();
                    dataAdapter = new SqlDataAdapter(SqlCmd);
                    dataAdapter.Fill(stokListTable);

                    stokListGridView.DataSource = stokListTable;
                    stokListGridView.Columns[0].Visible = false;
                    Styler.gridViewCommonStyle(stokListGridView);

                    stokListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    stokListGridView.Rows.Clear();
                    stokListGridView.Refresh();

                    string makineListesiSQL = "SELECT CONCAT(MAK_INCKEY, ' - ', MAK_ADI) AS MAKINE FROM MAKINE";
                    SqlCmd = new SqlCommand(makineListesiSQL, Program.connection);
                    SqlDataReader sqlMakineReader = SqlCmd.ExecuteReader();
                    if (sqlMakineReader.HasRows)
                        while (sqlMakineReader.Read())
                            cbMakine.Items.Add(sqlMakineReader["MAKINE"].ToString());


                    string islemListesiSQL = "SELECT CONCAT(ISLEM_INCKEY, ' - ', ISLEM_ADI) AS ISLEM FROM ISLEM";
                    SqlCmd = new SqlCommand(islemListesiSQL, Program.connection);
                    SqlDataReader sqlIslemReader = SqlCmd.ExecuteReader();
                    if (sqlIslemReader.HasRows)
                        while (sqlIslemReader.Read())
                            cbIslem.Items.Add(sqlIslemReader["ISLEM"].ToString());

                    cbMakine.SelectedIndex = 0;
                    cbIslem.SelectedIndex = 0;

                    string uretimListesiSQL = "SELECT SIP_DETAY_INCKEY, ISL.ISLEM_ADI, MAK.MAK_ADI, ISLEM_NO, PLAN_URET_MIK, BIRIM, URET_TARIH, UR.ACIKLAMA FROM URETIM UR" +
                        "JOIN ISLEM ISL ON ISL.ISLEM_INCKEY = UR.ISLEM_INCKEY " +
                        "JOIN MAKINE MAK ON MAK.MAK_INCKEY = UR.MAKINE_INCKEY " +
                        "WHERE UR.UR_INCKEY = @uretim_inckey";
                    SqlCmd = new SqlCommand(uretimListesiSQL, Program.connection);
                    SqlCmd.Parameters.AddWithValue("@uretim_inckey", uretimIncKey);

                    DataTable uretimListDataTable = new DataTable();
                    dataAdapter = new SqlDataAdapter(SqlCmd);
                    dataAdapter.Fill(uretimListDataTable);

                    uretimListesiGridView.DataSource = uretimListDataTable;
                    uretimListesiGridView.Columns[0].Visible = false;
                    Styler.gridViewCommonStyle(uretimListesiGridView);

                    uretimListesiGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
                this.Close();
            }
        }        

        private void txtUretimMik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void txtUretimMik_Leave(object sender, EventArgs e)
        {
            try
            {
                txtUretimMik.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtUretimMik.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMAT GİRİLDİ");
                txtUretimMik.Focus();
            }
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (uretimListesiGridView.Rows.Count > 0)
            {
                string uretimKaydetSQL = "INSERT INTO URETIM(SIP_DETAY_INCKEY, ISLEM_INCKEY, MAKINE_INCKEY, ISLEM_NO, PLAN_URET_MIK, BIRIM, URET_TARIH, ACIKLAMA, KAYIT_YAPAN_KUL) " +
                    "VALUES (@sip_detay_inckey, @islem_inckey, @makine_inckey, @islem_no, @plan_uret_mik, @birim, @uret_tarih, @aciklama, @kayit_yapan_kul)";

                for (int rowIndex = 0; rowIndex < uretimListesiGridView.Rows.Count; rowIndex++)
                {

                    SqlCmd = new SqlCommand(uretimKaydetSQL, Program.connection);
                    SqlCmd.Parameters.Add("@sip_detay_inckey", SqlDbType.Int).Value = uretimListesiGridView["SIP_DETAY_INCKEY", rowIndex].Value.ToString();
                    SqlCmd.Parameters.Add("@islem_inckey", SqlDbType.Int).Value = uretimListesiGridView["ISLEM", rowIndex].Value.ToString().Split('-')[0].Trim();
                    SqlCmd.Parameters.Add("@makine_inckey", SqlDbType.Int).Value = uretimListesiGridView["MAKINE", rowIndex].Value.ToString().Split('-')[0].Trim();
                    SqlCmd.Parameters.Add("@islem_no", SqlDbType.Int).Value = uretimListesiGridView["ISLEM_NO", rowIndex].Value.ToString();
                    SqlCmd.Parameters.Add("@plan_uret_mik", SqlDbType.Decimal).Value = decimal.Parse(uretimListesiGridView["MIKTAR", rowIndex].Value.ToString());
                    SqlCmd.Parameters.Add("@birim", SqlDbType.VarChar).Value = uretimListesiGridView["BIRIM", rowIndex].Value.ToString();
                    SqlCmd.Parameters.Add("@uret_tarih", SqlDbType.Date).Value = DateTime.Parse(uretimListesiGridView["URETIM_TARIH", rowIndex].Value.ToString());
                    SqlCmd.Parameters.Add("@aciklama", SqlDbType.Text).Value = uretimListesiGridView["ACIKLAMA", rowIndex].Value.ToString();
                    SqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    SqlCmd.ExecuteNonQuery();
                }

                Notification.messageBox("Üretim Kaydı Başarıyla Oluşturuldu !");

            }
            else
            {
                Notification.messageBoxError("LÜTFEN LİSTEYE ÜRETİM KAYDI EKLEYİN !");
            }
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtSiparisKodu.Text) ||
               String.IsNullOrEmpty(cbMakine.SelectedItem.ToString()) ||
               String.IsNullOrEmpty(cbIslem.SelectedItem.ToString()) ||
               String.IsNullOrEmpty(cbBirim.SelectedItem.ToString()) ||
               String.IsNullOrEmpty(txtUretimMik.Text))
            {
                Notification.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKILMAMALI !");
            }
            else
            {
                if ((decimal.Parse(txtUretimMik.Text) > 0) && (secilenSiparisDetayIncKey > 0))
                {
                    string islem = cbIslem.SelectedItem.ToString();
                    string makine = cbMakine.SelectedItem.ToString();
                    string birim = cbBirim.SelectedItem.ToString();
                    int islemNo = uretimListesiGridView.Rows.Count + 1;
                    string miktar = txtUretimMik.Text;
                    string uretimTarih = dateTimeUretimTarih.Value.ToString("dd.MM.yyyy");
                    string aciklama = txtAciklama.Text;

                    uretimListesiGridView.Rows.Add(secilenSiparisDetayIncKey, islem, makine, islemNo, miktar, birim, uretimTarih, aciklama);
                    this.uretimListesiGridView.Sort(this.uretimListesiGridView.Columns["ISLEM_NO"], ListSortDirection.Ascending);

                    txtUretimMik.Text = "0,000";
                    txtAciklama.Text = "";
                }

            }
        }

        private void uretimListesiGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                if (uretimListesiGridView.SelectedRows.Count == 1)
                {
                    int removeIndex = uretimListesiGridView.SelectedRows[0].Index;

                    uretimListesiGridView.Rows.RemoveAt(removeIndex);
                }
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void stokListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(stokListGridView.Rows.Count > 0)
            {
                if(e.RowIndex != -1 && e.ColumnIndex != -1)
                {

                    secilenSiparisDetayIncKey = int.Parse(stokListGridView["SIP_DETAY_INCKEY", e.RowIndex].Value.ToString());
                    Notification.messageBox("SEÇİLEN STOK: \n" + stokListGridView["STOK_KOD", e.RowIndex].Value.ToString() + " - " + stokListGridView["STOK_ADI", e.RowIndex].Value.ToString());
                    // stokListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    // stokListGridView.ClearSelection();

                }
            }
        }
    }
}
