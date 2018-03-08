using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace smoothsis.Services
{
    class Styler
    {
        public static void gridViewCommonStyle(DataGridView gridview)
        {
            gridview.AllowUserToResizeRows = false;
            gridview.AllowUserToAddRows = false;
            gridview.RowHeadersVisible = false;
            gridview.EnableHeadersVisualStyles = false;
            gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9);
        }
    }
}
