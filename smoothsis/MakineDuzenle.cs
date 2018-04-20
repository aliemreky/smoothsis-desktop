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
    public partial class MakineDuzenle : Form
    {
        private MakineListesi makineListesi;

        public MakineDuzenle(MakineListesi makineListesi)
        {
            InitializeComponent();
            this.makineListesi = makineListesi;
        }

        private void MakineDuzenle_Load(object sender, EventArgs e)
        {
            DataGridViewCellCollection cellsOfSelectedItem = makineListesi.getSelectedItem().Item2;
            txtMakAdi.Text = cellsOfSelectedItem[1].Value.ToString();
            txtAciklama.Text = cellsOfSelectedItem[2].Value.ToString();
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = makineListesi.getDataGrid();
            int rowIndex = makineListesi.getSelectedItem().Item1;
            dataGridView[1, rowIndex].Value = txtMakAdi.Text;
            dataGridView[2, rowIndex].Value = txtAciklama.Text;
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string makAdi = txtMakAdi.Text.Trim();
            string aciklama = txtAciklama.Text.Trim();

            if (!String.IsNullOrEmpty(makAdi))
            {
                try
                {
                    string makineGuncelleSQL = "UPDATE MAKINE SET MAK_ADI = @mak_adi, ACIKLAMA = @aciklama " +
                        "WHERE MAK_INCKEY = @mak_inckey";
                    SqlCommand command = new SqlCommand(makineGuncelleSQL, Program.connection);
                    command.Parameters.Add("@mak_inckey", SqlDbType.Int).Value = (int)makineListesi.getSelectedItem().Item2[0].Value;
                    command.Parameters.Add("@mak_adi", SqlDbType.VarChar).Value = makAdi;
                    command.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = aciklama;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        updateItemOnList();
                        Notification.messageBox("Makine başarıyla güncellendi");
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, makine bilgileri kaydedilemedi");
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
                    SqlCommand command = new SqlCommand("DELETE FROM MAKINE WHERE MAK_INCKEY = @mak_inckey", Program.connection);
                    command.Parameters.Add("@mak_inckey", SqlDbType.Int).Value = (int)makineListesi.getSelectedItem().Item2[0].Value;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        makineListesi.getDataGrid().Rows.RemoveAt(makineListesi.getSelectedItem().Item1);
                        Notification.messageBox("Makine silindi");
                        this.Close();
                    }
                    else
                    {
                        Notification.messageBoxError("Bir sorun oluştu, makine silinemedi");
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