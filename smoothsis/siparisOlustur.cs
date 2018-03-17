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

namespace smoothsis
{
    public partial class SiparisOlustur : Form
    {
        private SqlCommand sqlCmd;

        private Tuple<int, DataGridViewCellCollection> selectedItem;
        private Tuple<int, string> secilenCari;
        private Tuple<bool, int> stokGuncelle = new Tuple<bool, int>(false,-1);

        private decimal siparisToplamTutar = 0;
        private int selectedStokIncKey;

        private ArrayList siparisStokList = new ArrayList();

        public SiparisOlustur()
        {
            InitializeComponent();
        }

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            siparisTipi.SelectedIndex = 0;
            txtSiparisTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");
            txtSiparisTeslimTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");

            siparisListesiGridView.ColumnCount = 7;

            siparisListesiGridView.Columns[0].Name = "STOK_INCKEY";
            siparisListesiGridView.Columns[1].Name = "STOK_KODU";
            siparisListesiGridView.Columns[2].Name = "STOK_ADI";
            siparisListesiGridView.Columns[3].Name = "MIKTAR";
            siparisListesiGridView.Columns[4].Name = "BIRIM";
            siparisListesiGridView.Columns[5].Name = "BIRIM_FIYAT";
            siparisListesiGridView.Columns[6].Name = "TUTAR";

            siparisListesiGridView.Columns[0].Visible = false;

            Program.controllerClass.gridViewCommonStyle(siparisListesiGridView);
            Program.controllerClass.gridViewColumnResize(siparisListesiGridView);

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
                        txtSiparisKodu.Text = "SP" + (int.Parse(sqlReader["SIPARIS_INCKEY"].ToString()) + 1).ToString("D10");
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
        }

