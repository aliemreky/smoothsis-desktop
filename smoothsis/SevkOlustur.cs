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
    public partial class SevkOlustur : Form
    {
        private SqlCommand sqlCmd;
        private DataGridViewCellCollection selectedSiparisItem;
        private decimal totalUretimMiktar = 0;

        public SevkOlustur(DataGridViewCellCollection selectedSiparisItem)
        {
            InitializeComponent();
            this.selectedSiparisItem = selectedSiparisItem;
        }

        private void SevkOlustur_Load(object sender, EventArgs e)
        {

            sqlCmd = new SqlCommand("dbo.SonSevkMiktari", Program.connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@siparis_inckey", Convert.ToInt32(selectedSiparisItem[0].Value.ToString()));
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            totalUretimMiktar = (decimal)reader["TOTAL"];
            string siparisKod = (string)reader["SIPARIS_KOD"];
            string birim = (string)reader["MIKTAR_BIRIM"];
            txtSevkMiktari.Text = totalUretimMiktar.ToString() + " " + birim;
            txtSiparisKod.Text = siparisKod;
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIrsaliyeNo.Text) ||
               String.IsNullOrEmpty(txtSevkMiktari.Text))
            {
                Notification.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ !");
            }
            else
            {
                try
                {
                    string bugunSevkVarmiSQL = "SELECT COUNT(SEVK_INCKEY) FROM SEVK " +
                        "WHERE SIPARIS_INCKEY = @siparis_inckey AND SEVK = @sevk_tarih";
                    sqlCmd = new SqlCommand(bugunSevkVarmiSQL, Program.connection);
                    sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedSiparisItem[0].Value.ToString());
                    sqlCmd.Parameters.Add("@sevk_tarih", SqlDbType.Date).Value = dtpSevkTarih.Value;

                    if (sqlCmd.ExecuteNonQuery() == 0)
                    {
                        string sevkOlusturSQL = "INSERT INTO " +
                            "SEVK(SIPARIS_INCKEY, IRSALIYE_NO, SEVK_MIKTAR, SEVK_TARIH, SEVK_NOT) " +
                            "VALUES (@siparis_inckey, @irsaliye_no, @sevk_miktar, @sevk_tarih, @sevk_not)";
                        sqlCmd = new SqlCommand(sevkOlusturSQL, Program.connection);
                        sqlCmd.Parameters.Add("@siparis_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedSiparisItem[0].Value.ToString());
                        sqlCmd.Parameters.Add("@irsaliye_no", SqlDbType.VarChar).Value = txtIrsaliyeNo.Text;
                        sqlCmd.Parameters.Add("@sevk_miktar", SqlDbType.Decimal).Value = totalUretimMiktar;
                        sqlCmd.Parameters.Add("@sevk_tarih", SqlDbType.Date).Value = dtpSevkTarih.Value;
                        sqlCmd.Parameters.Add("@sevk_not", SqlDbType.VarChar).Value = txtSevkNotu.Text;
                        if (sqlCmd.ExecuteNonQuery() > 0)
                        {
                            Notification.messageBox("SEVK BAŞARIYLA OLUŞTURULDU.");
                        }
                    } else
                    {
                        Notification.messageBox("AYNI GÜNDE BİRDEN FAZLA SEVK YAPILAMAZ.");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtIrsaliyeNo.Clear();
            txtSevkNotu.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
