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

namespace smoothsis
{
    public partial class RaporOlustur : Form
    {
        private SqlCommand sqlCmd;
        private List<Operator> selectedOperators = new List<Operator>();
        private string[] selectedUretim;

        public RaporOlustur()
        {
            InitializeComponent();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            OperatorListesi operatorListesi = new OperatorListesi(this);
            operatorListesi.ShowDialog();
        }

        public void addOperatorToRapor(DataGridViewCellCollection selectedOperator)
        {
            if (selectedOperator[3].Value.ToString().Equals("Aktif"))
            {
                Operator oprtr = new Operator(
                    selectedOperator[0].Value.ToString(),
                    selectedOperator[1].Value.ToString(),
                    selectedOperator[2].Value.ToString(),
                    selectedOperator[3].Value.ToString()
                );

                if (!selectedOperators.Contains(oprtr))
                {
                    selectedOperators.Add(oprtr);
                    txtOperator.Text += selectedOperator[1].Value.ToString() + ", ";

                }
                else
                {
                    Notification.messageBoxError("BU OPERATÖR EKLENMİŞ DURUMDA.");
                }
            }
            else
            {
                Notification.messageBoxError("ÜZERİNE RAPOR OLUŞTURULAN OPERATÖR AKTiF DEĞİL.");
            }
        }

        public void addUretimToRapor(DataGridViewCellCollection selectedUretim)
        {

        }

        private void btnUretim_Click(object sender, EventArgs e)
        {
            this.selectedUretim = new string[]{
                "3",
                "1",
                "1",
                "1",
                "123"
            };
            txtUretim.Text = selectedUretim[4];
        }

        private void decimalValidate(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForDecimal(sender, e);
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUretim.Text) ||
                String.IsNullOrEmpty(txtOperator.Text) ||
                String.IsNullOrEmpty(cbRaporVardiya.SelectedValue.ToString()) ||
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
                try
                {
                    sqlCmd = Program.connection.CreateCommand();
                    sqlCmd.CommandText = "INSERT INTO " +
                        "RAPOR(UR_INCKEY, RAPOR_TARIH, RAPOR_VARDIYA, " +
                        "BESLENEN_MIK, URETILEN_MIK, FIRE_MIK, FIRE_NEDENI, ISKARTA_MIK, " +
                        "ISKARTA_NEDENI, KAYIT_YAPAN_KUL, ACIKLAMA) " +
                        "OUTPUT INSERTED.RAPOR_INCKEY " +
                        "VALUES(@ur_inckey, @rapor_tarih, @rapor_vardiya, " +
                        "@beslenen_mik, @uretilen_mik, @fire_mik, @fire_nedeni, @iskarta_mik, " +
                        "@iskarta_nedeni, @kayit_yapan_kul, @aciklama)";
                    sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedUretim[0]);
                    sqlCmd.Parameters.Add("@rapor_tarih", SqlDbType.Date).Value = dtpRaporTarih.Value;
                    sqlCmd.Parameters.Add("@rapor_vardiya", SqlDbType.VarChar).Value = cbRaporVardiya.SelectedValue.ToString();
                    sqlCmd.Parameters.Add("@beslenen_mik", SqlDbType.Decimal).Value = decimal.Parse(txtBeslenenMiktar.Text);
                    sqlCmd.Parameters.Add("@uretilen_mik", SqlDbType.Decimal).Value = decimal.Parse(txtUretilenMiktar.Text);
                    sqlCmd.Parameters.Add("@fire_mik", SqlDbType.Decimal).Value = decimal.Parse(txtFireMiktar.Text);
                    sqlCmd.Parameters.Add("@fire_nedeni", SqlDbType.VarChar).Value = txtFireNedeni.Text;
                    sqlCmd.Parameters.Add("@iskarta_mik", SqlDbType.Decimal).Value = decimal.Parse(txtIskartaMiktar.Text);
                    sqlCmd.Parameters.Add("@iskarta_nedeni", SqlDbType.VarChar).Value = txtIskartaNedeni.Text;
                    sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text;

                    int raporInckey = (int)sqlCmd.ExecuteScalar();

                    if (raporInckey > 0)
                    {
                        List<int> okeys = new List<int>();
                        foreach (Operator selectedOperator in selectedOperators)
                        {
                            string query = "INSERT INTO OPERATOR_TO_RAPOR(OP_INCKEY, RAPOR_INCKEY) " +
                                "VALUES(@op_inckey, @rapor_inckey)";
                            sqlCmd = new SqlCommand(query, Program.connection);
                            sqlCmd.Parameters.Add("@op_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedOperator.getOpInckey());
                            sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = raporInckey;
                            int state = sqlCmd.ExecuteNonQuery();
                            okeys.Add(state);
                        }

                        if (!okeys.Contains(0))
                        {
                            Notification.messageBox("RAPOR BAŞARILI BİR ŞEKİLDE OLUŞTURULDU.");
                        }
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
            txtUretim.Clear();
            txtOperator.Clear();
            txtBeslenenMiktar.Clear();
            txtUretilenMiktar.Clear();
            txtFireMiktar.Clear();
            txtIskartaMiktar.Clear();
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
            loadVardiyaComboBox(cbRaporVardiya);
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
    }
}
