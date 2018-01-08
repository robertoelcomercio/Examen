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
    public partial class Problema2 : Form
    {
        public Problema2()
        {
            InitializeComponent();
        }

        private void cmdProcesar_Click(object sender, EventArgs e)
        {
            string sIngreso = "";
            string sSalida = "";

            OrderRange oParesImpares = new OrderRange();

            sIngreso = txtIngreso.Text;
            sSalida = oParesImpares.build(sIngreso);

            txtSalida.Text = sSalida;



        }
    }
}
