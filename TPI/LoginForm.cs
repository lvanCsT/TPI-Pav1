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

namespace TPI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            textBoxNombreUsuario.Text = "";
            textBoxPassword.Text = "";
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidarUsuario(textBoxNombreUsuario.Text.Trim(), textBoxPassword.Text.Trim()))
                {
                MessageBox.Show("Datos correctos. \nINGRESANDO...");
                    Escritorio ventana = new Escritorio();

                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos. \nIngrese algun usuario existente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al consultar usuario...");
            }
        }

        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                bool resultado = false;
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT [NroAfiliado] FROM Usuarios WHERE NombreUsuario like @nomusu AND Password like @pass";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomusu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(tabla);
                
                //MessageBox.Show(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                };
                return resultado;
            }
            catch(Exception) 
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
