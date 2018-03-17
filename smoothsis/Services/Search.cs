using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace smoothsis.Services
{
    class Search
    {
        public static void gridviewArama(string aramaTextBox, string sutunName, DataGridView dataGridView)
        {
            string rowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", sutunName.Trim(), aramaTextBox.Trim());
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            dataGridView.Refresh();
        }
    }
}
