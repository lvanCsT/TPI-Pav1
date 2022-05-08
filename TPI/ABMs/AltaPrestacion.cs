using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Entidades;

namespace TPI.ABMs
{
    public partial class AltaPrestacion : Form
    {
        public AltaPrestacion()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodPrestacion.Text = "";
            cmbDescripcion.SelectedIndex = -1;
            txtEdadMinima.Text = "";
        }

        private void Prestaciones_Load(object sender, EventArgs e)
        {
            cmbDescripcion.Items.Add("Consultas");
            cmbDescripcion.Items.Add("Operatoria Dental");
            cmbDescripcion.Items.Add("Endodoncia");
            cmbDescripcion.Items.Add("Protesis");
            cmbDescripcion.Items.Add("Odontologia Preventiva");
            cmbDescripcion.Items.Add("Ortodoncia Ortopedia");
            cmbDescripcion.Items.Add("Odontopediatria");
        }

        private void btnAltaPrestacion_Click(object sender, EventArgs e)
        {
            string codigo = txtCodPrestacion.Text;
            string descripcion = cmbDescripcion.GetItemText(cmbDescripcion.SelectedItem);
            string edadMinima = txtEdadMinima.Text;
                        
            Prestacion pres = new Prestacion();

            pres.CodPrestacion = int.Parse(codigo);
            pres.Descripcion = descripcion;
            pres.EdadMinima = int.Parse(edadMinima);
            
            MessageBox.Show("Datos de la prestacion: " + pres.CodPrestacion + " " + pres.Descripcion + " " + pres.EdadMinima);
            }
    }
}
