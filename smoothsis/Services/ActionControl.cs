using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace smoothsis.Services
{
    class ActionControl
    {
        public static void ActionAllControls(Control ctl, string type = "")
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

        // MOVE OPERATOR FUNCTION
        public static void moveOperator(ListView source, ListView destination)
        {
            var insertPos = 0;
            foreach (ListViewItem s in source.SelectedItems)
            {
                s.Remove();
                var copyCode = int.Parse(s.Text);
                while (insertPos < destination.Items.Count)
                {
                    var itemAtCandidate = int.Parse(destination.Items[insertPos].Text);
                    if (itemAtCandidate > copyCode)
                        break;
                    insertPos++;
                }
                destination.Items.Insert(insertPos, s);
            }
        }

        public static void ExportExcel(string defaultFileName, DataTable ExportTable)
        {

            //Exporting to Excel
            string defaultFolderPath = @"C:\smoothsis\";
            
            if (!Directory.Exists(defaultFolderPath))
            {
                Directory.CreateDirectory(defaultFolderPath);
            }

            SaveFileDialog savefileDialog = new SaveFileDialog();
            savefileDialog.Title = "Dosyayı Kaydet";
            savefileDialog.Filter = "Excel Çalışma Kitabı (*.xlsx)|*.xlsx | Excel 97-2003 Çalışma Kitabı (*.xls)|*.xls| Tüm Dosyalar (*.*)|*.*";
            savefileDialog.FileName = defaultFileName;
            savefileDialog.InitialDirectory = defaultFolderPath;
            if (savefileDialog.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(ExportTable, "Sheet1");
                    wb.SaveAs(savefileDialog.FileName);
                }
            }
        }

    }
}
