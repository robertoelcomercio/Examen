using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareasConClases
{
    public partial class Problema3 : Form
    {
        public Problema3()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            string sRes;

            MoneyParts oMoney = new MoneyParts();
            sRes = oMoney.build(txtIngreso.Text);

            txtSalida.Text = sRes;
        }
    }
}
