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
    public partial class AltaBarrio : Form
    {
        public AltaBarrio()
        {
            InitializeComponent();
        }



        private void AltaBarrio_Load(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = false;
            textBoxNroBarrio.Visible = false;
            labelNroBarrio.Visible = false;
            cargarGrilla();
            CargarComboLocalidad();
        }

        private void CargarComboLocalidad()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Localidad";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                comboBoxLocalidad.DataSource = tabla;
                comboBoxLocalidad.DisplayMember = "Nombre";
                comboBoxLocalidad.ValueMember = "CodPostal";
                comboBoxLocalidad.SelectedIndex = -1;
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

        private void cargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Barrio";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewBarrio.DataSource = tabla;

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

        private Barrio ObtenerDatosBarrio()
        {
            Barrio bar = new Barrio();

            bar.NroBarrio = int.Parse(textBoxNroBarrio.Text);
            bar.Nombre = textBoxNom.Text.Trim();
            bar.Localidad = (int)comboBoxLocalidad.SelectedValue;


            return bar;

        }

        private void buttonAltaBarrio_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Barrio bar = ObtenerDatosBarrio();


                if (CargarBarrio(bar))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    cargarGrilla();
                    CargarComboLocalidad();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Barrio");
                }
            }
        }

        private bool CargarBarrio(Barrio bar)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insert into Barrio VALUES (@nom,@nrolocalidad)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", bar.Nombre);
                cmd.Parameters.AddWithValue("@nrolocalidad", bar.Localidad);


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
            
            textBoxNroBarrio.Visible = false;
            labelNroBarrio.Visible = false;
        }

        //Limpia los campos
        private void LimpiarCampos()
        {
            textBoxNom.Text = "";
            comboBoxLocalidad.SelectedValue = -1;
        }

        private void dataGridViewBarrio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            buttonActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridViewBarrio.Rows[indice];
            string nroBarrio = filaSeleccionada.Cells["NroBarrio"].Value.ToString();
            Barrio bar = ObtenerBarrio(nroBarrio);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(bar);

        }

        private Barrio ObtenerBarrio(string nroBar)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Barrio bar = new Barrio();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Barrio WHERE NroBarrio = @nrobar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrobar", nroBar);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    bar.NroBarrio = int.Parse(nroBar);
                    bar.Nombre = dataReader["Nombre"].ToString();
                    bar.Localidad = int.Parse(dataReader["NroLocalidad"].ToString());
                    
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
            return bar;
        }



        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Barrio bar)
        {
            textBoxNroBarrio.Text = bar.NroBarrio.ToString();
            textBoxNroBarrio.Visible = true;
            labelNroBarrio.Visible = true;
            textBoxNom.Text = bar.Nombre;
            comboBoxLocalidad.SelectedValue = bar.Localidad;

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
                Barrio bar = ObtenerDatosBarrio();
                if (ActualizarBarrio(bar))
                {
                    buttonActualizar.Enabled = false;
                    textBoxNroBarrio.Visible = false;
                    labelNroBarrio.Visible = false;

                    MessageBox.Show("Barrio Actualizado con exito");
                    LimpiarCampos();
                    cargarGrilla();
                    CargarComboLocalidad();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }


        private bool ActualizarBarrio(Barrio bar)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Barrio SET Nombre = @nom, NroLocalidad = @localidad" +
                    " WHERE NroBarrio = @nrobar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrobar", bar.NroBarrio);
                cmd.Parameters.AddWithValue("@nom", bar.Nombre);
                cmd.Parameters.AddWithValue("@localidad", bar.Localidad);
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
            if (textBoxNroBarrio.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun Barrio para eliminar");
            }
            else
            {
                if (EliminarExpediente(textBoxNroBarrio.Text))
                {
                    textBoxNroBarrio.Text = "0";
                    textBoxNroBarrio.Visible = false;
                    labelNroBarrio.Visible = false;
                    buttonActualizar.Enabled = false;

                    MessageBox.Show("Eliminado con exito");
                    cargarGrilla();
                    LimpiarCampos();
                    CargarComboLocalidad();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }

        }

        //Elimina una fila/tupla de la base de datos
        private bool EliminarExpediente(string nroBar)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Barrio WHERE NroBarrio= @nrobar";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrobar", nroBar);
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
            bool resultado = textBoxNom.Text.Equals("") ||
            comboBoxLocalidad.SelectedText.Equals(null);

            return resultado;
        }
    }
}
