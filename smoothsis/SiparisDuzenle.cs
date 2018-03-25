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
    public partial class SiparisDuzenle : Form
    {
        private int SiparisId;
        private SqlCommand sqlCmd;

        public SiparisDuzenle(int siparisId)
        {
            InitializeComponent();
            SiparisId = siparisId;
        }

        private void SiparisDuzenle_Load(object sender, EventArgs e)
        {
            try
            {

                string SiparisBilgileriSQL = "SELECT * FROM SIPARIS WHERE SIPARIS_INCKEY=@siparis_inckey";
                sqlCmd = new SqlCommand(SiparisBilgileriSQL, Program.connection);
                sqlCmd.Parameters.AddWithValue("@siparis_inckey", SiparisId);
                

            }
            catch (Exception ex)
            {
                Notification.messageBox(ex.Message);
            }
        }
    }
}
