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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            textBoxNroAfiliado.Visible = false;
            labelNroAfiliado.Visible = false;
            buttonActualizar.Enabled = false;
            cargarGrilla();

        }

        //Carga la grilla de Usuarios con la BD
        private void cargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuarios";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewUsuarios.DataSource = tabla;

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

        //Guardo los datos cargados en el form y los guarda en un objeto Usuario
        private Usuario ObtenerDatosUsuario()
        {
            Usuario usu = new Usuario();
            usu.Nombre = textBoxNom_Usu.Text;
            usu.Password = textBoxPass.Text;

            return usu;
        }




        //Llevo a cabo la alta del usuario.
        private void buttonAltaUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MessageBox.Show("Ingrese Todos los Datos y controle las contraseñas!");
            }
            else
            {
                try
                {
                    Usuario usu = ObtenerDatosUsuario();
                    if (CargarUsuario(usu))
                    {
                        MessageBox.Show("Cargado Con Exito");
                        LimpiarCampos();
                        cargarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar nuevo usuario.");
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Error al insertar nuevo usuario");
                    textBoxNom_Usu.Focus();
                }

            }
        }
        //Limpia los campos del form.
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            textBoxNom_Usu.Text = "";
            textBoxPass.Text = "";
            textBoxRep_Pass.Text = "";
        }

        

        //Realizo la consulta sql donde cargo el usuario en la BD
        private bool CargarUsuario(Usuario usu)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Usuarios (NombreUsuario, Password) VALUES (@nombreUsu, @pass)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreUsu", usu.Nombre);
                cmd.Parameters.AddWithValue("@pass", usu.Password);

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
        //Realizo la consulta mediante el click en la grilla
        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = dataGridViewUsuarios.Rows[indice];
            string nroAfiliado = filaSeleccionada.Cells["NroAfiliado"].Value.ToString();
            Usuario usu = ObtenerUsuario(nroAfiliado);
            LimpiarCampos();
            CargarCampos(usu);
        }




        //obtiene un objeto afiliado con todos sus datos para un nro de afiliado especifico
        private Usuario ObtenerUsuario(string Nroafi)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Usuario usu = new Usuario();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Usuarios WHERE NroAfiliado = @nroafi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroafi", Nroafi);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    usu.NroAfiliado = int.Parse(Nroafi);
                    usu.Nombre = dataReader["NombreUsuario"].ToString();
                    usu.Password = dataReader["Password"].ToString();

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
            return usu;
        }


        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Usuario usu)
        {
            textBoxNroAfiliado.Text = usu.NroAfiliado.ToString();
            textBoxNroAfiliado.Visible = true;
            labelNroAfiliado.Visible = true;
            buttonActualizar.Enabled = true;
            textBoxPass.Text = usu.Password;
            textBoxRep_Pass.Text = usu.Password;
            textBoxNom_Usu.Text = usu.Nombre;
        }

 

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Usuario usu = ObtenerDatosUsuario();
                if (ActualizarUsuario(usu))
                {
                    buttonActualizar.Enabled = false;
                    textBoxNroAfiliado.Visible = false;
                    labelNroAfiliado.Visible = false;

                    MessageBox.Show("Usuario Actualizado con exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }

        ///aclaraciones a partir de aca:
        ///no logre actualizar la grilla.
        private bool ActualizarUsuario(Usuario usu)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Usuarios SET NombreUsuario = @nom, Password = @passw" + " WHERE NroAfiliado = @nroafi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroafi", usu.NroAfiliado);
                cmd.Parameters.AddWithValue("@nom", usu.Nombre);
                cmd.Parameters.AddWithValue("@passw", usu.Password);

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




        //Valido que los datos esten cargados y que las passwords sean iguales.
        private bool ValidarDatos()
        {
            bool resultado = textBoxNom_Usu.Text.Equals("") ||
                textBoxPass.Text.Equals("") ||
                textBoxRep_Pass.Text.Equals("") ||
                textBoxRep_Pass.Text != textBoxPass.Text;
            return resultado;

        }

        private void buttonBajaUsuario_Click(object sender, EventArgs e)
        {
            if (textBoxNroAfiliado.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun Usuario para eliminar");
            }
            else
            {
                if (EliminarUsuario(textBoxNroAfiliado.Text))
                {
                    textBoxNroAfiliado.Text = "0";
                    textBoxNroAfiliado.Visible = false;
                    labelNroAfiliado.Visible = false;

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

                string consulta = " DELETE FROM Usuarios WHERE NroAfiliado= @nroafi";
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
