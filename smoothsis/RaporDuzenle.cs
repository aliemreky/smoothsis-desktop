using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smoothsis.Services;
using smoothsis.Services.Enums;
using System.Data.SqlClient;

namespace smoothsis
{
    public partial class RaporDuzenle : Form
    {
        private SqlCommand sqlCmd;
        private RaporListesi raporListesi;
        private DataGridViewCellCollection cellsOfSelectedItem;
        private List<Operator> selectedOperators = new List<Operator>();
        private List<Operator> deletedOperators = new List<Operator>();
        private string[] selectedUretim;
        private bool isFirstAdding = true;

        public RaporDuzenle(RaporListesi raporListesi)
        {
            InitializeComponent();
            this.raporListesi = raporListesi;
        }

        private void RaporDuzenle_Load(object sender, EventArgs e)
        {
            RaporOlustur.loadVardiyaComboBox(cbRaporVardiya);
            this.cellsOfSelectedItem = raporListesi.getSelectedItem().Item2;
            initializeOperator();
            initializeUretim();
            loadRaporInfos();
            deletedOperators.AddRange(selectedOperators);
        }

        private void loadRaporInfos()
        {
            txtUretim.Text = selectedUretim[4];
            foreach(Operator oprtr in selectedOperators)
            {
                txtOperator.Text += oprtr.getAdSoyad() + ", ";
            }
            dtpRaporTarih.Value = DateTime.Parse(cellsOfSelectedItem[2].Value.ToString());
            cbRaporVardiya.SelectedIndex = cbRaporVardiya.FindString(cellsOfSelectedItem[3].Value.ToString());
            txtBeslenenMiktar.Text = cellsOfSelectedItem[4].Value.ToString();
            txtUretilenMiktar.Text = cellsOfSelectedItem[5].Value.ToString();
            txtFireMiktar.Text = cellsOfSelectedItem[6].Value.ToString();
            txtFireNedeni.Text = cellsOfSelectedItem[7].Value.ToString();
            txtIskartaMiktar.Text = cellsOfSelectedItem[8].Value.ToString();
            txtIskartaNedeni.Text = cellsOfSelectedItem[9].Value.ToString();
            txtAciklama.Text = cellsOfSelectedItem[10].Value.ToString();
        }

        private void initializeOperator()
        {
            string query = "SELECT OPERATOR.OP_INCKEY, OPERATOR.ADSOYAD ADI_SOYADI, FORMAT(OPERATOR.ISE_BAS_TARIH, 'dd.MM.yyyy') ISE_BASLAMA_TARIHI, CASE WHEN OPERATOR.OP_DURUMU = 1 THEN 'Aktif' ELSE 'Pasif' END AS OPERATOR_DURUMU " +
                "FROM OPERATOR_TO_RAPOR " +
                "INNER JOIN OPERATOR ON OPERATOR_TO_RAPOR.OP_INCKEY = OPERATOR.OP_INCKEY " +
                "WHERE OPERATOR_TO_RAPOR.RAPOR_INCKEY = @rapor_inckey";
            sqlCmd = new SqlCommand(query, Program.connection);
            sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                selectedOperators.Add(new Operator(
                    reader["OP_INCKEY"].ToString(),
                    reader["ADI_SOYADI"].ToString(),
                    reader["ISE_BASLAMA_TARIHI"].ToString(),
                    reader["OPERATOR_DURUMU"].ToString()
                ));
            }
        }

