using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace smoothsis
{
    public partial class grup : Form
    {
        private int grupId;
        private Boolean isUpdate = false;


        public grup()
        {
            InitializeComponent();
        }

        private void grup_Load(object sender, EventArgs e)
        {
            listGrup();
        }

        private void listGrup()
        {
            try
            {
                DataTable grupListDTtable = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM GRUP ORDER BY GRUP_INCKEY DESC", Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(grupListDTtable);
                grupList.DataSource = grupListDTtable;
            }
            catch (Exception exc)
            {
                throw exc.GetBaseException();
            }

        }

        private void grupEkle(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                isUpdate = false;
                grupAdTB.Text = " ";
                ekleButton.Text = "Ekle";
                guncelleButton.Visible = false;
            }
            else
            {
                string grupAd = grupAdTB.Text.Trim();
                if (!String.IsNullOrEmpty(grupAd))
                {
                    try
                    {
                        SqlCommand command = new SqlCommand("INSERT INTO GRUP(GRUP_ADI) VALUES(@grup_adi)", Program.connection);
                        command.Parameters.Add("@grup_adi", SqlDbType.VarChar).Value = grupAd;
                        command.ExecuteNonQuery();
                    }
                    catch (Exception exc)
                    {
                        throw exc.GetBaseException();
                    }
                    grupAdTB.Text = "";
                    listGrup();
                }
                else
                {
                    Program.controllerClass.messageBox("Lutfen bos gecmeyin.");
                }
            }
        }

        private void grupGuncelle(object sender, EventArgs e)
        {
            string grupAd = grupAdTB.Text.Trim();
            if (!String.IsNullOrEmpty(grupAd))
            {
                try
                {
                    SqlCommand command = new SqlCommand("UPDATE GRUP SET GRUP_ADI = @grup_adi WHERE GRUP_INCKEY = @grup_inckey", Program.connection);
                    command.Parameters.Add("@grup_adi", SqlDbType.VarChar).Value = grupAd;
                    command.Parameters.Add("@grup_inckey", SqlDbType.Int).Value = grupId;
                    command.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    throw exc.GetBaseException();
                }
                listGrup();
            }
            else
            {
                Program.controllerClass.messageBox("Lutfen bos gecmeyin.");
            }
        }

        private void grupList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            isUpdate = true;
            grupId = Int32.Parse(grupList[0, e.RowIndex].Value.ToString());
            grupAdTB.Text = grupList[1, e.RowIndex].Value.ToString();
            guncelleButton.Visible = true;
            ekleButton.Text = "Yeni Ekle";
        }

        private void grupList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                grupId = Int32.Parse(grupList[0, e.RowIndex].Value.ToString());
            }
            catch (FormatException)
            {
                Program.controllerClass.messageBox("Lutfen gecerli bir kayit secin.");
            }

        }

        private void grupSil(object sender, EventArgs e)
        {
            if (grupList.SelectedRows.Count == 1)
            {
                try
                {
                    SqlCommand command = new SqlCommand("DELETE FROM GRUP WHERE GRUP_INCKEY = @grup_inckey", Program.connection);
                    command.Parameters.Add("@grup_inckey", SqlDbType.Int).Value = grupId;
                    command.ExecuteNonQuery();
                }
                catch (Exception exc)
                {
                    throw exc.GetBaseException();
                }
                grupList.Rows.RemoveAt(grupList.SelectedRows[0].Index);
            }
        }
    }
}
