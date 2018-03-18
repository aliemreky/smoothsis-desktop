﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using smoothsis.Services;

namespace smoothsis
{
    public partial class Grup : Form
    {
        private int grupId;
        private int rowIndex;
        private Boolean isUpdate = false;

        public Grup()
        {
            InitializeComponent();
        }

        private void Grup_Load(object sender, EventArgs e)
        {
            Styler.gridViewCommonStyle(grupList);
            listGrup();
        }

        private void listGrup()
        {
            try
            {
                DataTable grupListDTable = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM GRUP ORDER BY GRUP_INCKEY DESC", Program.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(grupListDTable);
                grupList.DataSource = grupListDTable;
                grupList.Columns[0].Visible = false;
                grupList.ClearSelection();
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }

        }

        private void grupKaydet(object sender, EventArgs e)
        {
            string grupAd = grupAdTB.Text.Trim();
            
            if (!String.IsNullOrEmpty(grupAd))
            {
                if (isUpdate)
                {
                    grupGuncelle(grupAd);
                }
                else
                {
                    grupEkle(grupAd);
                }
            }
            else
            {
                Notification.messageBox("LÜTFEN GEREKLİ ALANLARI BOŞ GEÇMEYİNİZ.");
            }
            
        }

        private void grupEkle(string grupAdi)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO GRUP(GRUP_ADI) OUTPUT INSERTED.GRUP_INCKEY VALUES(@grup_adi)", Program.connection);
                command.Parameters.Add("@grup_adi", SqlDbType.VarChar).Value = grupAdi;
                int newId = (int)command.ExecuteScalar();
                if (newId > 0)
                {
                    grupAdTB.Clear();
                    listGrup();
                } else
                {
                    Notification.messageBoxError("Bir sorun oluştu, grup kaydedilemedi.");
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void grupGuncelle(string grupAdi)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE GRUP SET GRUP_ADI = @grup_adi WHERE GRUP_INCKEY = @grup_inckey", Program.connection);
                command.Parameters.Add("@grup_adi", SqlDbType.VarChar).Value = grupAdi;
                command.Parameters.Add("@grup_inckey", SqlDbType.Int).Value = grupId;
                int affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0 )
                {
                    Notification.messageBox("GRUP BAŞARIYLA GÜNCELLENDİ.");
                    grupList[1, rowIndex].Value = grupAdi;
                    
                } else
                {
                    Notification.messageBoxError("Bir sorun oluştu, grup güncellenemedi.");
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void grupList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex != -1) {
                isUpdate = true;
                grupId = Int32.Parse(grupList[0, rowIndex].Value.ToString());
                grupAdTB.Text = grupList[1, rowIndex].Value.ToString();
            }
            
        }

        private void grupSil(object sender, EventArgs e)
        {
            if (grupList.SelectedRows.Count == 1)
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ ?", "UYARI", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        int deletedGrupId = Int32.Parse(grupList.SelectedRows[0].Cells[0].Value.ToString());
                        SqlCommand command = new SqlCommand("DELETE FROM GRUP WHERE GRUP_INCKEY = @grup_inckey", Program.connection);
                        command.Parameters.Add("@grup_inckey", SqlDbType.Int).Value = deletedGrupId;
                        int affectedRows = command.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            grupList.Rows.RemoveAt(rowIndex);
                            grupAdTB.Clear();
                            Notification.messageBox("GRUP BAŞARIYLA SİLİNDİ.");
                        }
                        else
                        {
                            Notification.messageBoxError("Bir sorun oluştu, grup silinemedi.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            } else
            {
                Notification.messageBoxError("BİR SORUN OLUŞTU, KAYIT SEÇİLEMEDİ !");
            }
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textTemizle(object sender, EventArgs e)
        {
            grupAdTB.Clear();
            grupList.ClearSelection();
            isUpdate = false;
        }
    }
}
