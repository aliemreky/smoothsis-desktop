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
    public partial class MakineOlustur : Form
    {
        private SqlCommand sqlCmd;
        public MakineOlustur()
        {
            InitializeComponent();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string makAdi = txtMakAdi.Text.Trim();
            string aciklama = txtAciklama.Text.Trim();

            if (!String.IsNullOrEmpty(makAdi))
            {
                try
                {
                    sqlCmd = new SqlCommand("INSERT INTO MAKINE(MAK_ADI, ACIKLAMA)" +
                        " VALUES(@mak_adi, @aciklama)", Program.connection);
                    sqlCmd.Parameters.Add("@mak_adi", SqlDbType.VarChar).Value = makAdi;
                    sqlCmd.Parameters.Add("@aciklama", SqlDbType.VarChar).Value = aciklama;
                    int affectedRows = sqlCmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Notification.messageBox("Makina oluşturuldu.");
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
            txtMakAdi.Clear();
            txtAciklama.Clear();
        }

        private void MakineOlustur_Load(object sender, EventArgs e)
        {

        }
    }
}
