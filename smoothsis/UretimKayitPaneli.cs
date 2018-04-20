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
using System.Collections;

namespace smoothsis
{
    public partial class UretimKayitPaneli : Form
    {
        private SqlCommand SqlCmd;
        private SqlDataAdapter dataAdapter;
        private int siparisIncKey, secilenSiparisDetayIncKey = -1, selectedItemIndex;
        private bool guncellemeDurumu, uretimAdimiGuncelle = false;
        private DataTable uretimListDataTable;
        private ArrayList deletedItems = new ArrayList();

        public UretimKayitPaneli(int siparisIncKey, bool guncellemeDurumu)
        {
            this.siparisIncKey = siparisIncKey;
            this.guncellemeDurumu = guncellemeDurumu;
            InitializeComponent();
        }

        private void UretimKaydiOlustur_Load(object sender, EventArgs e)
        {
            groupBox3.Enabled = false;
            txtUretimMik.Text = "0,000";

            stokListGridView.Rows.Clear();
            stokListGridView.Refresh();

            try
            {
                string siparisBilgileriSQL = "SELECT SIPARIS_KOD, PROJE_KOD, PROJE_ADI, SIP_TARIH, TESLIM_TARIH, SIPARIS_TIPI, C.CARI_KOD, ADSOYAD, CONCAT(C.IL,' / ',C.ILCE) AS IL_ILCE FROM SIPARIS SP JOIN CARI C ON C.CARI_INCKEY = SP.CARI_KOD WHERE SP.SIPARIS_INCKEY=@siparis_inckey";
                SqlCmd = new SqlCommand(siparisBilgileriSQL, Program.connection);
                SqlCmd.Parameters.AddWithValue("@siparis_inckey", siparisIncKey);
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

                    string stokListSQL = "SELECT SIPDT.SIP_DETAY_INCKEY, STOK_KOD, STOK_ADI, DEPO_ADI, CONCAT(SIPDT.MIKTAR, ' ', SIPDT.MIKTAR_BIRIM) AS MIKTAR FROM STOK_DEPO STD JOIN STOK ST ON ST.STOK_INCKEY = STD.STOK_INCKEY JOIN SIPARIS_DETAY SIPDT ON SIPDT.STOK_DEPO_INCKEY = STD.STOK_DEPO_INCKEY JOIN DEPO D ON D.DEPO_INCKEY = STD.DEPO_INCKEY WHERE SIPDT.SIPARIS_INCKEY = @siparis_inckey";
                    SqlCmd = new SqlCommand(stokListSQL, Program.connection);
                    SqlCmd.Parameters.AddWithValue("@siparis_inckey", siparisIncKey);
                    DataTable stokListTable = new DataTable();
                    dataAdapter = new SqlDataAdapter(SqlCmd);
                    dataAdapter.Fill(stokListTable);

                    stokListGridView.DataSource = stokListTable;
                    stokListGridView.Columns[0].Visible = false;
                    Styler.gridViewCommonStyle(stokListGridView);
                    stokListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

                    if (guncellemeDurumu)
                    {
                        string uretimListesiSQL = "SELECT UR.UR_INCKEY, SPDT.SIP_DETAY_INCKEY, CONCAT(ISL.ISLEM_INCKEY, ' - ', ISL.ISLEM_ADI) AS ISLEM, CONCAT(MAK.MAK_INCKEY, ' - ', MAK.MAK_ADI) AS MAKINE, ISLEM_NO, PLAN_URET_MIK AS MIKTAR, BIRIM, URET_TARIH AS URETIM_TARIH, UR.ACIKLAMA FROM URETIM UR " +
                        "JOIN ISLEM ISL ON ISL.ISLEM_INCKEY = UR.ISLEM_INCKEY " +
                        "JOIN MAKINE MAK ON MAK.MAK_INCKEY = UR.MAKINE_INCKEY " +
                        "JOIN SIPARIS_DETAY SPDT ON SPDT.SIP_DETAY_INCKEY = UR.SIP_DETAY_INCKEY " +
                        "WHERE SPDT.SIPARIS_INCKEY = @siparis_inckey";
                        SqlCmd = new SqlCommand(uretimListesiSQL, Program.connection);
                        SqlCmd.Parameters.AddWithValue("@siparis_inckey", siparisIncKey);

                        uretimListDataTable = new DataTable();
                        dataAdapter = new SqlDataAdapter(SqlCmd);
                        dataAdapter.Fill(uretimListDataTable);

                        uretimListesiGridView.DataSource = uretimListDataTable;
                        uretimListesiGridView.Columns[0].Visible = false;
                        uretimListesiGridView.Columns[1].Visible = false;
                    }
                    else
                    {
                        uretimListesiGridView.ColumnCount = 9;
                        uretimListesiGridView.Columns[0].Name = "UR_INCKEY";
                        uretimListesiGridView.Columns[1].Name = "SIP_DETAY_INCKEY";
                        uretimListesiGridView.Columns[2].Name = "ISLEM";
                        uretimListesiGridView.Columns[3].Name = "MAKINE";
                        uretimListesiGridView.Columns[4].Name = "ISLEM_NO";
                        uretimListesiGridView.Columns[5].Name = "MIKTAR";
                        uretimListesiGridView.Columns[6].Name = "BIRIM";
                        uretimListesiGridView.Columns[7].Name = "URETIM_TARIH";
                        uretimListesiGridView.Columns[8].Name = "ACIKLAMA";

                        uretimListesiGridView.Columns[0].Visible = false;
                        uretimListesiGridView.Columns[1].Visible = false;

                        uretimListesiGridView.Rows.Clear();
                        uretimListesiGridView.Refresh();
                    }

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
            TextValidate.forceForDecimal(sender, e);
        }

        private void txtUretimMik_Leave(object sender, EventArgs e)
        {
            try
            {
                txtUretimMik.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtUretimMik.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMATTA DEĞER GİRİLDİ");
                txtUretimMik.Focus();
            }
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (uretimListesiGridView.Rows.Count > 0)
            {
                if (!guncellemeDurumu)
                {
                    try
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
                    catch (Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }

                }
                else
                {
                    try
                    {

                        string uretimGuncelleSQL = "UPDATE URETIM SET " +
                            "SIP_DETAY_INCKEY=@sip_detay_inckey, ISLEM_INCKEY=@islem_inckey, MAKINE_INCKEY=@makine_inckey, ISLEM_NO=@islem_no, PLAN_URET_MIK=@plan_uret_mik, BIRIM=@birim, URET_TARIH=@uret_tarih, ACIKLAMA=@aciklama, DUZELTME_YAPAN_KUL=@duzelt_yapan_kul, DUZELTME_TARIH=GETDATE() " +
                            "WHERE UR_INCKEY = @ur_inckey";

                        string uretimKaydetSQL = "INSERT INTO URETIM(SIP_DETAY_INCKEY, ISLEM_INCKEY, MAKINE_INCKEY, ISLEM_NO, PLAN_URET_MIK, BIRIM, URET_TARIH, ACIKLAMA, KAYIT_YAPAN_KUL) " +
                            "VALUES (@sip_detay_inckey, @islem_inckey, @makine_inckey, @islem_no, @plan_uret_mik, @birim, @uret_tarih, @aciklama, @kayit_yapan_kul)";

                        for (int rowIndex = 0; rowIndex < uretimListesiGridView.Rows.Count; rowIndex++)
                        {

                            string uretimInckey = uretimListesiGridView["UR_INCKEY", rowIndex].Value.ToString();

                            if (!String.IsNullOrEmpty(uretimInckey))
                            {
                                SqlCmd = new SqlCommand(uretimGuncelleSQL, Program.connection);
                                SqlCmd.Parameters.Add("@sip_detay_inckey", SqlDbType.Int).Value = uretimListesiGridView["SIP_DETAY_INCKEY", rowIndex].Value.ToString();
                                SqlCmd.Parameters.Add("@islem_inckey", SqlDbType.Int).Value = uretimListesiGridView["ISLEM", rowIndex].Value.ToString().Split('-')[0].Trim();
                                SqlCmd.Parameters.Add("@makine_inckey", SqlDbType.Int).Value = uretimListesiGridView["MAKINE", rowIndex].Value.ToString().Split('-')[0].Trim();
                                SqlCmd.Parameters.Add("@islem_no", SqlDbType.Int).Value = uretimListesiGridView["ISLEM_NO", rowIndex].Value.ToString();
                                SqlCmd.Parameters.Add("@plan_uret_mik", SqlDbType.Decimal).Value = decimal.Parse(uretimListesiGridView["MIKTAR", rowIndex].Value.ToString());
                                SqlCmd.Parameters.Add("@birim", SqlDbType.VarChar).Value = uretimListesiGridView["BIRIM", rowIndex].Value.ToString();
                                SqlCmd.Parameters.Add("@uret_tarih", SqlDbType.Date).Value = DateTime.Parse(uretimListesiGridView["URETIM_TARIH", rowIndex].Value.ToString());
                                SqlCmd.Parameters.Add("@aciklama", SqlDbType.Text).Value = uretimListesiGridView["ACIKLAMA", rowIndex].Value.ToString();
                                SqlCmd.Parameters.Add("@duzelt_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                                SqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = int.Parse(uretimListesiGridView["UR_INCKEY", rowIndex].Value.ToString());
                                SqlCmd.ExecuteNonQuery();
                            }
                            else
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

                        }

                        if (deletedItems.Count > 0)
                        {
                            for (int k = 0; k < deletedItems.Count; k++)
                            {
                                string deleteSQL = "DELETE FROM URETIM WHERE UR_INCKEY=@ur_inckey";
                                SqlCmd = new SqlCommand(deleteSQL, Program.connection);
                                SqlCmd.Parameters.AddWithValue("@ur_inckey", deletedItems[k]);
                                SqlCmd.ExecuteNonQuery();
                            }

                            deletedItems.Clear();
                        }

                        Notification.messageBox("Üretim Kaydı Başarıyla Güncellendi !");

                    }
                    catch (Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }
                }

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

                    if (guncellemeDurumu)
                    {
                        if (uretimAdimiGuncelle)
                        {
                            string islem = cbIslem.SelectedItem.ToString();
                            string makine = cbMakine.SelectedItem.ToString();
                            string birim = cbBirim.SelectedItem.ToString();
                            string islemNo = uretimListesiGridView["ISLEM_NO", selectedItemIndex].Value.ToString();
                            string miktar = txtUretimMik.Text;
                            string uretimTarih = dateTimeUretimTarih.Value.ToString("dd.MM.yyyy");
                            string aciklama = txtAciklama.Text;
                            string uretimInckey = uretimListesiGridView["UR_INCKEY", selectedItemIndex].Value.ToString();

                            uretimListDataTable.Rows.RemoveAt(selectedItemIndex);
                            uretimListDataTable.Rows.Add(uretimInckey, secilenSiparisDetayIncKey, islem, makine, islemNo, miktar, birim, uretimTarih, aciklama);

                            uretimListesiGridView.DataSource = uretimListDataTable;
                            uretimListesiGridView.Refresh();

                            uretimAdimiGuncelle = false;
                            btnListeyeEkle.Text = "LİSTEYE EKLE";
                        }
                        else
                        {
                            string islem = cbIslem.SelectedItem.ToString();
                            string makine = cbMakine.SelectedItem.ToString();
                            string birim = cbBirim.SelectedItem.ToString();
                            int islemNo = uretimListesiGridView.Rows.Count + 1;
                            string miktar = txtUretimMik.Text;
                            string uretimTarih = dateTimeUretimTarih.Value.ToString("dd.MM.yyyy");
                            string aciklama = txtAciklama.Text;

                            uretimListDataTable.Rows.Add(null, secilenSiparisDetayIncKey, islem, makine, islemNo, miktar, birim, uretimTarih, aciklama);

                            uretimListesiGridView.DataSource = uretimListDataTable;
                            uretimListesiGridView.Refresh();
                        }

                    }
                    else
                    {
                        if (uretimAdimiGuncelle)
                        {
                            string islem = cbIslem.SelectedItem.ToString();
                            string makine = cbMakine.SelectedItem.ToString();
                            string birim = cbBirim.SelectedItem.ToString();
                            int islemNo = int.Parse(uretimListesiGridView["ISLEM_NO", selectedItemIndex].Value.ToString());
                            string miktar = txtUretimMik.Text;
                            string uretimTarih = dateTimeUretimTarih.Value.ToString("dd.MM.yyyy");
                            string aciklama = txtAciklama.Text;

                            uretimListesiGridView.Rows.Add(null, secilenSiparisDetayIncKey, islem, makine, islemNo, miktar, birim, uretimTarih, aciklama);

                            uretimAdimiGuncelle = false;
                            btnListeyeEkle.Text = "LİSTEYE EKLE";
                        }
                        else
                        {
                            string islem = cbIslem.SelectedItem.ToString();
                            string makine = cbMakine.SelectedItem.ToString();
                            string birim = cbBirim.SelectedItem.ToString();
                            int islemNo = uretimListesiGridView.Rows.Count + 1;
                            string miktar = txtUretimMik.Text;
                            string uretimTarih = dateTimeUretimTarih.Value.ToString("dd.MM.yyyy");
                            string aciklama = txtAciklama.Text;

                            uretimListesiGridView.Rows.Add(null, secilenSiparisDetayIncKey, islem, makine, islemNo, miktar, birim, uretimTarih, aciklama);
                        }
                    }

                    this.uretimListesiGridView.Sort(this.uretimListesiGridView.Columns["ISLEM_NO"], ListSortDirection.Ascending);

                    txtUretimMik.Text = "0,000";
                    txtAciklama.Text = "";
                    groupBox3.Enabled = false;

                }
                else
                {
                    Notification.messageBoxError("Stok seçmediniz ve ya Üretim miktarı 0'dan büyük değil !");
                }

            }
        }

        private void uretimListesiGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string uretimInckey = uretimListesiGridView["UR_INCKEY", e.Row.Index].Value.ToString();

            if (!String.IsNullOrEmpty(uretimInckey))
                deletedItems.Add(uretimInckey);

            int x = 0;

            for (int i = 0; i < uretimListesiGridView.Rows.Count; i++)
            {
                if (i != e.Row.Index)
                {
                    x++;
                    uretimListesiGridView.Rows[i].Cells["ISLEM_NO"].Value = x;
                }
            }

            uretimListesiGridView.Refresh();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uretimListesiGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1)
            {
                groupBox3.Enabled = true;
                btnListeyeEkle.Text = "GÜNCELLE";
                uretimAdimiGuncelle = true;

                cbMakine.SelectedItem = uretimListesiGridView["MAKINE", e.RowIndex].Value.ToString();
                cbIslem.SelectedItem = uretimListesiGridView["ISLEM", e.RowIndex].Value.ToString();
                cbBirim.SelectedItem = uretimListesiGridView["BIRIM", e.RowIndex].Value.ToString();
                txtAciklama.Text = uretimListesiGridView["ACIKLAMA", e.RowIndex].Value.ToString();
                txtUretimMik.Text = uretimListesiGridView["MIKTAR", e.RowIndex].Value.ToString();
                dateTimeUretimTarih.Value = DateTime.Parse(uretimListesiGridView["URETIM_TARIH", e.RowIndex].Value.ToString());
                secilenSiparisDetayIncKey = int.Parse(uretimListesiGridView["SIP_DETAY_INCKEY", e.RowIndex].Value.ToString());

                selectedItemIndex = e.RowIndex;

            }
        }

        private void stokListGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stokListGridView.Rows.Count > 0)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    groupBox3.Enabled = true;
                    secilenSiparisDetayIncKey = int.Parse(stokListGridView["SIP_DETAY_INCKEY", e.RowIndex].Value.ToString());
                    Notification.messageBox("SEÇİLEN STOK: \n" + stokListGridView["STOK_KOD", e.RowIndex].Value.ToString() + " - " + stokListGridView["STOK_ADI", e.RowIndex].Value.ToString());

                    // stokListGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    // stokListGridView.ClearSelection();

                }
            }
        }
    }
}
