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
using System.Data.SqlClient;

namespace smoothsis
{
    public partial class StokTransfer : Form
    {
        private SqlCommand sqlCmd;
        private StokDepoListesi stokDepoListesi;
        DataGridViewCellCollection cellsOfSelectedItem;
        private int stokInckey;
        private string stokAdi;

        public StokTransfer(StokDepoListesi stokDepoListesi)
        {
            InitializeComponent();
            this.stokDepoListesi = stokDepoListesi;
            
        }

        public static DataTable getDepoOtherMYDepoDataTableForBindToComboBox(int myDepoInckey)
        {
            string query = "SELECT * FROM DEPO WHERE DEPO_INCKEY != @my_depo_inckey";
            SqlCommand command2 = new SqlCommand(query, Program.connection);
            command2.Parameters.Add("@my_depo_inckey", SqlDbType.Int).Value = myDepoInckey;
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            int sourceStokDepoInckey = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
            decimal transferMiktar = Convert.ToDecimal(txtMiktar.Text);
            int transferDepoInckey = Convert.ToInt32(cbStokDepo.SelectedValue);
            decimal remainMiktar = Convert.ToDecimal(cellsOfSelectedItem[3].Value.ToString()) - transferMiktar;
            if (remainMiktar >= 0) {
                if (remainMiktar != 0)
                {
                    string transferQuery = "INSERT INTO STOK_DEPO(STOK_INCKEY, DEPO_INCKEY, MIKTAR) VALUES(@stok_inckey, @depo_inckey, @miktar)";
                    sqlCmd = new SqlCommand(transferQuery, Program.connection);
                    sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = stokInckey;
                    sqlCmd.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = transferDepoInckey;
                    sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = transferMiktar;
                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        string updateQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                        sqlCmd = new SqlCommand(updateQuery, Program.connection);
                        sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = remainMiktar;
                        sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = sourceStokDepoInckey;
                        
                    }
                } else
                {
                    string updateJustQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                    sqlCmd = new SqlCommand(updateJustQuery, Program.connection);
                    sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = transferMiktar;
                    sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = sourceStokDepoInckey;
                }

                if (sqlCmd.ExecuteNonQuery() > 0)
                {
                    panel1.Visible = true;
                    destStokAdiLabel.Text = stokAdi;
                    destDepoNameLabel.Text = cbStokDepo.GetItemText(cbStokDepo.SelectedItem);
                    destDepoLokasyonLabel.Text = cellsOfSelectedItem[2].Value.ToString();
                    destStokMiktar.Text = transferMiktar.ToString();
                    sourceStokMiktarLabel.Text = remainMiktar.ToString();
                    Notification.messageBox("Transfer başarıyla tamamlandı.");
                    stokDepoListesi.listStokDepo();
                }
            }
            else
            {
                Notification.messageBox("Transfer edilecek miktar, asıl miktardan büyük olmamalı.");
            }

}

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtMiktar.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StokTransfer_Load(object sender, EventArgs e)
        {
            cellsOfSelectedItem = stokDepoListesi.getStokDepoSelectedItem().Item2;

            string getDepoInckeySQL = "SELECT DEPO_INCKEY, MIKTAR, STOK_ADI, STOK_DEPO.STOK_INCKEY FROM STOK_DEPO " +
                "INNER JOIN STOK ON STOK.STOK_INCKEY = STOK_DEPO.STOK_INCKEY " +
                "WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
            sqlCmd = new SqlCommand(getDepoInckeySQL, Program.connection);
            sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            int myDepoInckey = Convert.ToInt32(reader["DEPO_INCKEY"].ToString());
            decimal miktar = Convert.ToDecimal(reader["MIKTAR"].ToString());
            cbStokDepo.DataSource = getDepoOtherMYDepoDataTableForBindToComboBox(myDepoInckey);
            cbStokDepo.DisplayMember = "DEPO_ADI";
            cbStokDepo.ValueMember = "DEPO_INCKEY";
            sourceDepoNameLabel.Text = cellsOfSelectedItem[1].Value.ToString();
            sourceDepoLokasyonLabel.Text = cellsOfSelectedItem[2].Value.ToString();
            sourceStokMiktarLabel.Text = cellsOfSelectedItem[3].Value.ToString();
            stokAdi = reader["STOK_ADI"].ToString();
            sourceStokAdiLabel.Text = stokAdi;
            stokInckey = Convert.ToInt32(reader["STOK_INCKEY"].ToString());
            panel1.Visible = false;

        }
    }
}
