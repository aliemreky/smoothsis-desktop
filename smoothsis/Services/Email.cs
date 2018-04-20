using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Data.SqlClient;

namespace smoothsis.Services
{
    class Email
    {
        private SqlCommand sqlCmd;

        private string host;
        private int port;
        private string fromEmailAdress;
        private string fromPassword;
        private string fromDisplayName;
        private string toEmail;

        public Email(){ }        

        public bool MultipleEmailSend(string EmailSubject, string EmailBody)
        {
            try
            {
                sqlCmd = new SqlCommand("SELECT TOP 1 * FROM EMAIL");
                SqlDataReader emailReader = sqlCmd.ExecuteReader();
                emailReader.Read();

                host = emailReader["HOST"].ToString();
                port = int.Parse(emailReader["PORT"].ToString());
                fromEmailAdress = emailReader["FROM_ADDRESS"].ToString();
                fromPassword = emailReader["FROM_PASSWORD"].ToString();
                fromDisplayName = emailReader["FROM_DISPLAYNAME"].ToString();
                toEmail = emailReader["TO_EMAIL"].ToString();

                emailReader.Close();

                MailMessage mailMessage = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Port = port;
                client.Host = host;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(fromEmailAdress, fromPassword);

                mailMessage.From = new MailAddress(fromEmailAdress, fromDisplayName);

                string[] ToEmail = toEmail.Split(';');

                foreach (string to in ToEmail)
                    mailMessage.To.Add(new MailAddress(to.Trim()));

                mailMessage.Subject = EmailSubject;
                mailMessage.Body = EmailBody;

                client.Send(mailMessage);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
