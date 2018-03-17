using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smoothsis.Services
{
    class Notification
    {
        public static void messageBox(string message)
        {
            MessageBox.Show(message, "DURUM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void messageBoxError(string message)
        {
            MessageBox.Show(message, "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
