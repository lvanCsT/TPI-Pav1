using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.ABMs;

namespace TPI
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();
        }

        private void altaAfiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaAfiliado ventana = new AltaAfiliado();
            ventana.ShowDialog();

        }

        private void altaExpedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaExpediente ventana = new AltaExpediente();
            ventana.ShowDialog();
        }


        private void altaBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaBarrio ventana = new AltaBarrio();
            ventana.ShowDialog();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
