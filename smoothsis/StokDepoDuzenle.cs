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

namespace smoothsis
{
    public partial class StokDepoDuzenle : Form
    {
        private SqlCommand sqlCmd;
        private StokDepoListesi stokDepoListesi;
        private Tuple<int, DataGridViewCellCollection> selectedItem;

        public StokDepoDuzenle(StokDepoListesi stokDepoListesi)
        {
            InitializeComponent();
            this.stokDepoListesi = stokDepoListesi;
            selectedItem = this.stokDepoListesi.getStokDepoSelectedItem();
        }

        private void StokDepoDuzenle_Load(object sender, EventArgs e)
        {
            txtMiktar.Text = selectedItem.Item2[3].Value.ToString();
            txtMiktarBirim.Text = selectedItem.Item2[5].Value.ToString();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMiktar.Text))
            {
                bool decimalControl = false;
                try
                {
                    txtMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtMiktar.Text));
                    decimalControl = true;
                }
                catch
                {
                    Notification.messageBox("YANLIŞ FORMATTA DEĞER GİRİLDİ");
                    txtMiktar.Focus();
                    decimalControl = false;
                }

                if (decimalControl)
                {

                    try
                    {
                        string stokDepoUpdateSQL = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                        sqlCmd = new SqlCommand(stokDepoUpdateSQL, Program.connection);
                        sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = Convert.ToUInt32(selectedItem.Item2[0].Value.ToString());
                        sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = decimal.Parse(txtMiktar.Text);

                        if (sqlCmd.ExecuteNonQuery() > 0)
                        {
                            updateItemOnList();
                            Notification.messageBox("STOK DEPO BAŞARIYLA GÜNCELLENDİ.");
                        }
                        else
                        {
                            Notification.messageBoxError("BİR SORUN OLUŞTU, STOK DEPO GÜNCELLENEMEDİ !");
                        }
                    }
                    catch (Exception ex)
                    {
                        Notification.messageBoxError(ex.Message);
                    }
                }
            }
            else
            {
                Notification.messageBoxError("LÜTFEN *'LI ALANLARI BOŞ BIRAKMAYINIZ !");
            }
        }

        public void updateItemOnList()
        {
            DataGridView dataGridView = stokDepoListesi.getDataGrid();
            int rowIndex = selectedItem.Item1;
            dataGridView[3, rowIndex].Value = txtMiktar.Text;
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtMiktar.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForDecimal(sender, e);
        }
    }
}
