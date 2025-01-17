﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using smoothsis.Services;

namespace smoothsis
{
    public partial class CariListesi : Form
    {
        private SqlCommand sqlCmd;
        private SqlDataAdapter sqlAdapter;

        private Tuple<int,string> secilenCari;
        private int listType;

        public CariListesi(int listType)
        {
            this.listType = listType;
            InitializeComponent();
        }

        private void CariListesi_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable cariList = new DataTable();
                sqlCmd = new SqlCommand("SELECT CARI_INCKEY, CARI_KOD, TC_NO, ADSOYAD, IL, ILCE, ADRES, TICARI_UNVAN, VERGI_DAIRE, VERGI_NO, TEL_NO, EPOSTA, CEP_TEL, FAX_NO, CARI_DURUM FROM CARI ORDER BY CARI_INCKEY DESC", Program.connection);
                sqlAdapter = new SqlDataAdapter(sqlCmd);
                sqlAdapter.Fill(cariList);

                typeof(DataGridView).InvokeMember(
                   "DoubleBuffered",
                   BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                   null,
                   cariListesiGridView,
                   new object[] { true });

                cariListesiGridView.DataSource = cariList;
                Styler.gridViewCommonStyle(cariListesiGridView);

                cariListesiGridView.Columns[0].Visible = false;

            }catch(Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }


        private void txtAramaCariKodu_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaCariKodu.Text.Count() > 1)
                Search.gridviewArama(txtAramaCariKodu.Text, cariListesiGridView, "CARI_KOD");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        private void txtAramaAdiSoyadi_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaAdiSoyadi.Text.Count() > 1)
                Search.gridviewArama(txtAramaAdiSoyadi.Text, cariListesiGridView, "ADSOYAD");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        private void txtAramaTicariUnvan_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaTicariUnvan.Text.Count() > 1)
                Search.gridviewArama(txtAramaTicariUnvan.Text,  cariListesiGridView, "TICARI_UNVAN");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        private void txtAramaVergiNo_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaVergiNo.Text.Count() > 1)
               Search.gridviewArama(txtAramaVergiNo.Text, cariListesiGridView, "VERGI_NO");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        private void txtAramaVergiDaire_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaVergiDaire.Text.Count() > 1)
                Search.gridviewArama(txtAramaVergiDaire.Text, cariListesiGridView, "VERGI_DAIRE");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        private void txtAramaTcNo_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaTcNo.Text.Count() > 1)
                Search.gridviewArama(txtAramaTcNo.Text, cariListesiGridView, "TC_NO");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        private void txtAramaIl_TextChanged(object sender, EventArgs e)
        {
            if (txtAramaIl.Text.Count() > 1)
                Search.gridviewArama(txtAramaIl.Text, cariListesiGridView, "IL");
            else
                Search.gridviewArama("", cariListesiGridView);
        }

        public Tuple<int, string> passingCari { get { return secilenCari; } }

        private void cariListesiGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listType == 1)
            {
                secilenCari = new Tuple<int, string>(Convert.ToInt32(cariListesiGridView["CARI_INCKEY", e.RowIndex].Value.ToString()), cariListesiGridView["CARI_KOD", e.RowIndex].Value.ToString());
                this.Close();
            }
        }

        private void CariListesi_Shown(object sender, EventArgs e)
        {
            cariListesiGridView.ClearSelection();
        }
    }
}
