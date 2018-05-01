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
            gridview.DefaultCellStyle.BackColor = Color.GhostWhite;
            gridview.BackgroundColor = Color.GhostWhite;
            gridview.AllowUserToResizeRows = false;
            gridview.AllowUserToAddRows = false;
            gridview.RowHeadersVisible = false;
            gridview.EnableHeadersVisualStyles = false;
            gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9);
        }

        public static void gridViewColumnResize(DataGridView gridview)
        {
            for (int i = 0; i < gridview.Columns.Count; i++)
            {
                gridview.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colw = gridview.Columns[i].Width;
                gridview.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridview.Columns[i].Width = colw;
            }
        }
    }
}
