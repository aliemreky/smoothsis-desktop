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
    public partial class DepoOlustur : Form
    {
        public DepoOlustur()
        {
            InitializeComponent();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string depoAdi = txtDepoAdi.Text.Trim();
            string depoLokasyon = txtDepoLokasyon.Text.Trim();

            if (!String.IsNullOrEmpty(depoAdi) && !String.IsNullOrEmpty(depoLokasyon))
            {
                try
                {
                    SqlCommand command = new SqlCommand("INSERT INTO DEPO(DEPO_ADI, DEPO_LOKASYON, KAYIT_YAPAN_KUL)" +
                        " VALUES(@depo_adi, @depo_lokasyon, @kayit_yapan_kul)", Program.connection);
                    command.Parameters.Add("@depo_adi", SqlDbType.VarChar).Value = depoAdi;
                    command.Parameters.Add("@depo_lokasyon", SqlDbType.VarChar).Value = depoLokasyon;
                    command.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                    int affectedRows = command.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Notification.messageBox("Depo oluşturuldu.");
                        this.Close();
                    }
                }
                catch
                {
                    Notification.messageBoxError("Bir sorun oluştu, Depo oluşturulamadı.");
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
            txtDepoAdi.Clear();
            txtDepoLokasyon.Clear();
        }
    }
}
