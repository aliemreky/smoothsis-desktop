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
    public partial class OperatorCalismaRaporu : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable operatorRaporTable;

        public OperatorCalismaRaporu()
        {
            InitializeComponent();
        }

        private void OperatorCalismaRaporu_Load(object sender, EventArgs e)
        {
            TumKayitListe();
        }

        private void TumKayitListe()
        {
            try
            {
                operatorRaporTable = new DataTable();
                sqlCmd = new SqlCommand("dbo.Operator_Raporu", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@STARTDATE", DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@ENDDATE", DBNull.Value);
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(operatorRaporTable);

                Styler.gridViewCommonStyle(OperatorRaporuGridView);
                OperatorRaporuGridView.DataSource = operatorRaporTable;

                typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   OperatorRaporuGridView,
                   new object[] { true });

                OperatorRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void excelButton_Click(object sender, EventArgs e)
        {
            if(OperatorRaporuGridView.Rows.Count > 0)
            {
                string defaultFileName = DateTime.Now.ToString("ddMMyyyy") + "_OperatorRaporu.xlsx";
                ActionControl.ExportExcel(defaultFileName, operatorRaporTable);
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
                operatorRaporTable = new DataTable();
                sqlCmd = new SqlCommand("dbo.Operator_Raporu", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@STARTDATE", dtStartDate.Value);
                sqlCmd.Parameters.AddWithValue("@ENDDATE", dtEndDate.Value);
                sqlDataAdapter = new SqlDataAdapter(sqlCmd);
                sqlDataAdapter.Fill(operatorRaporTable);

                Styler.gridViewCommonStyle(OperatorRaporuGridView);
                OperatorRaporuGridView.DataSource = operatorRaporTable;

                typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   OperatorRaporuGridView,
                   new object[] { true });

                OperatorRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
