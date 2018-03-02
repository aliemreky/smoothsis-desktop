using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace smoothsis.Services
{
    class Controller
    {

        public void gridViewCommonStyle(DataGridView gridview)
        {
            gridview.AllowUserToResizeRows = false;
            gridview.AllowUserToAddRows = false;
            gridview.RowHeadersVisible = false;
            gridview.EnableHeadersVisualStyles = false;
            gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9);
        }

        public void messageBox(string message)
        {
            MessageBox.Show(message, "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void messageBoxError(string message)
        {
            MessageBox.Show(message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void gridviewArama(string aramaTextBox, string sutunName, DataGridView dataGridView)
        {
            string rowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", sutunName.Trim(), aramaTextBox.Trim());
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView.Refresh();
        }

        public void ActionAllControls(Control ctl, string type = "")
        {
            foreach (Control c in ctl.Controls)
            {
                if (type.Equals("disable"))
                {
                    if (c is TextBox)
                        ((TextBox)c).Enabled = false;

                    if (c is RadioButton)
                        ((RadioButton)c).Enabled = false;
                }

                if (type.Equals("enable"))
                {
                    if (c is TextBox)
                        ((TextBox)c).Enabled = true;
                    if (c is RadioButton)
                        ((RadioButton)c).Enabled = true;
                }

                if (type.Equals("clear"))
                    if (c is TextBox)
                        ((TextBox)c).Clear();

                if (c.Controls.Count > 0)
                {
                    if (type.Equals("clear"))
                        ActionAllControls(c, "clear");

                    if (type.Equals("enable"))
                        ActionAllControls(c, "enable");

                    if (type.Equals("disable"))
                        ActionAllControls(c, "disable");
                }

            }
        }

    }
}
