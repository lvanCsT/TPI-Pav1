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

        //obtiene los datos del Prestacion ingresados en los textbox y los guarda en un objeto Prestacion
        private Prestacion ObtenerDatosPrestacion()
        {
            Prestacion pres = new Prestacion();

            pres.CodPrestacion = int.Parse(txtCodPrestacion.Text);
            pres.EdadMinima = int.Parse(txtEdadMinima.Text);
            pres.Descripcion = cmbDescripcion.GetItemText(cmbDescripcion.SelectedItem);
            return pres;

        }

        //es la carga del Prestacion a la base de datos
        private bool CargarPrestacion(Prestacion pres)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Prestaciones VALUES (@desc,@edad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", pres.Descripcion);
                cmd.Parameters.AddWithValue("@edad", pres.EdadMinima);
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();

                Resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR--->" + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return Resultado;
        }

        //carga la grilla con la BD
        private void CargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Prestaciones";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewPres.DataSource = tabla;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnAltaPrestacion_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");

            }
            else
            {
                Prestacion pres = ObtenerDatosPrestacion();


                if (CargarPrestacion(pres))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Prestacion");
                }
            }
            //    string codigo = txtCodPrestacion.Text;
            //    string descripcion = cmbDescripcion.GetItemText(cmbDescripcion.SelectedItem);
            //    string edadMinima = txtEdadMinima.Text;

            //    Prestacion pres = new Prestacion();

            //    pres.CodPrestacion = int.Parse(codigo);
            //    pres.Descripcion = descripcion;
            //    pres.EdadMinima = int.Parse(edadMinima);

            //    MessageBox.Show("Datos de la prestacion: " + pres.CodPrestacion + " " + pres.Descripcion + " " + pres.EdadMinima);


        }

        private bool validadIngresoDatos()
        {
            bool resultado = cmbDescripcion.SelectedText.Equals(null) ||
            txtCodPrestacion.Text.Equals("") ||
            txtEdadMinima.Text.Equals("");

            return resultado;
        }

        //obtiene un objeto afiliado con todos sus datos para un nro de afiliado especifico
        private Prestacion ObtenerPrestacion(string Codpre)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Prestacion pres = new Prestacion();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Prestaciones WHERE CodPrestacion = @codpre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codpre", Codpre);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    pres.CodPrestacion = int.Parse(Codpre);
                    pres.EdadMinima = int.Parse(dataReader["EdadMinima"].ToString());
                    pres.Descripcion = dataReader["Descripcopn"].ToString();
                    
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR--->" + ex);
                throw;
            }
            finally
            {
                cn.Close();
            }
            return pres;
        }

        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Prestacion pres)
        {
            txtCodPrestacion.Text = pres.CodPrestacion.ToString();
            txtCodPrestacion.Visible = true;
            lblCodPrestacion.Visible = true;
            cmbDescripcion.SelectedValue = pres.Descripcion;
            txtEdadMinima.Text = pres.EdadMinima.ToString();
        }

        //Muestra los datos de un afiliado al clickear en la grilla una de las filas

        private void dataGridViewPres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridViewPres.Rows[indice];
            string codPrestacion = filaSeleccionada.Cells["CodPrestacion"].Value.ToString();
            Prestacion pres = ObtenerPrestacion(codPrestacion);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(pres);
        }
    }
}