        private void initializeUretim()
        {
            string query = "SELECT * FROM URETIM " +
                " WHERE UR_INCKEY = @ur_inckey";
            sqlCmd = new SqlCommand(query, Program.connection);
            sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[1].Value.ToString());
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            this.selectedUretim = new string[]{
                    reader["UR_INCKEY"].ToString(),
                    reader["SIP_DETAY_INCKEY"].ToString(),
                    reader["ISLEM_INCKEY"].ToString(),
                    reader["MAKINE_INCKEY"].ToString(),
                    reader["ISLEM_NO"].ToString()
            };
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (isFirstAdding)
            {
                selectedOperators.Clear();
                txtOperator.Clear();
                isFirstAdding = false;
            }

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
                
                } else
                {
                    Notification.messageBoxError("BU OPERATÖR EKLENMİŞ DURUMDA.");
                }
            }
            else
            {
                Notification.messageBoxError("ÜZERİNE RAPOR OLUŞTURULAN OPERATÖR AKTiF DEĞİL.");
            }
        }

        private void deleteBeforeOperatorsFromRapor()
        {
            int count = deletedOperators.Count();
            if (count > 0)
            {
                try
                {
                    string query = "DELETE FROM OPERATOR_TO_RAPOR WHERE RAPOR_INCKEY = " + (Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString())) + " AND OP_INCKEY IN (";

                    foreach (Operator oprtr in deletedOperators)
                    {
                        count--;
                        query += Convert.ToInt32(oprtr.getOpInckey()) + (count == 0 ? "" : ", ");
                    }

                    query += ")";
                    sqlCmd = new SqlCommand(query, Program.connection);
                    sqlCmd.ExecuteNonQuery();
                } catch(Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
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

        private void sillBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlCmd = new SqlCommand("DELETE FROM RAPOR WHERE RAPOR_INCKEY = @rapor_inckey", Program.connection);
                    sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = (int)cellsOfSelectedItem[0].Value;
                    int affectedRows = sqlCmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        raporListesi.getDataGrid().Rows.RemoveAt(raporListesi.getSelectedItem().Item1);
                        Notification.messageBox("Rapor Başarıyla Silindi");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, rapor silinemedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Source);
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    sqlCmd.CommandText = "UPDATE RAPOR SET " +
                        "UR_INCKEY = @ur_inckey, RAPOR_TARIH = @rapor_tarih, RAPOR_VARDIYA = @rapor_vardiya, " +
                        "BESLENEN_MIK = @beslenen_mik, URETILEN_MIK = @uretilen_mik, FIRE_MIK = @fire_mik, " +
                        "FIRE_NEDENI = @fire_nedeni, ISKARTA_MIK = @iskarta_mik, " +
                        "ISKARTA_NEDENI = @iskarta_nedeni, DUZELTME_YAPAN_KUL = @duzeltme_yapan_kul, DUZELTME_TARIH = @duzeltme_tarih, ACIKLAMA = @aciklama " +
                        "WHERE RAPOR_INCKEY = @rapor_inckey";
                    sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
                    sqlCmd.Parameters.Add("@ur_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedUretim[0]);
                    sqlCmd.Parameters.Add("@rapor_tarih", SqlDbType.Date).Value = dtpRaporTarih.Value;
                    sqlCmd.Parameters.Add("@rapor_vardiya", SqlDbType.VarChar).Value = cbRaporVardiya.SelectedValue.ToString();
                    sqlCmd.Parameters.Add("@beslenen_mik", SqlDbType.Decimal).Value = decimal.Parse(txtBeslenenMiktar.Text);
                    sqlCmd.Parameters.Add("@uretilen_mik", SqlDbType.Decimal).Value = decimal.Parse(txtUretilenMiktar.Text);
                    sqlCmd.Parameters.Add("@fire_mik", SqlDbType.Decimal).Value = decimal.Parse(txtFireMiktar.Text);
                    sqlCmd.Parameters.Add("@fire_nedeni", SqlDbType.VarChar).Value = txtFireNedeni.Text;
                    sqlCmd.Parameters.Add("@iskarta_mik", SqlDbType.Decimal).Value = decimal.Parse(txtIskartaMiktar.Text);
                    sqlCmd.Parameters.Add("@iskarta_nedeni", SqlDbType.VarChar).Value = txtIskartaNedeni.Text;
                    sqlCmd.Parameters.Add("@duzeltme_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    sqlCmd.Parameters.Add("@duzeltme_tarih", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = txtAciklama.Text;

                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        deleteBeforeOperatorsFromRapor();
                        List<int> okeys = new List<int>();
                        foreach (Operator selectedOperator in selectedOperators)
                        {
                            string query = "INSERT INTO OPERATOR_TO_RAPOR(OP_INCKEY, RAPOR_INCKEY) " +
                                "VALUES(@op_inckey, @rapor_inckey)";
                            sqlCmd = new SqlCommand(query, Program.connection);
                            sqlCmd.Parameters.Add("@op_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedOperator.getOpInckey());
                            sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
                            int state = sqlCmd.ExecuteNonQuery();
                            okeys.Add(state);
                        }

                        if (!okeys.Contains(0))
                        {
                            updateItemOnList();
                            Notification.messageBox("RAPOR BAŞARILI BİR ŞEKİLDE GÜNCELLENDİ.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = raporListesi.getDataGrid();
            int rowIndex = raporListesi.getSelectedItem().Item1;
            dataGridView[1, rowIndex].Value = selectedUretim[0];
            dataGridView[2, rowIndex].Value = dtpRaporTarih.Value;
            dataGridView[3, rowIndex].Value = cbRaporVardiya.SelectedValue;
            dataGridView[4, rowIndex].Value = txtBeslenenMiktar.Text;
            dataGridView[5, rowIndex].Value = txtUretilenMiktar.Text;
            dataGridView[6, rowIndex].Value = txtFireMiktar.Text;
            dataGridView[7, rowIndex].Value = txtFireNedeni.Text;
            dataGridView[8, rowIndex].Value = txtIskartaMiktar.Text;
            dataGridView[9, rowIndex].Value = txtIskartaNedeni.Text;
            dataGridView[10, rowIndex].Value = txtAciklama.Text;
            dataGridView[13, rowIndex].Value = Program.kullanici.Item2;
            dataGridView[14, rowIndex].Value = DateTime.Now.ToString("dd.MM.yyyy");
        }
    }
}
