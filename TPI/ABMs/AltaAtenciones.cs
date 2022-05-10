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
    public partial class AltaAtenciones : Form
    {
        public AltaAtenciones()
        {
            InitializeComponent();
        }

        private void AltaAtenciones_Load(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = false;
            cargarGrilla();
            CargarComboCategoria();
        }



        //carga la grilla con la BD
        private void cargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Atenciones";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewAtencion.DataSource = tabla;

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
        //cargamos combobox de categoria
        private void CargarComboCategoria()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Categorias";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                comboBoxCateg.DataSource = tabla;
                comboBoxCateg.DisplayMember = "Descripcion";
                comboBoxCateg.ValueMember = "CodCategoria";
                comboBoxCateg.SelectedIndex = -1;
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

        //obtiene los datos de atencion ingresados en los textbox y los guarda en un objeto Atencion
        private Atencion ObtenerDatosAtencion()
        {
            Atencion ate = new Atencion();

            ate.NroAfiliado = int.Parse(textBoxNroAfiliado.Text);
            ate.Categoria = (int)comboBoxCateg.SelectedValue;
            ate.NroExpediente = int.Parse(textBoxNroExpe.Text);
            ate.FechaAtencion = maskedTextBoxFechaAte.Text;
            ate.Matricula = int.Parse(textBoxMatricula.Text);
            return ate;

        }

        //Cargo la atencion mediante el form
        private void buttonAltaAfiliado_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");

            }
            else
            {
                Atencion ate = ObtenerDatosAtencion();


                if (CargarAtencion(ate))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Afiliado");
                }
            }
        }


        private bool CargarAtencion(Atencion ate)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Atenciones (CodCategoria, FechaAtencion, Matricula, NroExpe) VALUES (@codCate, CONVERT(DATETIME,@fechaAte,103), @matri, @nroExpe)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCate", ate.Categoria);
                cmd.Parameters.AddWithValue("@fechaAte", ate.FechaAtencion);
                cmd.Parameters.AddWithValue("@matri", ate.Matricula);
                cmd.Parameters.AddWithValue("@nroExpe", ate.NroExpediente);

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



        //Limpia los campos
        private void LimpiarCampos()
        {
            textBoxMatricula.Text = "";
            textBoxNroAfiliado.Text = "";
            textBoxNroExpe.Text = "";
            comboBoxCateg.SelectedValue = -1;
            maskedTextBoxFechaAte.Text = "";
        }

        //Comprueba que ninguno de los datos este vacio.
        private bool ValidarDatos()
        {
            bool resultado = textBoxNroAfiliado.Text.Equals("") ||
                comboBoxCateg.SelectedText.Equals(null) ||
                textBoxNroExpe.Text.Equals("") ||
                maskedTextBoxFechaAte.Text.Equals("") ||
                textBoxMatricula.Text.Equals("");

            return resultado;

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        // hasta aca anda bien...
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Atencion ate = ObtenerDatosAtencion();
                if (ActualizarAtencion(ate))
                {
                    buttonActualizar.Enabled = false;

                    MessageBox.Show("Afiliado Actualizado con exito");
                    LimpiarCampos();
                    cargarGrilla();
                    CargarComboCategoria();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }

        }

        //actualiza la BD
        private bool ActualizarAtencion(Atencion ate)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Afiliados SET CodCategoria = @codCat, FechaAtencion = CONVERT(DATETIME,@fechaAte,103)" +
                    " WHERE NroAfiliado = @nroAfi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroAfi", ate.NroAfiliado);
                cmd.Parameters.AddWithValue("@codCat", ate.Categoria);
                cmd.Parameters.AddWithValue("@fechaAte", ate.FechaAtencion);
                cmd.Parameters.AddWithValue("@nroCalle", ate.NroExpediente);
                cmd.Parameters.AddWithValue("@barrio", ate.Matricula);

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

        private void dataGridViewAtencion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dataGridViewAtencion.Rows[indice];
            string nroAfiliado = filaSeleccionada.Cells["NroAfiliado"].Value.ToString();
            Atencion ate = ObtenerAtencion(nroAfiliado);
            LimpiarCampos();
            CargarCampos(ate);
        }

        private void CargarCampos(Atencion ate)
        {
            textBoxNroAfiliado.Text = ate.NroAfiliado.ToString();
            buttonActualizar.Enabled = true;
            comboBoxCateg.Text = ate.Categoria.ToString();
            textBoxMatricula.Text = ate.Matricula.ToString();
            textBoxNroExpe.Text = ate.NroExpediente.ToString();
            maskedTextBoxFechaAte.Text = ate.FechaAtencion.ToString();


        }


        private Atencion ObtenerAtencion(string Nroafi)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Atencion ate = new Atencion();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Atenciones WHERE NroAfiliado = @nroafi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroafi", Nroafi);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    ate.NroAfiliado = int.Parse(Nroafi);
                    ate.Categoria = int.Parse(dataReader["CodCategoria"].ToString());
                    ate.FechaAtencion = dataReader["Password"].ToString();
                    ate.Matricula = int.Parse(dataReader["Matricula"].ToString());
                    ate.NroExpediente = int.Parse(dataReader["NroExpe"].ToString());

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR--->" + ex);
            }
            finally
            {
                cn.Close();
            }
            return ate;
        }


        private void buttonBaja_Click(object sender, EventArgs e)
        {
            if (textBoxNroAfiliado.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun afiliado para eliminar");
            }
            else
            {
                if (EliminarUsuario(textBoxNroAfiliado.Text))
                {
                    textBoxNroAfiliado.Text = "0";
                    textBoxNroAfiliado.Visible = false;

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
        private bool EliminarUsuario(string NroAfi)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Atenciones WHERE NroAfiliado= @nroafi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroafi", NroAfi);
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
