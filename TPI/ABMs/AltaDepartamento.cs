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
    public partial class AltaDepartamento : Form
    {
        public AltaDepartamento()
        {
            InitializeComponent();
        }


        private void AltaDepartamento_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            mtbIdDepartamento.Enabled = false;
            mtbIdDepartamento.Visible = false;
            lblIdDepartamento.Visible = false;
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

                string consulta = "SELECT * FROM Departamento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dgbDepartamentos.DataSource = tabla;
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

        //obtiene los datos del Departamento ingresados y los guarda en un objeto Departamento
        private Departamento ObtenerDatosDepartamento()
        {
            Departamento dep = new Departamento();

            dep.IdDepartamento = int.Parse(mtbIdDepartamento.Text);
            dep.Nombre = tbNombre.Text.Trim();

            return dep;

        }

        //Boton que da de alta un departamento
        private void buttonAltaAfiliado_Click(object sender, EventArgs e)
        {

            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos", "Advertencia");
            }
            else
            {
                Departamento dep = ObtenerDatosDepartamento();


                if (CargarDepartamento(dep))
                {
                    MessageBox.Show("Cargado Con Exito", "Carga completa");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Departamento", "Advertencia");
                }
            }

        }
        //Metodo para cargar Departamento
        private bool CargarDepartamento(Departamento dep)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                
                string consulta = "insert into Departamento VALUES (@Nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", dep.Nombre);
               


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

        //Metodo para validar campos completos
        private bool validadIngresoDatos()
        {
            bool resultado = tbNombre.Text.Equals("");

            return resultado;
        }


        //Metodo para limpiar campos
        private void LimpiarCampos()
        {
            mtbIdDepartamento.Text = "";
            tbNombre.Text = "";
            
        }

        //Ejecuta metodo limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            mtbIdDepartamento.Visible = false;
            lblIdDepartamento.Visible = false;
            btnActualizar.Enabled = false;
        }

        private void dgbDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            mtbIdDepartamento.Visible = true;
            lblIdDepartamento.Visible = true;
            DataGridViewRow filaSeleccionada = dgbDepartamentos.Rows[indice];
            string IdDepartamento = filaSeleccionada.Cells["IdDEpartamento"].Value.ToString();
            Departamento dep = ObtenerDepartamento(IdDepartamento);
            LimpiarCampos();

            CargarCampos(dep);
        }

        //obtiene un objeto Departamento con todos sus datos para un idDepartamento especifico
        private Departamento ObtenerDepartamento(string IdDepartamento)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Departamento dep = new Departamento();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Departamento WHERE Id_Departamento = @IdDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    dep.IdDepartamento = int.Parse(IdDepartamento);
                    dep.Nombre = dataReader["Nombre"].ToString();

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
            return dep;
        }

        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Departamento dep)
        {
            mtbIdDepartamento.Text = dep.IdDepartamento.ToString();
            tbNombre.Text = dep.Nombre;
            

        }

        //Actualiza la BD y la grilla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos", "Advertencia");
            }
            else
            {
                Departamento dep = ObtenerDatosDepartamento();
                if (ActualizarDepartamento(dep))
                {
                    btnActualizar.Enabled = false;
                    mtbIdDepartamento.Visible = false;
                    lblIdDepartamento.Visible = false;

                    MessageBox.Show("Departamento Actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Advertencia");
                }
            }
        }

        private bool ActualizarDepartamento(Departamento dep)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Departamento SET  Nombre = @Nombre" +
                    " WHERE Id_Departamento = @Id_Departamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Departamento", dep.IdDepartamento);
                cmd.Parameters.AddWithValue("@Nombre", dep.Nombre);
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
        private void btnBajaDepartamento_Click(object sender, EventArgs e)
        {
            if (mtbIdDepartamento.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun Departamento para eliminar");
            }
            else
            {
                if (EliminarDepartamento(mtbIdDepartamento.Text))
                {
                    MessageBox.Show("Eliminado con exito");
                
                    CargarGrilla();
                    mtbIdDepartamento.Visible = false;
                    lblIdDepartamento.Visible = false;
                    btnActualizar.Enabled = false;
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar", "Advertencia");
                }
            }
        }

        //Elimina una fila/tupla de la BD
        private bool EliminarDepartamento(string IdDepartamento)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Departamento WHERE Id_Departamento = @IdDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", IdDepartamento);
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
