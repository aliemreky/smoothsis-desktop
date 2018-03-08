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
    public partial class DepoDuzenle : Form
    {
        private DepoListesi depoListesi;

        public DepoDuzenle(DepoListesi depoListesi)
        {
            InitializeComponent();
            this.depoListesi = depoListesi;
        }

        private void DepoDuzenle_Load(object sender, EventArgs e)
        {
            DataGridViewCellCollection cellsOfSelectedItem = depoListesi.getSelectedItem().Item2;
            txtDepoAdi.Text = cellsOfSelectedItem[1].Value.ToString();
            txtDepoLokasyon.Text = cellsOfSelectedItem[2].Value.ToString();
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = depoListesi.getDataGrid();
            int rowIndex = depoListesi.getSelectedItem().Item1;
            dataGridView[1, rowIndex].Value = txtDepoAdi.Text;
            dataGridView[2, rowIndex].Value = txtDepoLokasyon.Text;
            dataGridView[5, rowIndex].Value = Program.kullanici.Item2;
            dataGridView[6, rowIndex].Value = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string depoAdi = txtDepoAdi.Text.Trim();
            string depoLokasyon = txtDepoLokasyon.Text.Trim();

            if (!String.IsNullOrEmpty(depoAdi) && !String.IsNullOrEmpty(depoLokasyon))
            {
                try
                {
                    SqlCommand command = new SqlCommand("UPDATE DEPO SET " +
                        " DEPO_ADI = @depo_adi, DEPO_LOKASYON = @depo_lokasyon, DUZELTME_YAPAN_KUL = @duzeltme_yapan_kul, DUZELTME_TARIH = @duzeltme_tarih " +
                        "WHERE DEPO_INCKEY = @depo_inckey", Program.connection);
                    command.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = (int)depoListesi.getSelectedItem().Item2[0].Value;
                    command.Parameters.Add("@depo_adi", SqlDbType.VarChar).Value = depoAdi;
                    command.Parameters.Add("@depo_lokasyon", SqlDbType.VarChar).Value = depoLokasyon;
                    command.Parameters.Add("@duzeltme_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    command.Parameters.Add("@duzeltme_tarih", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        updateItemOnList();
                        Notification.messageBox("DEPO BAŞARIYLA GÜNCELLENDİ.");
                    }
                    else
                    {
                        Notification.messageBoxError("BİR SORUN OLUŞTU, DEPO GÜNCELLENEMEDİ");
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
                    SqlCommand command = new SqlCommand("DELETE FROM DEPO WHERE DEPO_INCKEY = @depo_inckey", Program.connection);
                    command.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = (int)depoListesi.getSelectedItem().Item2[0].Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        depoListesi.getDataGrid().Rows.RemoveAt(depoListesi.getSelectedItem().Item1);
                        Notification.messageBox("Depo silindi.");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, depo silinemedi.");
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
