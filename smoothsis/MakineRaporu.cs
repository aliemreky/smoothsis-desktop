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
            string defaultFileName = DateTime.Now.ToString("ddMMyyyy") + "_MakineRaporu.xlsx";
            ActionControl.ExportExcel(defaultFileName, makineRaporu);
        }

        private void MakineRaporu_Load(object sender, EventArgs e)
        {
            makineRaporu = new DataTable();
            sqlCmd = new SqlCommand("dbo.Makine_Raporu", Program.connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter = new SqlDataAdapter(sqlCmd);
            sqlDataAdapter.Fill(makineRaporu);

            Styler.gridViewCommonStyle(MakineRaporuGridView);            
            MakineRaporuGridView.DataSource = makineRaporu;
            MakineRaporuGridView.Columns[0].Visible = false;

            MakineRaporuGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
