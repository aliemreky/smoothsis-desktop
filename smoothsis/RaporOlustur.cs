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
using System.Text.RegularExpressions;
using smoothsis.Services;
using System.Globalization;

namespace smoothsis
{
    public partial class RaporOlustur : Form
    {
        private SqlCommand sqlCmd;
        private List<Operator> selectedOperators = new List<Operator>();
        private DataGridViewCellCollection selectedUretim;
        private UretimListesi uretimListesi;

        public RaporOlustur(UretimListesi uretimListesi)
        {
            InitializeComponent();
            this.uretimListesi = uretimListesi;
            selectedUretim = this.uretimListesi.getSelectedItem().Item2;
        }

        private void decimalValidate(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForDecimal(sender, e);
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbRaporVardiya.SelectedItem.ToString()) ||
                String.IsNullOrEmpty(txtBeslenenMiktar.Text) ||
                String.IsNullOrEmpty(txtUretilenMiktar.Text) ||
                String.IsNullOrEmpty(txtFireMiktar.Text) ||
                String.IsNullOrEmpty(txtIskartaMiktar.Text)
                )
            {
                Notification.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ!");
            }
            else
            {
                if (decimal.Parse(txtBeslenenMiktar.Text) > 0 && decimal.Parse(txtUretilenMiktar.Text) > 0)
                {
                    try
                    {

                        sqlCmd = new SqlCommand("dbo.Kalan_Uretim_Mik", Program.connection);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedUretim[0].Value.ToString());
                        var returnParameter = sqlCmd.Parameters.Add("@rt", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;
                        sqlCmd.ExecuteNonQuery();
                        int result = (int)returnParameter.Value;

                        if (
                            (result == -1) && (Convert.ToDecimal(selectedUretim[8].Value.ToString()) >= decimal.Parse(txtUretilenMiktar.Text))
                            ||
                            (result != -1) && (Convert.ToDecimal(selectedUretim[8].Value.ToString()) >= (result + decimal.Parse(txtUretilenMiktar.Text)))
                            )
                        {
                            int urInckey = Convert.ToInt32(selectedUretim[0].Value.ToString());
                            decimal beslenenMiktar = decimal.Parse(txtBeslenenMiktar.Text);
                            decimal uretilenMiktar = decimal.Parse(txtUretilenMiktar.Text);
                            sqlCmd = Program.connection.CreateCommand();
                            sqlCmd.CommandText = "INSERT INTO " +
                                "RAPOR(UR_INCKEY, RAPOR_TARIH, RAPOR_VARDIYA, " +
                                "BESLENEN_MIK, URETILEN_MIK, FIRE_MIK, FIRE_NEDENI, ISKARTA_MIK, " +
                                "ISKARTA_NEDENI, KAYIT_YAPAN_KUL, ACIKLAMA) " +
                                "OUTPUT INSERTED.RAPOR_INCKEY " +
                                "VALUES(@ur_inckey, @rapor_tarih, @rapor_vardiya, " +
                                "@beslenen_mik, @uretilen_mik, @fire_mik, @fire_nedeni, @iskarta_mik, " +
                                "@iskarta_nedeni, @kayit_yapan_kul, @aciklama)";
                            sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = urInckey;
                            sqlCmd.Parameters.Add("@rapor_tarih", SqlDbType.DateTime).Value = dtpRaporTarih.Value;
                            sqlCmd.Parameters.Add("@rapor_vardiya", SqlDbType.VarChar).Value = cbRaporVardiya.SelectedValue.ToString();
                            sqlCmd.Parameters.Add("@beslenen_mik", SqlDbType.Decimal).Value = beslenenMiktar;
                            sqlCmd.Parameters.Add("@uretilen_mik", SqlDbType.Decimal).Value = uretilenMiktar;
                            sqlCmd.Parameters.Add("@fire_mik", SqlDbType.Decimal).Value = decimal.Parse(txtFireMiktar.Text);
                            sqlCmd.Parameters.Add("@fire_nedeni", SqlDbType.VarChar).Value = txtFireNedeni.Text;
                            sqlCmd.Parameters.Add("@iskarta_mik", SqlDbType.Decimal).Value = decimal.Parse(txtIskartaMiktar.Text);
                            sqlCmd.Parameters.Add("@iskarta_nedeni", SqlDbType.VarChar).Value = txtIskartaNedeni.Text;
                            sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                            sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text;

                            int raporInckey = (int)sqlCmd.ExecuteScalar();

                            if (raporInckey > 0)
                            {
                                // Reduce uretilen miktar from stok
                                string getStokDepoInckeyQuery = "SELECT STOK_DEPO.STOK_DEPO_INCKEY, STOK_DEPO.MIKTAR FROM URETIM " +
                                    "INNER JOIN SIPARIS_DETAY ON SIPARIS_DETAY.SIP_DETAY_INCKEY = URETIM.SIP_DETAY_INCKEY " +
                                    "INNER JOIN STOK_DEPO ON STOK_DEPO.STOK_DEPO_INCKEY = SIPARIS_DETAY.STOK_DEPO_INCKEY " +
                                    "WHERE URETIM.UR_INCKEY = @ur_inckey";
                                sqlCmd = new SqlCommand(getStokDepoInckeyQuery, Program.connection);
                                sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = urInckey;
                                SqlDataReader reader = sqlCmd.ExecuteReader();
                                reader.Read();
                                int stokDepoInckey = (int)reader["STOK_DEPO_INCKEY"];
                                decimal initialMiktar = (decimal)reader["MIKTAR"];

                                string updateStokDepoQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar " +
                                    "WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                                sqlCmd = new SqlCommand(updateStokDepoQuery, Program.connection);
                                sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = stokDepoInckey;
                                sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = (initialMiktar - beslenenMiktar);
                                if (sqlCmd.ExecuteNonQuery() > 0)
                                {

                                    string emailOperatorler = "";
                                    int operatorCount = 0;

                                    if (operator_result.Items.Count > 0)
                                    {
                                        foreach (ListViewItem operator_result in operator_result.Items)
                                        {
                                            string operatorQuery = "INSERT INTO OPERATOR_TO_RAPOR(OP_INCKEY, RAPOR_INCKEY) VALUES (@op_inckey, @rapor_inckey)";
                                            sqlCmd = new SqlCommand(operatorQuery, Program.connection);
                                            sqlCmd.Parameters.Add("@op_inckey", SqlDbType.Int).Value = Convert.ToInt32(operator_result.Text);
                                            sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = raporInckey;
                                            sqlCmd.ExecuteNonQuery();

                                            emailOperatorler += operator_result.SubItems[operatorCount].ToString() + ", ";
                                        }
                                    }

                                    string EmailSubject = DateTime.Now.ToString("dd MMMM yyyy, dddd", CultureInfo.CreateSpecificCulture("tr-TR")) + " TARİHLİ ÜRETİM RAPORU";
                                    string EmailBody = "BESLENEN MİKTAR: " + txtBeslenenMiktar.Text + "\n" +
                                        "ÜRETİLEN MİKTAR: " + txtUretilenMiktar.Text + "\n" +
                                        "FİRE MİKTARI: " + txtFireMiktar.Text + "\n" +
                                        "FİRE NEDENİ: " + txtFireNedeni.Text + "\n" +
                                        "ISKARTA MİKTARI: " + txtIskartaMiktar.Text + "\n" +
                                        "ISKARTA NEDENİ: " + txtIskartaNedeni.Text + "\n" +
                                        "KAYIT YAPAN KULLANICI: " + Program.kullanici.Item2 + "\n" +
                                        "RAPOR TARİH: " + dtpRaporTarih.Value.ToString("dd MMMM yyyy, dddd", CultureInfo.CreateSpecificCulture("tr-TR")) + "\n" +
                                        "OPERATÖRLER: " + emailOperatorler.Substring(0, emailOperatorler.Length - 2) + "\n" +
                                        "AÇIKLAMA: " + txtAciklama.Text;

                                    Email sendingMail = new Email();
                                    string sendMail = "";
                                    if (sendingMail.MultipleEmailSend(EmailSubject, EmailBody))
                                        sendMail = " VE RAPOR MAİL'İ GÖNDERİLDİ";

                                    Notification.messageBox("RAPOR BAŞARILI BİR ŞEKİLDE OLUŞTURULDU" + sendMail);

                                    temizleBttn.PerformClick();

                                    uretimListesi.siparisListe.Clear();
                                    uretimListesi.getUretimListesi();
                                } else
                                {
                                    Notification.messageBoxError("BİR SORUN OLUŞTU.");
                                }

                            }
                        }
                        else
                        {
                            Notification.messageBoxError("PLANLANAN ÜRETİM MİKTARI AŞILAMAZ!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }
                }
                else
                {
                    Notification.messageBoxError("BESLENEN VE ÜRETİLEN MİKTAR 0'DAN BÜYÜK OLMALI !");
                }

            }
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtBeslenenMiktar.Text = "0,000";
            txtUretilenMiktar.Text = "0,000";
            txtFireMiktar.Text = "0,000";
            txtIskartaMiktar.Text = "0,000";
            txtFireNedeni.Clear();
            txtIskartaNedeni.Clear();
            txtAciklama.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RaporOlustur_Load(object sender, EventArgs e)
        {
            dtpRaporTarih.CustomFormat = "dd MMMM yyyy HH:mm";
            txtBeslenenMiktar.Text = "0,000";
            txtUretilenMiktar.Text = "0,000";
            txtFireMiktar.Text = "0,000";
            txtIskartaMiktar.Text = "0,000";

            loadVardiyaComboBox(cbRaporVardiya);

            cbRaporVardiya.SelectedIndex = 0;

            int listviewCount = 0;
            string operatorFillSQL = "SELECT * FROM OPERATOR WHERE OP_DURUMU=1";
            sqlCmd = new SqlCommand(operatorFillSQL, Program.connection);
            SqlDataReader operatorFillReader = sqlCmd.ExecuteReader();

            while (operatorFillReader.Read())
            {
                operator_list.Items.Add(operatorFillReader["OP_INCKEY"].ToString());
                operator_list.Items[listviewCount].SubItems.Add(operatorFillReader["ADSOYAD"].ToString());
                listviewCount++;
            }

            operatorFillReader.Close();
        }

        public static void loadVardiyaComboBox(ComboBox comboBox)
        {
            comboBox.DisplayMember = "Description";
            comboBox.ValueMember = "Description";
            comboBox.DataSource = Enum.GetValues(typeof(smoothsis.Services.Enums.Vardiya))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
        }

        private void btnMoveOperator_Click(object sender, EventArgs e)
        {
            ActionControl.moveOperator(operator_list, operator_result);
        }

        private void btnComeBackOperator_Click(object sender, EventArgs e)
        {
            ActionControl.moveOperator(operator_result, operator_list);
        }

        private void txtBeslenenMiktar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtBeslenenMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtBeslenenMiktar.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMATTA DEĞER GİRİLDİ !");
                txtBeslenenMiktar.Focus();
            }
        }

        private void txtUretilenMiktar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtUretilenMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtUretilenMiktar.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMATTA DEĞER GİRİLDİ !");
                txtUretilenMiktar.Focus();
            }
        }

        private void txtFireMiktar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtFireMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtFireMiktar.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMATTA DEĞER GİRİLDİ !");
                txtFireMiktar.Focus();
            }
        }

        private void txtIskartaMiktar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtIskartaMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtIskartaMiktar.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMATTA DEĞER GİRİLDİ !");
                txtIskartaMiktar.Focus();
            }
        }
    }
}
