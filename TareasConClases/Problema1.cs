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
    public partial class Problema1 : Form
    {
        public Problema1()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            string sIngreso = "";
            string sSalida = "";

            ChangeString oConversor = new ChangeString();

            sIngreso = txtIngreso.Text;
            sSalida = oConversor.build(sIngreso);

            txtSalida.Text = sSalida;




        }
    }
}
