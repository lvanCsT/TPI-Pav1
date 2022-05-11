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
    public partial class AltaCiudades : Form
    {
        public AltaCiudades()
        {
            InitializeComponent();
        }

        private void AltaCiudades_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            CargarComboDepartamento();
            txtIdCiudad.Visible = false;
            lblCiudad.Visible = false;
            btnActualizar.Enabled = false;
        }

        private void CargarComboDepartamento()
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

                cmbDepartamento.DataSource = tabla;
                cmbDepartamento.DisplayMember = "Nombre";
                cmbDepartamento.ValueMember = "Id_Departamento";
                cmbDepartamento.SelectedIndex = -1;
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

                string consulta = "SELECT * FROM Ciudades";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);
                grillaCiudades.DataSource = tabla;

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

        private Ciudad ObtenerDatosCiudad()
        {
            Ciudad ciu = new Ciudad();

            ciu.Id_ciudad = int.Parse(txtIdCiudad.Text);
            ciu.Nombre = txtNombre.Text.Trim();
            ciu.Id_departamento = (int)cmbDepartamento.SelectedValue;

            return ciu;
        }

        private void btnAgregarCiudad_Click(object sender, EventArgs e)
        {
            
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Ciudad ciu = ObtenerDatosCiudad();


                if (CargarCiudad(ciu))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    cargarGrilla();
                    CargarComboDepartamento();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Ciudad");
                }
            }
        }

        private bool CargarCiudad(Ciudad ciu)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insert into Ciudades VALUES (@nom, @id_dep)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", ciu.Nombre);
                cmd.Parameters.AddWithValue("@id_dep", ciu.Id_departamento);


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


       
        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            txtIdCiudad.Visible = false;
            lblCiudad.Visible = false;
            btnActualizar.Enabled = false;
            LimpiarCampos();
        }

        
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            cmbDepartamento.SelectedValue = -1;
            txtIdCiudad.Text = "0";

        }

        private void grillaCiudades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {

                DataGridViewRow filaSeleccionada = grillaCiudades.Rows[indice];
                string CodCiu = filaSeleccionada.Cells["Id_Ciudad"].Value.ToString();
                Ciudad ciu = ObtenerCiudad(CodCiu);
                LimpiarCampos();
                btnActualizar.Enabled = true;
                CargarCampos(ciu);
            }
        }

        private Ciudad ObtenerCiudad(string CodCiu)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Ciudad ciu = new Ciudad();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Ciudades WHERE Id_Ciudad = @id_ciu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ciu", CodCiu);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    ciu.Id_ciudad = int.Parse(CodCiu);
                    ciu.Nombre = dataReader["Nombre"].ToString();
                    ciu.Id_departamento = int.Parse(dataReader["Id_Departamento"].ToString());
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
            return ciu;
        }

        private void CargarCampos(Ciudad ciu)
        {
            txtIdCiudad.Text = ciu.Id_ciudad.ToString();
            txtIdCiudad.Visible = true;
            lblCiudad.Visible = true;
            txtNombre.Text = ciu.Nombre;
            cmbDepartamento.SelectedValue = ciu.Id_departamento;

        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Ciudad ciu = ObtenerDatosCiudad();
                if (ActualizarCiudad(ciu))
                {
                    MessageBox.Show("Ciudad Actualizada con exito");
                    txtIdCiudad.Visible = false;
                    lblCiudad.Visible = false;
                    btnActualizar.Enabled = false;
                    txtIdCiudad.Text = "0";
                    LimpiarCampos();
                    cargarGrilla();
                    CargarComboDepartamento();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }


        private bool ActualizarCiudad(Ciudad ciu)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Ciudades SET Nombre = @nom, Id_Departamento = @id_dep" +
                    " WHERE Id_Ciudad = @id_ciu";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ciu", ciu.Id_ciudad);
                cmd.Parameters.AddWithValue("@nom", ciu.Nombre);
                cmd.Parameters.AddWithValue("@id_dep", ciu.Id_departamento);

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (txtIdCiudad.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione alguna Ciudad para eliminar");
            }
            else
            {
                if (EliminarCiudad(txtIdCiudad.Text))
                {
                    MessageBox.Show("Eliminado con exito");
                    txtIdCiudad.Visible = false;
                    lblCiudad.Visible = false;
                    btnActualizar.Enabled = false;
                    txtIdCiudad.Text = "0";
                    cargarGrilla();
                    CargarComboDepartamento();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }

        }

      
        private bool EliminarCiudad(string CodCiu)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Ciudades WHERE Id_Ciudad= @id_ciudad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ciudad", CodCiu);
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
            bool resultado = txtNombre.Text.Equals("") || cmbDepartamento.SelectedValue.Equals(-1);


            return resultado;
        }

    }
}

