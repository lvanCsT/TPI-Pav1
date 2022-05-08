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
    public partial class AltaExpediente : Form
    {
        public AltaExpediente()
        {
            InitializeComponent();
        }

        private void AltaExpediente_Load(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = false;
            textBoxNroExpe.Visible = false;
            labelNroExpe.Visible = false;
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Expedientes";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewExpe.DataSource = tabla;

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

        private Expediente ObtenerDatosExpediente()
        {
            Expediente expe = new Expediente();

            expe.NroExpediente = int.Parse(textBoxNroExpe.Text);
            expe.FechaInicio = maskedTextBoxFechaInicio.Text.Trim();
            expe.Reintegro = int.Parse(maskedTextBoxReintegro.Text);
            

            return expe;

        }

        private void buttonAltaExpe_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Expediente expe = ObtenerDatosExpediente();


                if (CargarExpediente(expe))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Expediente");
                }
            }
        }

        private bool CargarExpediente(Expediente expe)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                //pasar a date
                string consulta = "insert into Expedientes VALUES (CONVERT(DATETIME,@fechainicio,103),@reint)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fechainicio", expe.FechaInicio);
                cmd.Parameters.AddWithValue("@reint", expe.Reintegro);
                

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


        //Ejecuta limpiar los campos
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Limpia los campos
        private void LimpiarCampos()
        {
            maskedTextBoxFechaInicio.Text = "";
            maskedTextBoxReintegro.Text = "";
        }

        private void dataGridViewExpe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            buttonActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridViewExpe.Rows[indice];
            string nroExpediente = filaSeleccionada.Cells["NroExpediente"].Value.ToString();
            Expediente expe = ObtenerExpediente(nroExpediente);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(expe);
        }


        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Expediente expe)
        {
            textBoxNroExpe.Text = expe.NroExpediente.ToString();
            textBoxNroExpe.Visible = true;
            labelNroExpe.Visible = true;
            maskedTextBoxFechaInicio.Text = expe.FechaInicio;
            maskedTextBoxReintegro.Text = expe.Reintegro.ToString();
            
        }


        //obtiene un objeto Expediente con todos sus datos para un nro de expediente especifico
        private Expediente ObtenerExpediente(string nroExpe)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Expediente expe = new Expediente();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Expedientes WHERE NroExpe = @nroexpe";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroexpe", nroExpe);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    expe.NroExpediente = int.Parse(nroExpe);
                    expe.FechaInicio = dataReader["FechaInicio"].ToString();
                    expe.Reintegro = int.Parse(dataReader["Reintegro"].ToString());
                    
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
            return expe;
        }


        //Realiza la actualizacion de la BD y actualiza la grilla
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Expediente expe = ObtenerDatosExpediente();
                if (ActualizarExpediente(expe))
                {
                    buttonActualizar.Enabled = false;
                    textBoxNroExpe.Visible = false;
                    labelNroExpe.Visible = false;

                    MessageBox.Show("Expediente Actualizado con exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }


        private bool ActualizarExpediente(Expediente expe)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Expedientes SET FechaInicio = CONVERT(DATETIME,@fechainicio,103), Reintegro = @reintegro" +
                    " WHERE NroExpe = @nroexpe";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroexpe", expe.NroExpediente);
                cmd.Parameters.AddWithValue("@fechainicio", expe.FechaInicio);
                cmd.Parameters.AddWithValue("@reintegro", expe.Reintegro);
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

        //Elimina una fila/tupla de la base de datos y actualiza la grilla
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxNroExpe.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun Expediente para eliminar");
            }
            else
            {
                if (EliminarExpediente(textBoxNroExpe.Text))
                {
                    textBoxNroExpe.Text = "0";
                    textBoxNroExpe.Visible = false;
                    labelNroExpe.Visible = false;

                    MessageBox.Show("Eliminado con exito");
                    cargarGrilla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }

        }

        //Elimina una fila/tupla de la base de datos
        private bool EliminarExpediente(string NroExpe)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Expedientes WHERE NroExpe= @nroexpe";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroexpe", NroExpe);
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

        private bool validadIngresoDatos()
        {
            bool resultado = maskedTextBoxFechaInicio.Text.Equals("") ||
            maskedTextBoxReintegro.Text.Equals("");

            return resultado;
        }
    }
}
