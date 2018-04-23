using System;
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
using System.Collections.Generic;

namespace smoothsis
{
    public partial class SiparisPaneli : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter siparisStokDetay;
        private DataTable siparisStokDetayTable = new DataTable();

        private Tuple<int, DataGridViewCellCollection> selectedItem;
        private Tuple<int, string> secilenCari;
        private Tuple<bool, int> stokGuncelle = new Tuple<bool, int>(false, -1);
        private List<Tuple<int, string>> stokDepo = new List<Tuple<int, string>>();

        // İTEM1 : STOK_DEPO_INCKEY, İTEM2 = STOK_INCKEY
        private Tuple<int, int> selectedUpdateItem; 

        private decimal siparisToplamTutar = 0;
        private int cariKod, siparisIncKey;
        private bool siparisGuncelle = false;
        private string siparisKod = "";

        private ArrayList siparisStokList = new ArrayList();

        public SiparisPaneli()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            kaydetBttn.Enabled = false;
            siparisTipi.SelectedIndex = 0;
            txtSiparisTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtSiparisTeslimTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            siparisListesiGridView.ColumnCount = 9;
            siparisListesiGridView.Columns[0].Name = "STOK_DEPO_INCKEY";
            siparisListesiGridView.Columns[1].Name = "STOK_INCKEY";
            siparisListesiGridView.Columns[2].Name = "STOK_KODU";
            siparisListesiGridView.Columns[3].Name = "STOK_ADI";
            siparisListesiGridView.Columns[4].Name = "DEPO";
            siparisListesiGridView.Columns[5].Name = "MIKTAR";
            siparisListesiGridView.Columns[6].Name = "BIRIM";
            siparisListesiGridView.Columns[7].Name = "BIRIM_FIYAT";
            siparisListesiGridView.Columns[8].Name = "TUTAR";

            siparisListesiGridView.Columns[0].Visible = false;
            siparisListesiGridView.Columns[1].Visible = false;

