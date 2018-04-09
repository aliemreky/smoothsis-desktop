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
    public partial class UretimListesi : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlDataAdapter;

        public UretimListesi()
        {
            InitializeComponent();
        }

        private void UretimListesi_Load(object sender, EventArgs e)
        {
            getUretimListesi();
        }

        public void getUretimListesi()
        {
            DataTable siparisListe = new DataTable();
            sqlCmd = new SqlCommand("dbo.Uretim_Listesi", Program.connection);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlDataAdapter = new SqlDataAdapter(sqlCmd);
            sqlDataAdapter.Fill(siparisListe);

            typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   uretimListGridView,
                   new object[] { true });

            uretimListGridView.DataSource = siparisListe;

            Styler.gridViewCommonStyle(uretimListGridView);

            uretimListGridView.Columns[0].Visible = false;
        }

        private void txtAramaStokKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaStokKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaStokKodu.Text, uretimListGridView, "STOK_KODU");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void txtAramaStokAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaStokAdi.Text.Count() > 1)
                Search.gridviewArama(txtAramaStokAdi.Text, uretimListGridView, "STOK_ADI");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void txtAramaIslem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaIslem.Text.Count() > 1)
                Search.gridviewArama(txtAramaIslem.Text, uretimListGridView, "ISLEM");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void txtAramaMakine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtAramaMakine.Text.Count() > 1)
                Search.gridviewArama(txtAramaMakine.Text, uretimListGridView, "MAKINE");
            else
                Search.gridviewArama("", uretimListGridView);
        }

        private void btnUretimListesiGetir_Click(object sender, EventArgs e)
        {
            getUretimListesi();
        }
    }
}
