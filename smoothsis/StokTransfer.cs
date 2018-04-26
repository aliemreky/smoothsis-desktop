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
    public partial class StokTransfer : Form
    {
        private SqlCommand sqlCmd;
        private StokDepoListesi stokDepoListesi;
        private DepoStokListesi depoStokListesi = null;
        DataGridViewCellCollection cellsOfSelectedItem;
        private int stokInckey;
        private string stokAdi;

        public StokTransfer(StokDepoListesi stokDepoListesi)
        {
            InitializeComponent();
            this.stokDepoListesi = stokDepoListesi;
            
        }

        public StokTransfer(DepoStokListesi depoStokListesi)
        {
            InitializeComponent();
            this.depoStokListesi = depoStokListesi;

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
            int sourceDepoInckey = Convert.ToInt32(cellsOfSelectedItem[4].Value.ToString());
            decimal transferMiktar = Convert.ToDecimal(txtMiktar.Text);
            int transferDepoInckey = Convert.ToInt32(cbStokDepo.SelectedValue);
            int addedStokDepoInckey = 0;
            decimal remainMiktar = Convert.ToDecimal(cellsOfSelectedItem[3].Value.ToString()) - transferMiktar;
            try
            {
                if (remainMiktar >= 0)
                {
                    if (remainMiktar != 0)
                    {
                        string anyStokDepoSameQuery = "SELECT COUNT(STOK_DEPO_INCKEY) FROM STOK_DEPO " +
                            "WHERE STOK_INCKEY = @stok_inckey AND DEPO_INCKEY = @depo_inckey";
                        sqlCmd = new SqlCommand(anyStokDepoSameQuery, Program.connection);
                        sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = stokInckey;
                        sqlCmd.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = transferDepoInckey;
                        if (((int)sqlCmd.ExecuteScalar()) != 0)
                        {
                            string getMiktarQuery = "SELECT MIKTAR FROM STOK_DEPO " +
                            "WHERE STOK_INCKEY = @stok_inckey AND DEPO_INCKEY = @depo_inckey";
                            sqlCmd = new SqlCommand(getMiktarQuery, Program.connection);
                            sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = stokInckey;
                            sqlCmd.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = transferDepoInckey;
                            decimal result = (decimal)sqlCmd.ExecuteScalar();
                            
                            string transferUpdateQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_INCKEY = @stok_inckey AND DEPO_INCKEY = @depo_inckey";
                            sqlCmd = new SqlCommand(transferUpdateQuery, Program.connection);
                            sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = stokInckey;
                            sqlCmd.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = transferDepoInckey;
                            sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = (result + transferMiktar);
                            
                            if (sqlCmd.ExecuteNonQuery() > 0)
                            {
                                string updateQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                                sqlCmd = new SqlCommand(updateQuery, Program.connection);
                                sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = remainMiktar;
                                sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = sourceStokDepoInckey;

                            }
                        }
                        else
                        {

                            string transferQuery = "INSERT INTO STOK_DEPO(STOK_INCKEY, DEPO_INCKEY, MIKTAR) OUTPUT INSERTED.STOK_DEPO_INCKEY VALUES(@stok_inckey, @depo_inckey, @miktar)";
                            sqlCmd = new SqlCommand(transferQuery, Program.connection);
                            sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = stokInckey;
                            sqlCmd.Parameters.Add("@depo_inckey", SqlDbType.Int).Value = transferDepoInckey;
                            sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = transferMiktar;
                            addedStokDepoInckey = (int)sqlCmd.ExecuteScalar();
                            if (addedStokDepoInckey > 0)
                            {
                                string updateQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                                sqlCmd = new SqlCommand(updateQuery, Program.connection);
                                sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = remainMiktar;
                                sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = sourceStokDepoInckey;

                            }
                        }
                    }
                    else
                    {
                        string updateJustQuery = "UPDATE STOK_DEPO SET MIKTAR = @miktar WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
                        sqlCmd = new SqlCommand(updateJustQuery, Program.connection);
                        sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = transferMiktar;
                        sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = sourceStokDepoInckey;
                        addedStokDepoInckey = sourceStokDepoInckey;
                    }

                    if (sqlCmd.ExecuteNonQuery() > 0)
                    {
                        string stokDepoTransferQuery = "INSERT INTO STOK_DEPO_TRANSFER(FROM_DEPO, TO_DEPO, MIKTAR, STOK_INCKEY, KAYIT_YAPAN_KUL) " +
                            "VALUES(@from_depo, @to_depo, @miktar, @stok_inckey, @kayit_yapan_kul)";
                        sqlCmd = new SqlCommand(stokDepoTransferQuery, Program.connection);
                        sqlCmd.Parameters.Add("@from_depo", SqlDbType.Int).Value = sourceDepoInckey;
                        sqlCmd.Parameters.Add("@to_depo", SqlDbType.Int).Value = transferDepoInckey;
                        sqlCmd.Parameters.Add("@stok_inckey", SqlDbType.Int).Value = stokInckey;
                        sqlCmd.Parameters.Add("@miktar", SqlDbType.Decimal).Value = transferMiktar;
                        sqlCmd.Parameters.Add("@kayit_yapan_kul", SqlDbType.Int).Value = Program.kullanici.Item1;
                        if (sqlCmd.ExecuteNonQuery() > 0)
                        {
                            sourceStokMiktarLabel.Text = remainMiktar.ToString();
                            Notification.messageBox("Transfer başarıyla tamamlandı.");
                            if (depoStokListesi == null)
                            {
                                stokDepoListesi.listStokDepo();
                            } else
                            {
                                depoStokListesi.listDepoStok();
                            }
                            this.Close();
                        }
                    }
                }
                else
                {
                    Notification.messageBox("Transfer edilecek miktar, asıl miktardan büyük olmamalı.");
                }
            } catch(Exception ex)
            {
                Notification.messageBoxError(ex.Message);
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
            txtMiktar.Text = "0,000";
            loadTransferStok();
        }

        private void loadTransferStok()
        {
            if (depoStokListesi == null)
            {
                cellsOfSelectedItem = stokDepoListesi.getStokDepoSelectedItem().Item2;
            }
            else
            {
                cellsOfSelectedItem = depoStokListesi.getDepoStokSelectedItem().Item2;
            }

            string getDepoInckeySQL = "SELECT DEPO_INCKEY, MIKTAR, STOK.MIKTAR_BIRIM, STOK_ADI, STOK_DEPO.STOK_INCKEY FROM STOK_DEPO " +
                "INNER JOIN STOK ON STOK.STOK_INCKEY = STOK_DEPO.STOK_INCKEY " +
                "WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
            sqlCmd = new SqlCommand(getDepoInckeySQL, Program.connection);
            sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            int myDepoInckey = Convert.ToInt32(reader["DEPO_INCKEY"].ToString());
            decimal miktar = Convert.ToDecimal(reader["MIKTAR"].ToString());
            string birim = reader["MIKTAR_BIRIM"].ToString();
            cbStokDepo.DataSource = getDepoOtherMYDepoDataTableForBindToComboBox(myDepoInckey);
            cbStokDepo.DisplayMember = "DEPO_ADI";
            cbStokDepo.ValueMember = "DEPO_INCKEY";
            sourceDepoNameLabel.Text = cellsOfSelectedItem[1].Value.ToString();
            sourceDepoLokasyonLabel.Text = cellsOfSelectedItem[2].Value.ToString();
            sourceStokMiktarLabel.Text = birim.Equals(MalzemeMiktarBirim.Adet.ToString()) ? Convert.ToInt32(cellsOfSelectedItem[3].Value).ToString() : cellsOfSelectedItem[3].Value.ToString();
            sourceStokBirimLabel.Text = birim;
            destBirimLabel.Text = birim;
            stokAdi = reader["STOK_ADI"].ToString();
            sourceStokAdiLabel.Text = stokAdi;
            stokInckey = Convert.ToInt32(reader["STOK_INCKEY"].ToString());
        }

        private void txtMiktar_Leave(object sender, EventArgs e)
        {
            try
            {
                txtMiktar.Text = string.Format("{0:#,##0.000}", decimal.Parse(txtMiktar.Text));
            }
            catch
            {
                Notification.messageBox("YANLIŞ FORMAT GİRİLDİ");
                txtMiktar.Focus();
            }
        }

        private void txtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextValidate.forceForDecimal(sender, e);
        }
    }
}