            Styler.gridViewCommonStyle(siparisListesiGridView);
            siparisListesiGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            siparisListesiGridView.Rows.Clear();
            siparisListesiGridView.Refresh();

        }

        private void txtSiparisKodu_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((char)Keys.Enter == e.KeyChar)
            {
                string siparisCheckSQL = "SELECT * FROM SIPARIS WHERE SIPARIS_KOD=@siparis_kod";
                sqlCmd = new SqlCommand(siparisCheckSQL, Program.connection);
                sqlCmd.Parameters.AddWithValue("@siparis_kod", txtSiparisKodu.Text.Trim());
                SqlDataReader sqlReaderSiparis = sqlCmd.ExecuteReader();

                if (sqlReaderSiparis.HasRows)
                {
                    siparisGuncelle = true;


                    sqlReaderSiparis.Read();
                    txtSiparisTarih.Text = DateTime.Parse(sqlReaderSiparis["SIP_TARIH"].ToString()).ToString("dd.MM.yyyy");
                    txtSiparisTeslimTarih.Text = DateTime.Parse(sqlReaderSiparis["TESLIM_TARIH"].ToString()).ToString("dd.MM.yyyy");
                    siparisTipi.SelectedValue = sqlReaderSiparis["SIPARIS_TIPI"].ToString();
                    txtOzelKod.Text = sqlReaderSiparis["OZEL_KOD"].ToString();
                    txtProjeKodu.Text = sqlReaderSiparis["PROJE_KOD"].ToString();
                    txtProjeAdi.Text = sqlReaderSiparis["PROJE_ADI"].ToString();
                    txtAciklama1.Text = sqlReaderSiparis["ACIKLAMA1"].ToString();
                    txtAciklama2.Text = sqlReaderSiparis["ACIKLAMA2"].ToString();
                    siparisKod = sqlReaderSiparis["SIPARIS_KOD"].ToString();
                    cariKod = int.Parse(sqlReaderSiparis["CARI_KOD"].ToString());

                    string cariCheckSQL = "SELECT * FROM CARI WHERE CARI_INCKEY=@cari_inckey";
                    sqlCmd = new SqlCommand(cariCheckSQL, Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_inckey", sqlReaderSiparis["CARI_KOD"].ToString());
                    SqlDataReader sqlReaderCari = sqlCmd.ExecuteReader();

                    sqlReaderCari.Read();
                    txtCariIsim.Text = sqlReaderCari["ADSOYAD"].ToString();
                    txtTicariUnvan.Text = sqlReaderCari["TICARI_UNVAN"].ToString();
                    txtCariKod.Text = sqlReaderCari["CARI_KOD"].ToString();
                    txtIlIlce.Text = sqlReaderCari["IL"].ToString() + " / " + sqlReaderCari["ILCE"].ToString();

                    string stokCheckSQL = "SELECT STDP.STOK_DEPO_INCKEY, STK.STOK_INCKEY, SPDT.SIPARIS_INCKEY, STK.STOK_KOD, STK.STOK_ADI, DP.DEPO_ADI, SPDT.MIKTAR, SPDT.MIKTAR_BIRIM, STK.BIRIM_FIYAT, (SPDT.MIKTAR * STK.BIRIM_FIYAT) AS TUTAR " +
                        "FROM SIPARIS_DETAY SPDT " +
                        "JOIN STOK_DEPO STDP ON STDP.STOK_DEPO_INCKEY = SPDT.STOK_DEPO_INCKEY " +
                        "JOIN DEPO DP ON DP.DEPO_INCKEY = STDP.DEPO_INCKEY " +
                        "JOIN STOK STK ON STK.STOK_INCKEY = STDP.STOK_INCKEY " +
                        "WHERE SPDT.SIPARIS_INCKEY = @siparis_inckey";
                    sqlCmd = new SqlCommand(stokCheckSQL, Program.connection);
                    sqlCmd.Parameters.AddWithValue("@siparis_inckey", sqlReaderSiparis["SIPARIS_INCKEY"].ToString());

                    siparisIncKey = int.Parse(sqlReaderSiparis["SIPARIS_INCKEY"].ToString());

                    siparisStokDetayTable.Clear();
                    siparisStokDetay = new SqlDataAdapter(sqlCmd);
                    siparisStokDetay.Fill(siparisStokDetayTable);

                    SqlDataReader sqlReaderStok = sqlCmd.ExecuteReader();

                    siparisStokList.Clear();
                    siparisListesiGridView.Rows.Clear();

                    while (sqlReaderStok.Read())
                    {
                        string stokDepoInckey = sqlReaderStok["STOK_DEPO_INCKEY"].ToString();
                        string stokInckey = sqlReaderStok["STOK_INCKEY"].ToString();                        
                        string stokKodu = sqlReaderStok["STOK_KOD"].ToString();
                        string stokAdi = sqlReaderStok["STOK_ADI"].ToString();
                        string stokDepoAdi = sqlReaderStok["DEPO_ADI"].ToString();
                        string stokMiktar = sqlReaderStok["MIKTAR"].ToString();
                        string stokBirim = sqlReaderStok["MIKTAR_BIRIM"].ToString();
                        string stokBirimFiyat = sqlReaderStok["BIRIM_FIYAT"].ToString();
                        string stokTutar = sqlReaderStok["TUTAR"].ToString();

                        siparisListesiGridView.Rows.Add(stokDepoInckey, stokInckey, stokKodu, stokAdi, stokDepoAdi, stokMiktar, stokBirim, stokBirimFiyat, stokTutar);
                        siparisToplamTutar += decimal.Parse(stokTutar);

                        siparisStokList.Add(stokInckey);
                    }

                }
                else
                {
                    Notification.messageBox("SİPARİŞ BULUNAMADI");
                    txtSiparisKodu.Focus();
                }
            }

        }

        private void btnSiparisKoduOlustur_Click(object sender, EventArgs e)
        {
            try
            {
                sqlCmd = new SqlCommand("SELECT TOP 1 SIPARIS_INCKEY FROM SIPARIS ORDER BY SIPARIS_INCKEY DESC", Program.connection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    ActionControl.ActionAllControls(this, "clear");
                    siparisListesiGridView.Rows.Clear();
                    siparisListesiGridView.Refresh();
                    txtSiparisTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
                    txtSiparisTeslimTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");

                    sqlReader.Read();
                    txtSiparisKodu.Text = "SP" + (int.Parse(sqlReader["SIPARIS_INCKEY"].ToString()) + 1).ToString("D10");
                    siparisKod = txtSiparisKodu.Text;
                    sqlReader.Close();

                }
                else
                    txtSiparisKodu.Text = "SP0000000001";
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        private void txtCariKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT ADSOYAD, TICARI_UNVAN, CONCAT(IL, ' / ', ILCE) AS IL_ILCE FROM CARI WHERE CARI_KOD=@cari_kod", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_kod", txtCariKod.Text.Trim());
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtCariIsim.Text = sqlReader["ADSOYAD"].ToString().ToUpper();
                        txtTicariUnvan.Text = sqlReader["TICARI_UNVAN"].ToString().ToUpper();
                        txtIlIlce.Text = sqlReader["IL_ILCE"].ToString().ToUpper();
                        sqlReader.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("KAYIT BULUNAMADI");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        private void btnCariListeAc_Click(object sender, EventArgs e)
        {
            CariListesi cariList = new CariListesi(1);
            cariList.ShowDialog();
            try
            {
                secilenCari = cariList.passingCari;

                if (secilenCari != null)
                {
                    txtCariKod.Text = secilenCari.Item2;


                    sqlCmd = new SqlCommand("SELECT ADSOYAD, TICARI_UNVAN,  CONCAT(IL, ' / ', ILCE) AS IL_ILCE FROM CARI WHERE CARI_INCKEY=@cari_inckey", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_inckey", secilenCari.Item1);
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtCariIsim.Text = sqlReader["ADSOYAD"].ToString().ToUpper();
                        txtTicariUnvan.Text = sqlReader["TICARI_UNVAN"].ToString().ToUpper();
                        txtIlIlce.Text = sqlReader["IL_ILCE"].ToString().ToUpper();
                        sqlReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
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
                        Notification.messageBoxError("KAYIT BULUNAMADI");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        private void txtStokMiktar_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBirimFiyat.Text.Trim()) && !String.IsNullOrEmpty(txtStokMiktar.Text.Trim()))
            {

                // TODO: EĞER STOK MİKTARINDAN FAZLA GİRİLDİYSE DEĞER MAX MİKTARA EŞİTLENECEK
                if (stokGuncelle.Item1)
                {
                    sqlCmd = new SqlCommand("SELECT SUM(SD.MIKTAR) FROM STOK_DEPO SD WHERE SD.STOK_DEPO_INCKEY = @stok_depo_inckey", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@stok_depo_inckey", selectedUpdateItem.Item1);
                    decimal stokMiktarReader = (decimal)sqlCmd.ExecuteScalar();

                    if (decimal.Parse(txtStokMiktar.Text.Trim()) > stokMiktarReader)
                        txtStokMiktar.Text = stokMiktarReader.ToString();
                }
                else
                {                    
                    if (decimal.Parse(txtStokMiktar.Text.Trim()) > decimal.Parse(selectedItem.Item2["MIKTAR"].Value.ToString()))                    
                        txtStokMiktar.Text = selectedItem.Item2["MIKTAR"].Value.ToString();                    
                }                                

                decimal toplamFiyat = decimal.Parse(txtStokMiktar.Text.Trim()) * decimal.Parse(txtBirimFiyat.Text.Trim());
                txtToplamFiyat.Text = toplamFiyat.ToString();
            }
        }

        private void btnListeyeEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStokKodu.Text) || String.IsNullOrEmpty(txtBirimFiyat.Text))
            {
                Notification.messageBoxError("LÜTFEN STOK SEÇİNİZ");
            }
            else
            {
                if (decimal.Parse(txtToplamFiyat.Text) > 0)
                {
                    string stokDepoInckey = "";
                    string stokInckey = "";
                    string stokKodu = "";
                    string stokAdi = "";
                    string stokMiktar = "";
                    string stokBirim = "";
                    string stokBirimFiyat = "";
                    string stokTutar = "";
                    string stokDepo = "";

                    if (stokGuncelle.Item1)
                    {
                        siparisListesiGridView.Rows.RemoveAt(stokGuncelle.Item2);

                        stokDepoInckey = selectedUpdateItem.Item1.ToString();
                        stokInckey = selectedUpdateItem.Item2.ToString();
                        stokKodu = txtStokKodu.Text.Trim();
                        stokAdi = txtStokAdi.Text.Trim();
                        stokDepo = cbStokDepo.SelectedItem.ToString().Split('-')[1].Trim();
                        stokMiktar = txtStokMiktar.Text.Trim();
                        stokBirim = txtStokBirim.Text.Trim();
                        stokBirimFiyat = txtBirimFiyat.Text.Trim();
                        stokTutar = txtToplamFiyat.Text.Trim();
                        

                        siparisListesiGridView.Rows.Add(stokDepoInckey, stokInckey, stokKodu, stokAdi, stokDepo, stokMiktar, stokBirim, stokBirimFiyat, stokTutar);
                        siparisToplamTutar += decimal.Parse(stokTutar);
                        siparisStokList.Add(stokInckey);

                        btnListeyeEkle.Text = "LİSTEYE EKLE";
                        ActionControl.ActionAllControls(groupBox4, "clear");
                        cbStokDepo.Items.Clear();

                    }
                    else
                    {
                        if (!siparisStokList.Contains(selectedItem.Item2["STOK_INCKEY"].Value.ToString()))
                        {
                            stokDepoInckey = cbStokDepo.SelectedItem.ToString().Split('-')[0].Trim();
                            stokInckey = selectedItem.Item2["STOK_INCKEY"].Value.ToString();
                            stokKodu = txtStokKodu.Text.Trim();
                            stokAdi = selectedItem.Item2["STOK_ADI"].Value.ToString();
                            stokMiktar = txtStokMiktar.Text;
                            stokBirim = txtStokBirim.Text;
                            stokBirimFiyat = selectedItem.Item2["BIRIM_FIYAT"].Value.ToString();
                            stokTutar = txtToplamFiyat.Text;
                            stokDepo = cbStokDepo.SelectedItem.ToString().Split('-')[1].Trim();

                            siparisListesiGridView.Rows.Add(stokDepoInckey, stokInckey, stokKodu, stokAdi, stokDepo, stokMiktar, stokBirim, stokBirimFiyat, stokTutar);
                            siparisStokList.Add(selectedItem.Item2["STOK_INCKEY"].Value.ToString());
                            siparisToplamTutar += decimal.Parse(stokTutar);

                            kaydetBttn.Enabled = true;
                            ActionControl.ActionAllControls(groupBox4, "clear");
                            cbStokDepo.Items.Clear();
                        }
                    }

                    siparisListesiGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
            }
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            try
            {
                StokListesi stokList = new StokListesi(1);
                stokList.ShowDialog();
                selectedItem = stokList.getSelectedItem();
                if (selectedItem != null)
                {
                    btnListeyeEkle.Text = "LİSTEYE EKLE";
                    txtStokKodu.Text = selectedItem.Item2["STOK_KODU"].Value.ToString();
                    txtStokAdi.Text = selectedItem.Item2["STOK_ADI"].Value.ToString();
                    txtStokBirim.Text = selectedItem.Item2["MIKTAR_BIRIM"].Value.ToString();
                    txtBirimFiyat.Text = selectedItem.Item2["BIRIM_FIYAT"].Value.ToString();

                    sqlCmd = new SqlCommand("SELECT STD.STOK_DEPO_INCKEY, D.DEPO_ADI FROM STOK_DEPO STD JOIN DEPO D ON D.DEPO_INCKEY=STD.DEPO_INCKEY WHERE STD.STOK_INCKEY=@stok_inckey", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@stok_inckey", selectedItem.Item2["STOK_INCKEY"].Value.ToString());
                    SqlDataReader dataReader = sqlCmd.ExecuteReader();

                    cbStokDepo.Items.Clear();
                    if (dataReader.HasRows)
                        while (dataReader.Read())
                            cbStokDepo.Items.Add(dataReader["STOK_DEPO_INCKEY"].ToString() + " - " + dataReader["DEPO_ADI"].ToString());

                    cbStokDepo.SelectedIndex = 0;
                    txtStokMiktar.Text = "0";
                    stokGuncelle = new Tuple<bool, int>(false, -1);
                }
            }catch(Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void siparisListesiGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                txtStokKodu.Text = siparisListesiGridView["STOK_KODU", e.RowIndex].Value.ToString();
                txtStokAdi.Text = siparisListesiGridView["STOK_ADI", e.RowIndex].Value.ToString();
                txtStokMiktar.Text = siparisListesiGridView["MIKTAR", e.RowIndex].Value.ToString();
                txtStokBirim.Text = siparisListesiGridView["BIRIM", e.RowIndex].Value.ToString();
                txtBirimFiyat.Text = siparisListesiGridView["BIRIM_FIYAT", e.RowIndex].Value.ToString();
                txtToplamFiyat.Text = siparisListesiGridView["TUTAR", e.RowIndex].Value.ToString();

                sqlCmd = new SqlCommand("SELECT STD.STOK_DEPO_INCKEY, D.DEPO_ADI FROM STOK_DEPO STD JOIN DEPO D ON D.DEPO_INCKEY=STD.DEPO_INCKEY WHERE STD.STOK_INCKEY=@stok_inckey", Program.connection);
                sqlCmd.Parameters.AddWithValue("@stok_inckey", siparisListesiGridView["STOK_INCKEY", e.RowIndex].Value.ToString());
                SqlDataReader dataReader = sqlCmd.ExecuteReader();

                int checkIndex = 0;
                cbStokDepo.Items.Clear();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        cbStokDepo.Items.Add(dataReader["STOK_DEPO_INCKEY"].ToString() + " - " + dataReader["DEPO_ADI"].ToString());
                        if (dataReader["DEPO_ADI"].ToString().Equals(siparisListesiGridView["DEPO", e.RowIndex].Value.ToString()))
                            cbStokDepo.SelectedIndex = checkIndex;

                        checkIndex++;
                    }
                }

                btnListeyeEkle.Text = "GÜNCELLE";
                stokGuncelle = new Tuple<bool, int>(true, e.RowIndex);

                selectedUpdateItem = new Tuple<int, int>(
                                           int.Parse(siparisListesiGridView["STOK_DEPO_INCKEY", e.RowIndex].Value.ToString()),
                                           int.Parse(siparisListesiGridView["STOK_INCKEY", e.RowIndex].Value.ToString())
                                       );

                siparisToplamTutar -= decimal.Parse(siparisListesiGridView["TUTAR", e.RowIndex].Value.ToString());
                siparisStokList.Remove(siparisListesiGridView["STOK_INCKEY", e.RowIndex].Value.ToString());
            }
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSiparisKodu.Text) ||
                String.IsNullOrEmpty(txtCariIsim.Text) ||
                String.IsNullOrEmpty(siparisTipi.SelectedItem.ToString()) ||
                (siparisListesiGridView.Rows.Count <= 0))
            {
                Notification.messageBoxError("LÜTFEN GEREKLİ İÇERİKLERİ DOLDURUNUZ !");
            }
            else
            {
                if (siparisGuncelle)
                {

                    try
                    {
                        ArrayList arrayList = new ArrayList(siparisStokDetayTable.Rows.Count);

                        foreach (DataRow dtRow in siparisStokDetayTable.Rows)
                            arrayList.Add(dtRow["STOK_KOD"].ToString());


                        string siparisGuncelleSQL = "UPDATE SIPARIS SET " +
                            "CARI_KOD=@cari_kod, PROJE_KOD=@proje_kod, PROJE_ADI=@proje_adi, OZEL_KOD=@ozel_kod, SIPARIS_TIPI=@siparis_tipi, SIP_TARIH=@sip_tarih, TESLIM_TARIH=@teslim_tarih, SIPARIS_TUTAR=@siparis_tutar, DUZELTME_YAPAN_KUL=@duzeltme_yapan_kul, DUZELTME_TARIH=GETDATE(), ACIKLAMA1=@aciklama1, ACIKLAMA2=@aciklama2 " +
                            "WHERE SIPARIS_KOD=@siparis_kod";
                        sqlCmd = new SqlCommand(siparisGuncelleSQL, Program.connection);
                        sqlCmd.Parameters.Add("@siparis_kod", SqlDbType.VarChar).Value = txtSiparisKodu.Text.Trim();
                        sqlCmd.Parameters.Add("@proje_kod", SqlDbType.VarChar).Value = txtProjeKodu.Text.Trim();
                        sqlCmd.Parameters.Add("@proje_adi", SqlDbType.VarChar).Value = txtProjeAdi.Text.Trim();
                        sqlCmd.Parameters.Add("@cari_kod", SqlDbType.Int).Value = cariKod;
                        sqlCmd.Parameters.Add("@ozel_kod", SqlDbType.VarChar).Value = txtOzelKod.Text.Trim();
                        sqlCmd.Parameters.Add("@siparis_tipi", SqlDbType.VarChar).Value = siparisTipi.SelectedItem.ToString();
                        sqlCmd.Parameters.Add("@sip_tarih", SqlDbType.Date).Value = DateTime.Parse(txtSiparisTarih.Text);
                        sqlCmd.Parameters.Add("@teslim_tarih", SqlDbType.Date).Value = DateTime.Parse(txtSiparisTeslimTarih.Text);
                        sqlCmd.Parameters.Add("@duzeltme_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                        sqlCmd.Parameters.Add("@siparis_tutar", SqlDbType.Decimal).Value = siparisToplamTutar;
                        sqlCmd.Parameters.Add("@aciklama1", SqlDbType.Text).Value = txtAciklama1.Text;
                        sqlCmd.Parameters.Add("@aciklama2", SqlDbType.Text).Value = txtAciklama2.Text;

                        sqlCmd.ExecuteNonQuery();

                        foreach (DataGridViewRow row in siparisListesiGridView.Rows)
                        {
                            if (arrayList.Contains(row.Cells["STOK_KODU"].Value.ToString()))
                            {
                                string updateSiparisDetay = "UPDATE SIPARIS_DETAY SET MIKTAR = @yeni_miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey AND SIPARIS_INCKEY = @siparis_inckey";
                                sqlCmd = new SqlCommand(updateSiparisDetay, Program.connection);
                                sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = int.Parse(row.Cells["STOK_INCKEY"].Value.ToString());
                                sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = siparisIncKey;
                                sqlCmd.Parameters.Add("@yeni_miktar", SqlDbType.Decimal).Value = decimal.Parse(row.Cells["MIKTAR"].Value.ToString());
                                sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = int.Parse(row.Cells["STOK_DEPO_INCKEY"].Value.ToString());
                                sqlCmd.ExecuteNonQuery();
                            }
                            else
                            {
                                
                                string siparisStokSQL = "INSERT INTO SIPARIS_DETAY (SIPARIS_INCKEY, STOK_DEPO_INCKEY, MIKTAR, MIKTAR_BIRIM)" +
                                        "VALUES (@siparis_inckey, @stok_depo_inckey, @miktar, @miktar_birim)";
                                sqlCmd = new SqlCommand(siparisStokSQL, Program.connection);
                                sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = siparisIncKey;
                                sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = int.Parse(row.Cells["STOK_DEPO_INCKEY"].Value.ToString());
                                sqlCmd.Parameters.Add("@miktar", SqlDbType.Float).Value = decimal.Parse(row.Cells["MIKTAR"].Value.ToString());
                                sqlCmd.Parameters.Add("@miktar_birim", SqlDbType.VarChar).Value = row.Cells["BIRIM"].Value;
                                sqlCmd.ExecuteNonQuery();
                            }

                        }

                        Notification.messageBox("SİPARİŞ BAŞARIYLA GÜNCELLENDİ");

                    }
                    catch(Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }

                }
                else
                {

                    try
                    {
                        string siparisKaydetSQL = "INSERT INTO SIPARIS (SIPARIS_KOD, CARI_KOD, PROJE_KOD, PROJE_ADI, OZEL_KOD, SIPARIS_TIPI, SIP_TARIH, TESLIM_TARIH, SIPARIS_TUTAR, KAYIT_YAPAN_KUL, ACIKLAMA1, ACIKLAMA2) " +
                            "OUTPUT INSERTED.SIPARIS_INCKEY VALUES (@siparis_kod, @cari_kod, @proje_kod, @proje_adi, @ozel_kod, @siparis_tipi, @sip_tarih, @teslim_tarih, @siparis_tutar, @kayit_yapan_kul, @aciklama1, @aciklama2)";
                        sqlCmd = new SqlCommand(siparisKaydetSQL, Program.connection);
                        sqlCmd.Parameters.Add("@siparis_kod", SqlDbType.VarChar).Value = txtSiparisKodu.Text;
                        sqlCmd.Parameters.Add("@proje_kod", SqlDbType.VarChar).Value = txtProjeKodu.Text;
                        sqlCmd.Parameters.Add("@proje_adi", SqlDbType.VarChar).Value = txtProjeAdi.Text;
                        sqlCmd.Parameters.Add("@cari_kod", SqlDbType.Int).Value = secilenCari.Item1;
                        sqlCmd.Parameters.Add("@ozel_kod", SqlDbType.VarChar).Value = txtOzelKod.Text;
                        sqlCmd.Parameters.Add("@siparis_tipi", SqlDbType.VarChar).Value = siparisTipi.SelectedItem.ToString();
                        sqlCmd.Parameters.Add("@sip_tarih", SqlDbType.Date).Value = DateTime.Parse(txtSiparisTarih.Text);
                        sqlCmd.Parameters.Add("@teslim_tarih", SqlDbType.Date).Value = DateTime.Parse(txtSiparisTeslimTarih.Text);
                        sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                        sqlCmd.Parameters.Add("@siparis_tutar", SqlDbType.Decimal).Value = siparisToplamTutar;
                        sqlCmd.Parameters.Add("@aciklama1", SqlDbType.Text).Value = txtAciklama1.Text;
                        sqlCmd.Parameters.Add("@aciklama2", SqlDbType.Text).Value = txtAciklama2.Text;

                        int lastSiparisId = (int)sqlCmd.ExecuteScalar();

                        if (lastSiparisId > 0)
                        {

                            foreach (DataGridViewRow row in siparisListesiGridView.Rows)
                            {
                                string siparisStokSQL = "INSERT INTO SIPARIS_DETAY (SIPARIS_INCKEY, STOK_DEPO_INCKEY, MIKTAR, MIKTAR_BIRIM)" +
                                    "VALUES (@siparis_inckey, @stok_depo_inckey, @miktar, @miktar_birim)";
                                sqlCmd = new SqlCommand(siparisStokSQL, Program.connection);
                                sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = lastSiparisId;
                                sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value.ToString());
                                sqlCmd.Parameters.Add("@miktar", SqlDbType.Float).Value = row.Cells["MIKTAR"].Value;
                                sqlCmd.Parameters.Add("@miktar_birim", SqlDbType.VarChar).Value = row.Cells["BIRIM"].Value;
                                sqlCmd.ExecuteNonQuery();
                            }

                            Notification.messageBox("SİPARİŞ BAŞARIYLA OLUŞTURULDU");
                            this.Close();

                        }
                        else
                        {
                            Notification.messageBoxError("SİPARİŞ EKLENEMEDİ");
                        }

                    }
                    catch (Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }
                }

            }
        }


        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            int mainTab = 0;
            int selectedTab = tabControl1.SelectedIndex;

            if (String.IsNullOrEmpty(txtSiparisKodu.Text) ||
                String.IsNullOrEmpty(txtCariIsim.Text) ||
                String.IsNullOrEmpty(txtSiparisTarih.Text) ||
                String.IsNullOrEmpty(txtSiparisTeslimTarih.Text) ||
                String.IsNullOrEmpty(siparisTipi.SelectedItem.ToString()))
            {
                tabControl1.SelectTab(mainTab);
            }
            else
            {
                tabControl1.SelectTab(selectedTab);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ActionControl.ActionAllControls(groupBox1, "clear");
            ActionControl.ActionAllControls(groupBox2, "clear");
            ActionControl.ActionAllControls(groupBox3, "clear");
            ActionControl.ActionAllControls(groupBox4, "clear");

            cbStokDepo.Items.Clear();
            siparisListesiGridView.Rows.Clear();
            siparisStokList.Clear();

            siparisTipi.SelectedIndex = 0;
            txtSiparisTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtSiparisTeslimTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");

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

        private void txtStokMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != ','))
                e.Handled = true;
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSiparisKodu_Leave(object sender, EventArgs e)
        {
            if (!txtSiparisKodu.Text.Equals(siparisKod))
                txtSiparisKodu.Text = siparisKod;

        }

        private void txtToplamFiyat_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtToplamFiyat.Text))            
                txtToplamFiyat.Text = "0";            

            txtToplamFiyat.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtToplamFiyat.Text));

        }

        private void txtStokMiktar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtStokMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtStokMiktar.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMAT GİRİLDİ");
                txtStokMiktar.Focus();
            }
        }

        private void siparisListesiGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Delete)
            {
                if(siparisListesiGridView.SelectedRows.Count == 1)
                {
                    int removeIndex = siparisListesiGridView.SelectedRows[0].Index;

                    siparisListesiGridView.Rows.RemoveAt(removeIndex);
                }
            }            
        }

        private void siparisListesiGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (siparisListesiGridView.Rows.Count > 0)
                kaydetBttn.Enabled = true;
        }
    }
}
