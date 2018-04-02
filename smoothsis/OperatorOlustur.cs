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
using smoothsis.Services;
using smoothsis.Services.Enums;

namespace smoothsis
{
    public partial class OperatorOlustur : Form
    {
        private SqlCommand sqlCmd;

        public OperatorOlustur()
        {
            InitializeComponent();
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            string operatorAdiSoyadi = txtOperatorAdiSoyadi.Text.Trim();
            int op_durumu = Convert.ToInt32(cbOperatorDurum.SelectedValue);

            if (!String.IsNullOrEmpty(operatorAdiSoyadi))
            {
                try
                {
                    sqlCmd = new SqlCommand("INSERT INTO OPERATOR(ADSOYAD, OP_DURUMU)" +
                        " VALUES(@adsoyad, @op_durumu)", Program.connection);
                    sqlCmd.Parameters.Add("@adsoyad", SqlDbType.VarChar).Value = operatorAdiSoyadi;
                    sqlCmd.Parameters.Add("@op_durumu", SqlDbType.VarChar).Value = op_durumu;
                    int affectedRows = sqlCmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        Notification.messageBox("Operatör oluşturuldu.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
            else
            {
                Notification.messageBox("Lütfen zorunlu alanları boş geçmeyin.");
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizleBttn_Click(object sender, EventArgs e)
        {
            txtOperatorAdiSoyadi.Clear();
        }

        private void OperatorOlustur_Load(object sender, EventArgs e)
        {
            cbOperatorDurum.DataSource = Enum.GetValues(typeof(Condition));
            cbOperatorDurum.SelectedIndex = 0;
        }
    }
}
