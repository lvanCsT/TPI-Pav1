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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaPrestacion ventana = new AltaPrestacion();
            ventana.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEstado ventana = new AltaEstado();
            ventana.Show();
        }

        private void altaDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDepartamento ventana = new AltaDepartamento();
            ventana.Show();
        }

        private void Escritorio_Load(object sender, EventArgs e)
        {

        }

        private void altaDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDocumento ventana = new AltaDocumento();
            ventana.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AltaOdonto ventana = new AltaOdonto();
            ventana.Show();
        }

        private void altaTipoOdontologoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTipoOdonto ventana = new AltaTipoOdonto();
            ventana.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AltaAtenciones ventana = new AltaAtenciones();
            ventana.Show();
        }

        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaUsuario ventana = new AltaUsuario();
            ventana.Show();
        }

        private void elementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaElemento ventana = new AltaElemento();
            ventana.Show();
        }
    }
}
