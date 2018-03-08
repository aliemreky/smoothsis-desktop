using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
