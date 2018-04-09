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
    public partial class IslemDuzenle : Form
    {
        private IslemListesi islemListesi;

        public IslemDuzenle(IslemListesi islemListesi)
        {
            InitializeComponent();
            this.islemListesi = islemListesi;
        }

        private void IslemDuzenle_Load(object sender, EventArgs e)
        {
            DataGridViewCellCollection cellsOfSelectedItem = islemListesi.getSelectedItem().Item2;
            txtIslemAdi.Text = cellsOfSelectedItem[1].Value.ToString();
            txtAciklama.Text = cellsOfSelectedItem[2].Value.ToString();
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = islemListesi.getDataGrid();
            int rowIndex = islemListesi.getSelectedItem().Item1;
            dataGridView[1, rowIndex].Value = txtIslemAdi.Text;
            dataGridView[2, rowIndex].Value = txtAciklama.Text;
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string islemAdi = txtIslemAdi.Text.Trim();
            string aciklama = txtAciklama.Text.Trim();

            if (!String.IsNullOrEmpty(islemAdi))
            {
                try
                {
                    string islemGuncelleSQL = "UPDATE ISLEM SET ISLEM_ADI = @islem_adi, ACIKLAMA = @aciklama " +
                        "WHERE ISLEM_INCKEY = @islem_inckey";
                    SqlCommand command = new SqlCommand(islemGuncelleSQL, Program.connection);
                    command.Parameters.Add("@islem_inckey", SqlDbType.Int).Value = (int)islemListesi.getSelectedItem().Item2[0].Value;
                    command.Parameters.Add("@islem_adi", SqlDbType.VarChar).Value = islemAdi;
                    command.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = aciklama;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        updateItemOnList();
                        Notification.messageBox("İŞLEM BAŞARIYLA GÜNCELLENDİ.");
                    }
                    else
                    {
                        Notification.messageBoxError("BİR SORUN OLUŞTU, İŞLEM GÜNCELLENEMEDİ.");
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
                    SqlCommand command = new SqlCommand("DELETE FROM ISLEM WHERE ISLEM_INCKEY = @islem_inckey", Program.connection);
                    command.Parameters.Add("@islem_inckey", SqlDbType.Int).Value = (int)islemListesi.getSelectedItem().Item2[0].Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        islemListesi.getDataGrid().Rows.RemoveAt(islemListesi.getSelectedItem().Item1);
                        Notification.messageBox("İşlem silindi.");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, işlem silinemedi.");
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