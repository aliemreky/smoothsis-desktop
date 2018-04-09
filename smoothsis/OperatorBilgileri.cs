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
using smoothsis.Services.Enums;

namespace smoothsis
{
    public partial class OperatorBilgileri : Form
    {

        private string[] operatorBiligleri;

        public OperatorBilgileri(string[] operatorBiligleri)
        {
            InitializeComponent();
            this.operatorBiligleri = operatorBiligleri;
        }

        private void OperatorBilgileri_Load(object sender, EventArgs e)
        {
            txtOperatorAdiSoyadi.Text = operatorBiligleri[1];
            txtOperatorDurum.Text = operatorBiligleri[2];
            txtOperatorBaslamaTarih.Text = operatorBiligleri[3];
        }

        private void iptalButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
