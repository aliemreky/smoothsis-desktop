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
using System.Reflection;

namespace smoothsis
{
    public partial class StokRaporu : Form
    {

        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable StokRaporTable;

        public StokRaporu()
        {
            InitializeComponent();
        }

        private void StokRaporu_Load(object sender, EventArgs e)
        {
            TumKayitListe();
        }

        private void TumKayitListe()
        {
            try
            {
                StokRaporTable = new DataTable();
                sqlCmd = new SqlCommand("dbo.Stok_Raporu", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@STARTDATE", DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@ENDDATE", DBNull.Value);
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(StokRaporTable);

                Styler.gridViewCommonStyle(StokRaporuGridView);
                StokRaporuGridView.DataSource = StokRaporTable;

                typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   StokRaporuGridView,
                   new object[] { true });

                StokRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            if (StokRaporuGridView.Rows.Count > 0)
            {
                string defaultFileName = DateTime.Now.ToString("ddMMyyyy") + "_StokRaporu.xlsx";
                ActionControl.ExportExcel(defaultFileName, StokRaporTable);
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTarihAraligi_Click(object sender, EventArgs e)
        {
            try
            {
                StokRaporTable = new DataTable();
                sqlCmd = new SqlCommand("dbo.Stok_Raporu", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@STARTDATE", dtStartDate.Value);
                sqlCmd.Parameters.AddWithValue("@ENDDATE", dtEndDate.Value);
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(StokRaporTable);

                Styler.gridViewCommonStyle(StokRaporuGridView);
                StokRaporuGridView.DataSource = StokRaporTable;

                typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   StokRaporuGridView,
                   new object[] { true });

                StokRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void btnListeyiYenile_Click(object sender, EventArgs e)
        {
            TumKayitListe();
        }
    }
}
