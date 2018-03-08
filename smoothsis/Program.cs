using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using smoothsis.Services;

namespace smoothsis
{
    static class Program
    {
        // COMMON VARIABLES
        private static string connectionString = "Server=localhost;Database=smoothsis;Integrated Security=SSPI;MultipleActiveResultSets=True";
        public static SqlConnection connection = new SqlConnection(connectionString);        
        private static Boolean connectionBool = false;
        public static Tuple<int, string> kullanici; // KULLANICI TUPLE: ITEM 1= ID, ITEM 2= ADSOYAD
        public static string sirket = "";

        [STAThread]
        static void Main()
        {
            try
            {
                connection.Open();
                connectionBool = true;
            }
            catch(Exception ex)
            {
                Notification.messageBox(ex.Message);
            }

            if (connectionBool)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            }else
            {
                Application.Exit();
            }
            
        }
    }
}
