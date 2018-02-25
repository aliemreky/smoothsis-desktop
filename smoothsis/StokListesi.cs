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
    public partial class StokListesi : Form
    {
        // item1 is e.RowIndex, item2 is stokIncKey
        private  Tuple<int, DataGridViewCellCollection> selectedItem;

        public StokListesi()
        {
            InitializeComponent();
        }

        private void StokListeleDuzenle_Load(object sender, EventArgs e)
        {
            Program.controllerClass.gridViewCommonStyle(stokListGridView);
            listStok();
        }

        public DataGridView getDataGrid()
        {
            return stokListGridView;
        }

        private void listStok()
        {
            try
            {
                DataTable stokListDTable = new DataTable();
                string query = "SELECT * FROM STOK ORDER BY STOK_INCKEY DESC";
                SqlCommand command = new SqlCommand(query, Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(stokListDTable);
                stokListGridView.DataSource = stokListDTable;
                stokListGridView.Columns[0].Visible = false;
                stokListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Program.controllerClass.messageBoxError(ex.Message);
            }

        }

        public Tuple<int, DataGridViewCellCollection> getSelectedItem()
        {
            return selectedItem;
        }

        private void showStok(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                selectedItem = new Tuple<int, DataGridViewCellCollection>(e.RowIndex, stokListGridView.Rows[e.RowIndex].Cells);
                StokDuzenle stokDuzenle = new StokDuzenle(this);
                stokDuzenle.ShowDialog();
            }
        }
    }
}
