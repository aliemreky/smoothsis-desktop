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
    public partial class IslemOlustur : Form
    {
        private SqlCommand sqlCmd;

        public IslemOlustur()
        {
            InitializeComponent();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string islemAdi = txtIslemAdi.Text.Trim();
            string aciklama = txtAciklama.Text.Trim();

            if (!String.IsNullOrEmpty(islemAdi))
            {
                try
                {
                    sqlCmd = new SqlCommand("INSERT INTO ISLEM(ISLEM_ADI, ACIKLAMA)" +
                        " VALUES(@islem_adi, @aciklama)", Program.connection);
                    sqlCmd.Parameters.Add("@islem_adi", SqlDbType.VarChar).Value = islemAdi;
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = aciklama;
                    int affectedRows = sqlCmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Notification.messageBox("İşlem oluşturuldu.");
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

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtIslemAdi.Clear();
            txtAciklama.Clear();
        }
    }
}