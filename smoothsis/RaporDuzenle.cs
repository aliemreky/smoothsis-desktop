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
using System.Collections;

namespace smoothsis
{
    public partial class RaporDuzenle : Form
    {
        private SqlCommand sqlCmd;
        private RaporListesi raporListesi;
        private DataGridViewCellCollection cellsOfSelectedItem;

        private List<string> kayitliOperatorler = new List<string>();

        public RaporDuzenle(RaporListesi raporListesi)
        {
            InitializeComponent();
            this.raporListesi = raporListesi;
        }

        private void RaporDuzenle_Load(object sender, EventArgs e)
        {
            RaporOlustur.loadVardiyaComboBox(cbRaporVardiya);
            this.cellsOfSelectedItem = raporListesi.getSelectedItem().Item2;
            loadRaporInfos();
        }

        private void loadRaporInfos()
        {
            // OPERATÖR BİLGİLERİNİN GİRİLMESİ
            int operatorListCount = 0;
            string raporOperatorlerSQL = "SELECT OP.OP_INCKEY, OP.ADSOYAD FROM OPERATOR_TO_RAPOR OPRP " +
                "JOIN OPERATOR OP ON OP.OP_INCKEY = OPRP.OP_INCKEY " +
                "WHERE OPRP.RAPOR_INCKEY = @rapor_inckey AND OP.OP_DURUMU=1";
            sqlCmd = new SqlCommand(raporOperatorlerSQL, Program.connection);
            sqlCmd.Parameters.AddWithValue("@rapor_inckey", cellsOfSelectedItem[0].Value.ToString());
            SqlDataReader operatorResultReader = sqlCmd.ExecuteReader();

            while (operatorResultReader.Read())
            {
                operator_result.Items.Add(operatorResultReader["OP_INCKEY"].ToString());
                operator_result.Items[operatorListCount].SubItems.Add(operatorResultReader["ADSOYAD"].ToString());
                kayitliOperatorler.Add(operatorResultReader["OP_INCKEY"].ToString());

                operatorListCount++;
            }

            operatorResultReader.Close();

            operatorListCount = 0;
            string operatorSQL = "SELECT * FROM OPERATOR WHERE OP_DURUMU=1";
            sqlCmd = new SqlCommand(operatorSQL, Program.connection);
            SqlDataReader operatorListReader = sqlCmd.ExecuteReader();

            while (operatorListReader.Read())
            {
                if (!kayitliOperatorler.Contains(operatorListReader["OP_INCKEY"].ToString()))
                {
                    operator_list.Items.Add(operatorListReader["OP_INCKEY"].ToString());
                    operator_list.Items[operatorListCount].SubItems.Add(operatorListReader["ADSOYAD"].ToString());
                    operatorListCount++;
                }
            }

            operatorListReader.Close();

            dtpRaporTarih.Value = DateTime.Parse(cellsOfSelectedItem[2].Value.ToString());
            cbRaporVardiya.SelectedIndex = cbRaporVardiya.FindString(cellsOfSelectedItem[3].Value.ToString());
            txtBeslenenMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(cellsOfSelectedItem[4].Value.ToString())); 
            txtUretilenMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(cellsOfSelectedItem[5].Value.ToString()));
            txtFireMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(cellsOfSelectedItem[6].Value.ToString()));
            txtFireNedeni.Text = cellsOfSelectedItem[7].Value.ToString();
            txtIskartaMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(cellsOfSelectedItem[8].Value.ToString()));
            txtIskartaNedeni.Text = cellsOfSelectedItem[9].Value.ToString();
            txtAciklama.Text = cellsOfSelectedItem[10].Value.ToString();
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
                        Notification.messageBoxError("Bir sorun oluştu, rapor silinemedi !");
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
                if (decimal.Parse(txtBeslenenMiktar.Text) > 0 || decimal.Parse(txtUretilenMiktar.Text) > 0)
                {
                    try
                    {
                        sqlCmd = Program.connection.CreateCommand();
                        sqlCmd.CommandText = "UPDATE RAPOR SET " +
                            "RAPOR_TARIH = @rapor_tarih, RAPOR_VARDIYA = @rapor_vardiya, " +
                            "BESLENEN_MIK = @beslenen_mik, URETILEN_MIK = @uretilen_mik, FIRE_MIK = @fire_mik, " +
                            "FIRE_NEDENI = @fire_nedeni, ISKARTA_MIK = @iskarta_mik, " +
                            "ISKARTA_NEDENI = @iskarta_nedeni, DUZELTME_YAPAN_KUL = @duzeltme_yapan_kul, DUZELTME_TARIH = @duzeltme_tarih, ACIKLAMA = @aciklama " +
                            "WHERE RAPOR_INCKEY = @rapor_inckey";
                        sqlCmd.Parameters.Add("@rapor_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
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
                            foreach (ListViewItem list_item in operator_list.Items)
                            {
                                string operatorDeleteSQL = "SELECT COUNT(*) FROM OPERATOR_TO_RAPOR WHERE OP_INCKEY=@op_inckey AND RAPOR_INCKEY=@rapor_inckey";
                                sqlCmd = new SqlCommand(operatorDeleteSQL, Program.connection);
                                sqlCmd.Parameters.AddWithValue("@rapor_inckey", Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString()));
                                sqlCmd.Parameters.AddWithValue("@op_inckey", Convert.ToInt32(list_item.Text));
                                int affectedRecordDelete = Convert.ToInt32(sqlCmd.ExecuteScalar());
                                if (affectedRecordDelete != 0)
                                {
                                    string deleteExecute = "DELETE FROM OPERATOR_TO_RAPOR WHERE OP_INCKEY=@op_inckey AND RAPOR_INCKEY=@rapor_inckey";
                                    sqlCmd.Parameters.AddWithValue("@rapor_inckey", Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString()));
                                    sqlCmd.Parameters.AddWithValue("@op_inckey", Convert.ToInt32(list_item.Text));
                                    sqlCmd = new SqlCommand(deleteExecute, Program.connection);
                                    sqlCmd.ExecuteNonQuery();
                                }
                            }

                            if (operator_result.Items.Count > 0)
                            {
                                foreach (ListViewItem result_item in operator_result.Items)
                                {
                                    string operatorInsertSQL = "SELECT COUNT(*) FROM OPERATOR_TO_RAPOR WHERE OP_INCKEY=@op_inckey AND RAPOR_INCKEY=@rapor_inckey";
                                    sqlCmd = new SqlCommand(operatorInsertSQL, Program.connection);
                                    sqlCmd.Parameters.AddWithValue("@rapor_inckey", Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString()));
                                    sqlCmd.Parameters.AddWithValue("@op_inckey", Convert.ToInt32(result_item.Text));
                                    int affectedRecordInsert = Convert.ToInt32(sqlCmd.ExecuteScalar());
                                    if (affectedRecordInsert == 0)
                                    {
                                        string insertExecute = "INSERT INTO OPERATOR_TO_RAPOR(OP_INCKEY, RAPOR_INCKEY) VALUES (@op_inckey, @rapor_inckey)";
                                        sqlCmd.Parameters.AddWithValue("@rapor_inckey", Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString()));
                                        sqlCmd.Parameters.AddWithValue("@op_inckey", Convert.ToInt32(result_item.Text));
                                        sqlCmd = new SqlCommand(insertExecute, Program.connection);
                                        sqlCmd.ExecuteNonQuery();
                                    }
                                }
                            }                            

                            Notification.messageBox("RAPOR BAŞARIYLA DÜZENLENDİ");
                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }

                }
            }
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = raporListesi.getDataGrid();
            int rowIndex = raporListesi.getSelectedItem().Item1;
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

        private void decimalValidate(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForDecimal(sender, e);
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