        private void txtCariKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    sqlCmd = new SqlCommand("SELECT ADSOYAD, TICARI_UNVAN, IL, ILCE FROM CARI WHERE CARI_KOD=@cari_kod", Program.connection);
                    sqlCmd.Parameters.AddWithValue("@cari_kod", txtCariKod.Text.Trim());
                    SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        sqlReader.Read();
                        txtCariIsim.Text = sqlReader["ADSOYAD"].ToString().ToUpper();
                        txtTicariUnvan.Text = sqlReader["TICARI_UNVAN"].ToString().ToUpper();
                        txtIlIlce.Text = sqlReader["IL"].ToString().ToUpper() + " / " + sqlReader["ILCE"].ToString().ToUpper();
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
            }
            catch (Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
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
            if (!String.IsNullOrEmpty(txtBirimFiyat.Text.Trim()) && !String.IsNullOrEmpty(txtStokMiktar.Text.Trim()))
            {
                if (decimal.Parse(txtStokMiktar.Text.Trim()) > decimal.Parse(selectedItem.Item2["MIKTAR"].Value.ToString()))
                {
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
                Program.controllerClass.messageBoxError("LÜTFEN STOK SEÇİNİZ");
            }
            else
            {
                if (int.Parse(txtToplamFiyat.Text) > 0)
                {

                    string stokInckey= "";
                    string stokKodu = "";
                    string stokAdi = "";
                    string stokMiktar = "";
                    string stokBirim = "";
                    string stokBirimFiyat = "";
                    string stokTutar = "";

                    if (stokGuncelle.Item1)
                    {
                        siparisListesiGridView.Rows.RemoveAt(stokGuncelle.Item2);

                        stokInckey = selectedStokIncKey.ToString();
                        stokKodu = txtStokKodu.Text.Trim();
                        stokAdi = txtStokAdi.Text.Trim();
                        stokMiktar = txtStokMiktar.Text.Trim();
                        stokBirim = txtStokBirim.Text.Trim();
                        stokBirimFiyat = txtBirimFiyat.Text.Trim();
                        stokTutar = txtToplamFiyat.Text.Trim();

                        siparisListesiGridView.Rows.Add(stokInckey, stokKodu, stokAdi, stokMiktar, stokBirim, stokBirimFiyat, stokTutar);
                        siparisToplamTutar += decimal.Parse(stokTutar);
                        siparisStokList.Add(selectedItem.Item2["STOK_INCKEY"].Value.ToString());

                        btnListeyeEkle.Text = "LİSTEYE EKLE";
                        Program.controllerClass.ActionAllControls(groupBox4, "clear");

                    } else
                    {
                        if (!siparisStokList.Contains(selectedItem.Item2["STOK_INCKEY"].Value.ToString()))
                        {
                            stokInckey = selectedItem.Item2["STOK_INCKEY"].Value.ToString();
                            stokKodu = txtStokKodu.Text.Trim();
                            stokAdi = selectedItem.Item2["STOK_ADI"].Value.ToString();
                            stokMiktar = txtStokMiktar.Text;
                            stokBirim = txtStokBirim.Text;
                            stokBirimFiyat = selectedItem.Item2["BIRIM_FIYAT"].Value.ToString();
                            stokTutar = txtToplamFiyat.Text;

                            siparisListesiGridView.Rows.Add(stokInckey, stokKodu, stokAdi, stokMiktar, stokBirim, stokBirimFiyat, stokTutar);
                            siparisStokList.Add(selectedItem.Item2["STOK_INCKEY"].Value.ToString());
                            siparisToplamTutar += decimal.Parse(stokTutar);

                            Program.controllerClass.ActionAllControls(groupBox4, "clear");
                        }
                    }

                    Program.controllerClass.gridViewColumnResize(siparisListesiGridView);

                }
            }
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            StokListesi stokList = new StokListesi(1);
            stokList.ShowDialog();
            selectedItem = stokList.getSelectedItem();
            txtStokKodu.Text = selectedItem.Item2["STOK_KODU"].Value.ToString();
            txtStokAdi.Text = selectedItem.Item2["STOK_ADI"].Value.ToString();
            txtStokBirim.Text = selectedItem.Item2["MIKTAR_BIRIM"].Value.ToString();
            txtBirimFiyat.Text = selectedItem.Item2["BIRIM_FIYAT"].Value.ToString();
            txtStokMiktar.Text = "0";
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

                btnListeyeEkle.Text = "GÜNCELLE";
                stokGuncelle = new Tuple<bool, int>(true, e.RowIndex);
                selectedStokIncKey = int.Parse(siparisListesiGridView["STOK_INCKEY", e.RowIndex].Value.ToString());

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
                Program.controllerClass.messageBoxError("LÜTFEN GEREKLİ İÇERİKLERİ DOLDURUNUZ");
            }
            else
            {
                try
                {
                    string siparisKaydetSQL = "INSERT INTO SIPARIS (SIPARIS_KOD, CARI_INCKEY, PROJE_KOD, PROJE_ADI, OZEL_KOD, ACIKLAMA, SIPARIS_TIPI, SIPARIS_TARIH, TESLIM_TARIH, SIPARIS_TUTAR, KAYIT_YAPAN_KUL) " +
                        "OUTPUT INSERTED.SIPARIS_INCKEY VALUES (@siparis_kod, @cari_inckey, @proje_kod, @proje_adi, @ozel_kod, @aciklama, @siparis_tipi, @siparis_tarih, @teslim_tarih, @siparis_tutar, @kayit_yapan_kul)";
                    sqlCmd = new SqlCommand(siparisKaydetSQL, Program.connection);
                    sqlCmd.Parameters.Add("@siparis_kod", SqlDbType.VarChar).Value = txtSiparisKodu.Text;
                    sqlCmd.Parameters.Add("@proje_kod", SqlDbType.VarChar).Value = txtProjeKodu.Text;
                    sqlCmd.Parameters.Add("@proje_adi", SqlDbType.VarChar).Value = txtProjeAdi.Text;
                    sqlCmd.Parameters.Add("@cari_inckey", SqlDbType.Int).Value = secilenCari.Item1;
                    sqlCmd.Parameters.Add("@ozel_kod", SqlDbType.VarChar).Value = txtOzelKod.Text;
                    sqlCmd.Parameters.Add("@siparis_tipi", SqlDbType.VarChar).Value = siparisTipi.SelectedItem.ToString();
                    sqlCmd.Parameters.Add("@siparis_tarih", SqlDbType.Date).Value = DateTime.Parse(txtSiparisTarih.Text);
                    sqlCmd.Parameters.Add("@teslim_tarih", SqlDbType.Date).Value = DateTime.Parse(txtSiparisTeslimTarih.Text);
                    sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    sqlCmd.Parameters.Add("@siparis_tutar", SqlDbType.Float).Value = siparisToplamTutar;
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.Text).Value = txtAciklama.Text;

                    int lastSiparisId = (int)sqlCmd.ExecuteScalar();

                    if (lastSiparisId > 0)
                    {

                        foreach (DataGridViewRow row in siparisListesiGridView.Rows)
                        {
                            string siparisStokSQL = "INSERT INTO SIPARIS_DETAY (SIPARIS_INCKEY, STOK_INCKEY, MIKTAR, MIKTAR_BIRIM)" +
                                "VALUES (@siparis_inckey, @stok_inckey, @miktar, @miktar_birim)";
                            sqlCmd = new SqlCommand(siparisStokSQL, Program.connection);
                            sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = lastSiparisId;
                            sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = row.Cells[0].Value;
                            sqlCmd.Parameters.Add("@miktar", SqlDbType.Float).Value = row.Cells["MIKTAR"].Value;
                            sqlCmd.Parameters.Add("@miktar_birim", SqlDbType.VarChar).Value = row.Cells["BIRIM"].Value;
                            sqlCmd.ExecuteNonQuery();
                        }

                        Program.controllerClass.messageBox("SİPARİŞ BAŞARIYLA OLUŞTURULDU");
                        this.Close();

                    }
                    else
                    {
                        Program.controllerClass.messageBoxError("SİPARİŞ EKLENEMEDİ");
                    }

                }
                catch (Exception ex)
                {
                    Program.controllerClass.messageBoxError(ex.Message);
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
            Program.controllerClass.ActionAllControls(groupBox1, "clear");
            Program.controllerClass.ActionAllControls(groupBox2, "clear");
            Program.controllerClass.ActionAllControls(groupBox3, "clear");
            Program.controllerClass.ActionAllControls(groupBox4, "clear");

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
    }
}