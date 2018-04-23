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
    public partial class MakineRaporu : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable makineRaporu;

        public MakineRaporu()
        {
            InitializeComponent();
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            if (makineRaporu.Rows.Count > 0)
            {
                string defaultFileName = DateTime.Now.ToString("ddMMyyyy") + "_MakineRaporu.xlsx";
                ActionControl.ExportExcel(defaultFileName, makineRaporu);
            }
        }

        private void MakineRaporu_Load(object sender, EventArgs e)
        {
            TumKayitListe();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TumKayitListe()
        {
            try
            {
                makineRaporu = new DataTable();
                sqlCmd = new SqlCommand("dbo.Makine_Raporu", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@STARTDATE", DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@ENDDATE", DBNull.Value);
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(makineRaporu);

                Styler.gridViewCommonStyle(MakineRaporuGridView);
                MakineRaporuGridView.DataSource = makineRaporu;

                MakineRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnTarihAraligi_Click(object sender, EventArgs e)
        {
            try
            {
                makineRaporu = new DataTable();
                sqlCmd = new SqlCommand("dbo.Makine_Raporu", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@STARTDATE", dtStartDate.Value);
                sqlCmd.Parameters.AddWithValue("@ENDDATE", dtEndDate.Value);
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(makineRaporu);

                Styler.gridViewCommonStyle(MakineRaporuGridView);
                MakineRaporuGridView.DataSource = makineRaporu;

                MakineRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }
    }
}
