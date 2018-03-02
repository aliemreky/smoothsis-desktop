using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace smoothsis.Services
{
    class TextValidate
    {
        public static void forceForNumeric(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public static void forceForNumericWithSpace(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != Convert.ToChar(Keys.Space)) &&
                (e.KeyChar != Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }


    }
}
