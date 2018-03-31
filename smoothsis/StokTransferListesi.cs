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
    public partial class StokTransferListesi : Form
    {
        private SqlCommand sqlCmd;

        public StokTransferListesi()
        {
            InitializeComponent();
        }

        private void StokTransferListesi_Load(object sender, EventArgs e)
        {
            listStokTransfer();
            Styler.gridViewCommonStyle(stokTransferListGridView);
        }

        public void listStokTransfer()
        {
            try
            {
                DataTable stokTransferListDepoTable = new DataTable();
                sqlCmd = new SqlCommand("dbo.Stok_Depo_Transfer_List", Program.connection);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCmd);
                adapter.Fill(stokTransferListDepoTable);
                stokTransferListGridView.DataSource = stokTransferListDepoTable;
                stokTransferListGridView.Columns[0].Visible = false;
                stokTransferListGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        private void searchForKaynakDepo(object sender, EventArgs e)
        {
            if (txtAramaKaynakDepo.Text.Count() >= 1)
                Search.gridviewArama(txtAramaKaynakDepo.Text, stokTransferListGridView, "KAYNAK_DEPO");
            else
                Search.gridviewArama("", stokTransferListGridView);
        }

        private void searchForHedefDepo(object sender, EventArgs e)
        {
            if (txtAramaHedefDepo.Text.Count() >= 1)
                Search.gridviewArama(txtAramaHedefDepo.Text, stokTransferListGridView, "HEDEF_DEPO");
            else
                Search.gridviewArama("", stokTransferListGridView);

        }

        private void searchForStokAdi(object sender, EventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() >= 1)
                Search.gridviewArama(txtAramaStokAdi.Text, stokTransferListGridView, "STOK_ADI");
            else
                Search.gridviewArama("", stokTransferListGridView);

        }

        private void searchForKayitYapan(object sender, EventArgs e)
        {
            if (txtAramaKayitYapan.Text.Count() >= 1)
                Search.gridviewArama(txtAramaKayitYapan.Text, stokTransferListGridView, "TRANSFER_YAPAN_KULLANICI");
            else
                Search.gridviewArama("", stokTransferListGridView);
        }

        private void searchForKayitTarih(object sender, EventArgs e)
        {
            Search.gridviewArama(dtAramaKayitTarih.Value.ToString("dd.MM.yyyy"), stokTransferListGridView, "TRANSFER_TARIHI");
        }

        private void btnStokTransferListesiGetir_Click(object sender, EventArgs e)
        {
            listStokTransfer();
        }
    }
}
