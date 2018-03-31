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

        public static void forceForDecimal(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)) && (e.KeyChar != ','))
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

        public static void tcKimlikValidate(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
            else
                if ((sender as TextBox).Text.Count(Char.IsDigit) > 11 && (e.KeyChar != Convert.ToChar(Keys.Back)))
                e.Handled = true;
        }

        public static void forceForNumericWithDot(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');
        }

    }
}
