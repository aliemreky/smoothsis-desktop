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
using smoothsis.Services.Enums;

namespace smoothsis
{
    public partial class OperatorDuzenle : Form
    {
        private OperatorListesi operatorListesi;

        public OperatorDuzenle(OperatorListesi operatorListesi)
        {
            InitializeComponent();
            this.operatorListesi = operatorListesi;
        }

        private void OperatorDuzenle_Load(object sender, EventArgs e)
        {
            cbOperatorDurum.DataSource = Enum.GetValues(typeof(Condition));
            DataGridViewCellCollection cellsOfSelectedItem = operatorListesi.getSelectedItem().Item2;
            txtOperatorAdiSoyadi.Text = cellsOfSelectedItem[1].Value.ToString();
            cbOperatorDurum.SelectedIndex = cbOperatorDurum.FindString(cellsOfSelectedItem[2].Value.ToString());
            dtpIseBaslamaTarih.Value = DateTime.Parse(cellsOfSelectedItem[3].Value.ToString());
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = operatorListesi.getDataGrid();
            int rowIndex = operatorListesi.getSelectedItem().Item1;
            dataGridView[1, rowIndex].Value = txtOperatorAdiSoyadi.Text;
            dataGridView[2, rowIndex].Value = cbOperatorDurum.SelectedValue;
            dataGridView[3, rowIndex].Value = dtpIseBaslamaTarih.Value;
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string adiSoyadi = txtOperatorAdiSoyadi.Text.Trim();
            int op_durumu = (int)cbOperatorDurum.SelectedValue;

            if (!String.IsNullOrEmpty(adiSoyadi))
            {
                try
                {
                    string makineGuncelleSQL = "UPDATE OPERATOR SET ADSOYAD = @ad_soyad, OP_DURUMU = @op_durumu, ISE_BAS_TARIH = @ise_bas_tarih " +
                        "WHERE OP_INCKEY = @op_inckey";
                    SqlCommand command = new SqlCommand(makineGuncelleSQL, Program.connection);
                    command.Parameters.Add("@op_inckey", SqlDbType.Int).Value = (int)operatorListesi.getSelectedItem().Item2[0].Value;
                    command.Parameters.Add("@ad_soyad", SqlDbType.VarChar).Value = adiSoyadi;
                    command.Parameters.Add("@op_durumu", SqlDbType.Bit).Value = op_durumu;
                    command.Parameters.Add("@ise_bas_tarih", SqlDbType.Date).Value = dtpIseBaslamaTarih.Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        updateItemOnList();
                        Notification.messageBox("OPERATÖR BAŞARIYLA GÜNCELLENDİ.");
                    }
                    else
                    {
                        Notification.messageBoxError("BİR SORUN OLUŞTU, OPERATÖR GÜNCELLENEMEDİ.");
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
            else
            {
                Notification.messageBox("Lütfen zorunlu alanları boş geçmeyin.");
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sillBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM OPERATOR WHERE OP_INCKEY = @op_inckey", Program.connection);
                    command.Parameters.Add("@op_inckey", SqlDbType.Int).Value = (int)operatorListesi.getSelectedItem().Item2[0].Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        operatorListesi.getDataGrid().Rows.RemoveAt(operatorListesi.getSelectedItem().Item1);
                        Notification.messageBox("Operatör silindi.");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, operatör silinemedi.");
                    }
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Source);
            }
        }
    }
}