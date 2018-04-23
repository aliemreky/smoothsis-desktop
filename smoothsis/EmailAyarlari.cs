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

namespace smoothsis
{
    public partial class EmailAyarlari : Form
    {
        private SqlCommand sqlCmd;
        private int emailSettingInckey;

        public EmailAyarlari()
        {
            InitializeComponent();
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmailAyarlari_Load(object sender, EventArgs e)
        {
            try
            {
                sqlCmd = new SqlCommand("SELECT TOP 1 * FROM EMAIL", Program.connection);
                SqlDataReader emailReader = sqlCmd.ExecuteReader();
                if (emailReader.HasRows)
                {
                    emailReader.Read();
                    emailSettingInckey = int.Parse(emailReader["EMAIL_INCKEY"].ToString());
                    txtEmailHost.Text = emailReader["HOST"].ToString();
                    txtEmailPort.Text = emailReader["PORT"].ToString();
                    txtEmailGonderAdSoyad.Text = emailReader["FROM_DISPLAYNAME"].ToString();
                    txtEmailGonderenMail.Text = emailReader["FROM_ADDRESS"].ToString();
                    txtEmailGonderenSifre.Text = emailReader["FROM_PASSWORD"].ToString();

                    string[] toEmails = emailReader["TO_EMAIL"].ToString().Split(';');
                    listGonderilecekAdresler.Items.AddRange(toEmails);
                    emailReader.Close();
                }
                else
                {
                    Notification.messageBoxError("Gösterilecek Veri Yok !");
                }
            }
            catch (Exception ex)
            {
                Notification.messageBoxError(ex.Message);
            }
        }

        private void btnListEkle_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtListEkle.Text))
            {
                if (TextValidate.IsValidEmail(txtListEkle.Text))
                {
                    listGonderilecekAdresler.Items.Add(txtListEkle.Text);
                    txtListEkle.Text = "";
                }                
            }
        }

        private void kaydetBttn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEmailHost.Text) ||
                String.IsNullOrEmpty(txtEmailPort.Text) ||
                String.IsNullOrEmpty(txtEmailGonderAdSoyad.Text) ||
                String.IsNullOrEmpty(txtEmailGonderenMail.Text) ||
                String.IsNullOrEmpty(txtEmailGonderenSifre.Text) ||
                listGonderilecekAdresler.Items.Count <= 0)
            {

                Notification.messageBoxError("LÜTFEN BOŞ ALAN BIRAKMAYINIZ !");

            }else
            {
                try
                {
                    string toEmail = "";
                    string[] toList = listGonderilecekAdresler.Items.Cast<String>().ToArray();
                    foreach (string toEmails in toList)
                        toEmail += toEmails + ";";

                    string updateEmailSettingSQL = "UPDATE EMAIL SET " +
                        "HOST=@host, PORT=@port, " +
                        "FROM_ADDRESS=@from_address, " +
                        "FROM_PASSWORD=@from_password, " +
                        "FROM_DISPLAYNAME=@from_displayname, " +
                        "TO_EMAIL=@to_email " +
                        "WHERE EMAIL_INCKEY=@email_inckey ";
                    sqlCmd = new SqlCommand(updateEmailSettingSQL, Program.connection);
                    sqlCmd.Parameters.AddWithValue("@email_inckey", emailSettingInckey);
                    sqlCmd.Parameters.AddWithValue("@host", txtEmailHost.Text);
                    sqlCmd.Parameters.AddWithValue("@port", txtEmailPort.Text);
                    sqlCmd.Parameters.AddWithValue("@from_address", txtEmailGonderenMail.Text);
                    sqlCmd.Parameters.AddWithValue("@from_password", txtEmailGonderenSifre.Text);
                    sqlCmd.Parameters.AddWithValue("@from_displayname", txtEmailGonderAdSoyad.Text);
                    sqlCmd.Parameters.AddWithValue("@to_email", toEmail.Substring(0,toEmail.Length-1));
                    sqlCmd.ExecuteNonQuery();

                    Notification.messageBox("Ayarlar Başarıyla Kaydedildi");

                }
                catch (Exception ex)
                {
                    Notification.messageBoxError(ex.Message);
                }
            }
        }        

        private void listGonderilecekAdresler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                if (listGonderilecekAdresler.SelectedIndex != -1)
                {
                    listGonderilecekAdresler.Items.RemoveAt(listGonderilecekAdresler.SelectedIndex);
                }

            }
        }

        private void txtListEkle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                btnListEkle.PerformClick();
            }
        }
    }
}
