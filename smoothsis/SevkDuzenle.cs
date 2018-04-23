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
    public partial class SevkDuzenle : Form
    {
        private SqlCommand sqlCmd;
        private SevkListesi sevkListesi;
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public SevkDuzenle(SevkListesi sevkListesi, Tuple<int, DataGridViewCellCollection> selectedItem)
        {
            InitializeComponent();
            this.sevkListesi = sevkListesi;
            this.selectedItem = selectedItem;
        }

        private void silBttn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand command = new SqlCommand("DELETE FROM SEVK WHERE SEVK_INCKEY = @sevk_inckey", Program.connection);
                    command.Parameters.Add("@sevk_inckey", SqlDbType.Int).Value = (int)selectedItem.Item2[0].Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        sevkListesi.getDataGrid().Rows.RemoveAt(selectedItem.Item1);
                        Notification.messageBox("Sevk Başarıyla Silindi");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, sevk silinemedi.");
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

        private void SevkDuzenle_Load(object sender, EventArgs e)
        {
            txtSiparisKod.Text = selectedItem.Item2[2].Value.ToString();
            txtIrsaliyeNo.Text = selectedItem.Item2[3].Value.ToString();
            txtSevkMiktari.Text = selectedItem.Item2[4].Value.ToString() + " " + selectedItem.Item2[5].Value.ToString();
            dtpSevkTarih.Value = DateTime.Parse(selectedItem.Item2[6].Value.ToString());
            txtSevkNotu.Text = selectedItem.Item2[7].Value.ToString();
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
                    string sevkGuncelleSQL = "UPDATE SEVK " +
                        "SET IRSALIYE_NO = @irsaliye_no, " +
                        "SEVK_TARIH = @sevk_tarih, SEVK_NOT = @sevk_not " +
                        "WHERE SEVK_INCKEY = @sevk_inckey";
                    sqlCmd = new SqlCommand(sevkGuncelleSQL, Program.connection);
                    sqlCmd.Parameters.Add("@sevk_inckey", SqlDbType.Int).Value = Convert.ToInt32(selectedItem.Item2[0].Value.ToString());
                    sqlCmd.Parameters.Add("@irsaliye_no", SqlDbType.VarChar).Value = txtIrsaliyeNo.Text;
                    sqlCmd.Parameters.Add("@sevk_tarih", SqlDbType.Date).Value = dtpSevkTarih.Value;
                    sqlCmd.Parameters.Add("@sevk_not", SqlDbType.VarChar).Value = txtSevkNotu.Text;
                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        updateItemOnList();
                        Notification.messageBox("SEVK BAŞARIYLA GÜNCELLENDİ.");
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
            DataGridView dataGridView = sevkListesi.getDataGrid();
            int rowIndex = selectedItem.Item1;
            dataGridView[3, rowIndex].Value = txtIrsaliyeNo.Text;
            dataGridView[6, rowIndex].Value = dtpSevkTarih.Value;
            dataGridView[7, rowIndex].Value = txtSevkNotu.Text;
        }
    }
}
