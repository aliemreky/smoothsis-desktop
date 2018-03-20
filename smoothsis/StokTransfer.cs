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
        private StokListesi stokListesi;

        public StokTransfer(StokListesi stokListesi)
        {
            InitializeComponent();
            this.stokListesi = stokListesi;
            DataGridViewCellCollection cellsOfSelectedItem = stokListesi.getSelectedItem().Item2;

            string getDepoInckeySQL = "SELECT DEPO_INCKEY, MIKTAR FROM STOK_DEPO WHERE STOK_DEPO_INCKEY = @stok_depo_inckey";
            sqlCmd = new SqlCommand(getDepoInckeySQL, Program.connection);
            sqlCmd.Parameters.Add("@stok_depo_inckey", SqlDbType.Int).Value = Convert.ToInt32(cellsOfSelectedItem[0].Value.ToString());
            SqlDataReader reader = sqlCmd.ExecuteReader();
            reader.Read();
            int myDepoInckey = Convert.ToInt32(reader["DEPO_INCKEY"]);
            int miktar = Convert.ToInt32(reader["MIKTAR"]);

            cbStokDepo.DataSource = getDepoOtherMYDepoDataTableForBindToComboBox(myDepoInckey);
            cbStokDepo.DisplayMember = "DEPO_ADI";
            cbStokDepo.ValueMember = "DEPO_INCKEY";
            txtMiktar.Text = miktar.ToString();
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
            string selectDepoInckeySQL = "SELECT DEPO_INCKEY, MIKTAR FROM DEPO";
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtMiktar.Clear();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
