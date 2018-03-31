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
    public partial class UretimKaydiOlustur : Form
    {
        private SqlCommand SqlCmd;
        private int siparisIncKey;

        public UretimKaydiOlustur(int siparisIncKey)
        {
            this.siparisIncKey = siparisIncKey;
            InitializeComponent();
        }

        private void UretimKaydiOlustur_Load(object sender, EventArgs e)
        {
            string siparisBilgileriSQL = "SELECT SIPARIS_KOD, PROJE_KOD, PROJE_ADI, SIP_TARIH, TESLIM_TARIH, SIPARIS_TIPI, C.CARI_KOD, ADSOYAD, CONCAT(C.IL,' / ',C.ILCE) AS IL_ILCE FROM SIPARIS SP JOIN CARI C ON C.CARI_INCKEY = SP.CARI_KOD WHERE SIPARIS_INCKEY = @siparis_inckey";
            SqlCmd = new SqlCommand(siparisBilgileriSQL, Program.connection);
            SqlCmd.Parameters.AddWithValue("@siparis_inckey", siparisIncKey);
            SqlDataReader dataReader = SqlCmd.ExecuteReader();

            if (dataReader.HasRows)
            {
                txtSiparisKodu.Text = dataReader["SIPARIS_KOD"].ToString() ;
                txtProjeKodu.Text = dataReader["PROJE_KOD"].ToString();
                txtProjeAdi.Text = dataReader["PROJE_ADI"].ToString();
                txtSiparisTarihi.Text = dataReader["SIP_TARIH"].ToString();
                txtTeslimTarih.Text = dataReader["TESLIM_TARIH"].ToString();
                txtSiparisTipi.Text = dataReader["SIPARIS_TIPI"].ToString();
                txtCariKodu.Text = dataReader["CARI_KOD"].ToString();
                txtCariAdiSoyadi.Text = dataReader["ADSOYAD"].ToString();
                txtIlIlce.Text = dataReader["IL_ILCE"].ToString();


            }
        }
    }
}
