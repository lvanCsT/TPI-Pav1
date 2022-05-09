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

namespace TPI
{
    public partial class AltaEstado : Form
    {
        public AltaEstado()
        {
            InitializeComponent();
        }

        private void AltaEstado_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            mtbCodEstado.Enabled = false;
            mtbCodEstado.Visible = false;
            lblCodEstado.Visible = false;
            CargarGrilla();
        }

        //carga la grilla con la BD
        private void CargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Estados";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dgbEstados.DataSource = tabla;
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

        //obtiene los datos del Estado ingresados y los guarda en un objeto Estado
        private Estado ObtenerDatosEstado()
        {
            Estado est = new Estado();
            est.CodigoEstado = int.Parse(mtbCodEstado.Text);
            est.Nombre = tbNombre.Text.Trim();
            est.Descripcion = rtbDescripcion.Text;

            return est;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCodPrestacion_Click(object sender, EventArgs e)
        {

        }

        //Boton que da de alta un Estado
        private void btnAltaEstado_Click(object sender, EventArgs e)
        {
            if (validarIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos", "Advertencia");
            }
            else
            {
                Estado est = ObtenerDatosEstado();


                if (CargarEstado(est))
                {
                    MessageBox.Show("Cargado Con Exito", "Carga completa");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Estado", "Advertencia");
                }
            }
        }

        //Metodo para cargar Estado
        private bool CargarEstado(Estado est)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Estados VALUES (@Nombre, @Descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", est.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", est.Descripcion);


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

        //Metodo para limpiar campos
        private void LimpiarCampos()
        {
            mtbCodEstado.Text = "";
            tbNombre.Text = "";
            rtbDescripcion.Text = "";
            
        }

        //Metodo para validar campos completos
        private bool validarIngresoDatos()
        {
            bool resultado = tbNombre.Text.Equals("") || rtbDescripcion.Text.Equals("");

            return resultado;
        }

        //Ejecuta metodo limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            mtbCodEstado.Visible = false;
            lblCodEstado.Visible = false;
        }

        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Estado est)
        {
            mtbCodEstado.Text = est.CodigoEstado.ToString();
            tbNombre.Text = est.Nombre;
            rtbDescripcion.Text = est.Descripcion;

        }

        //obtiene un objeto Estado con todos sus datos para un codigo estado especifico
        private Estado ObtenerEstado(string CodigoEstado)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Estado est = new Estado();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Estados WHERE CodEstado = @CodigoEstado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodigoEstado", CodigoEstado);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    est.CodigoEstado = int.Parse(CodigoEstado);
                    est.Nombre = dataReader["Nombre"].ToString();
                    est.Descripcion = dataReader["Descripcion"].ToString();

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
            return est;
        }

        private void dgbEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            mtbCodEstado.Visible = true;
            lblCodEstado.Visible = true;
            DataGridViewRow filaSeleccionada = dgbEstados.Rows[indice];
            string CodigoEstado = filaSeleccionada.Cells["CodigoEstado"].Value.ToString();
            Estado est = ObtenerEstado(CodigoEstado);
            LimpiarCampos();

            CargarCampos(est);
        }

        //Actualiza la BD y la grilla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos","Advertencia");
            }
            else
            {
                Estado est = ObtenerDatosEstado();
                if (ActualizarEstado(est))
                {
                    btnActualizar.Enabled = false;
                    mtbCodEstado.Visible = false;
                    lblCodEstado.Visible = false;

                    MessageBox.Show("Estado actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar","Advertencia");
                }
            }
        }

        private bool ActualizarEstado(Estado est)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Estados SET Descripcion = @Descripcion, Nombre = @Nombre" +
                    " WHERE CodEstado = @CodEstado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodEstado", est.CodigoEstado);
                cmd.Parameters.AddWithValue("@Nombre", est.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", est.Descripcion);
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


        //Elimina una fila/tupla de la BD y actualiza la grilla
        private void btnBajaEstado_Click(object sender, EventArgs e)
        {
            if (mtbCodEstado.Text.Equals(""))
            {
                MessageBox.Show("Seleccione algun Estado para eliminar");
            }
            else
            {
                if (EliminarEstado(mtbCodEstado.Text))
                {
                    MessageBox.Show("Eliminado con exito");
                    CargarGrilla();
                    LimpiarCampos();
                    mtbCodEstado.Visible = false;
                    lblCodEstado.Visible = false;
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar","Advertencia");
                }
            }
        }

        //Elimina una fila/tupla de la BD
        private bool EliminarEstado(string CodigoEstado)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Estados WHERE CodEstado = @CodigoEstado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodigoEstado", CodigoEstado);
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
    }
}
