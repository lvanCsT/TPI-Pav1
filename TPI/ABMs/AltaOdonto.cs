using TPI.Entidades;
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

namespace TPI.ABMs
{
    public partial class AltaOdonto : Form
    {
        public AltaOdonto()
        {
            InitializeComponent();
        }

        private void AltaOdonto_Load(object sender, EventArgs e)
        {
            CargarComboTipoOdonto();
            CargarGrilla();
        }

        

        private void CargarComboTipoOdonto()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM tipoOdontologos";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;



                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                cmbTipoOdonto.DataSource = tabla;
                cmbTipoOdonto.DisplayMember = "nombre";
                cmbTipoOdonto.ValueMember = "tipoOdontologo";
                cmbTipoOdonto.SelectedIndex = -1;
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
        
        private void CargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Odontologos";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                GrillaOdontologos.DataSource = tabla;

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
        private Odontologo ObtenerDatosOdontologo()
        {
            Odontologo odonto = new Odontologo();

            odonto.Matricula = int.Parse(txtMatricula.Text);
            odonto.Apellido = txtApellido.Text.Trim();
            odonto.Nombre = txtNombre.Text.Trim();
            odonto.tipoOdontologo = (int)cmbTipoOdonto.SelectedValue;
            odonto.fechaDesde = txtFechaDesde.Text;
            odonto.fechaHasta = txtFechaHasta.Text;

            return odonto;
        }

        private void btnGuardarOdonto_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos, Por favor");

            }
            else
            {
                Odontologo odonto = ObtenerDatosOdontologo();


                if (CargarOdontologo(odonto))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    CargarComboTipoOdonto();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Odontologo");
                }
            }
        }
        private bool CargarOdontologo(Odontologo odonto)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Odontologos VALUES (@matricula,@nom,@ape,@tipoOdonto,CONVERT(DATETIME,@fechaDesde,103),CONVERT(DATETIME,@fechaHasta,103))";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", odonto.Matricula);
                cmd.Parameters.AddWithValue("@nom", odonto.Nombre);
                cmd.Parameters.AddWithValue("@ape", odonto.Apellido);
                cmd.Parameters.AddWithValue("@tipoOdonto", odonto.tipoOdontologo);
                cmd.Parameters.AddWithValue("@fechaDesde", odonto.fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", odonto.fechaHasta);

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



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMatricula.Text = "";
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            cmbTipoOdonto.SelectedIndex = -1;
        }
        private bool validadIngresoDatos()
        {
            bool resultado =
            txtMatricula.Text.Equals("") ||
            txtNombre.Text.Equals("") ||
            txtApellido.Text.Equals("") ||
            txtFechaDesde.Text.Equals("") ||
            txtFechaHasta.Text.Equals("") ||
            cmbTipoOdonto.SelectedText.Equals(null);

            return resultado;
        }

        private void GrillaOdontologos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = GrillaOdontologos.Rows[indice];
            string Matricula = filaSeleccionada.Cells["Matricula"].Value.ToString();
            Odontologo odonto = ObtenerOdontologo(Matricula);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(odonto);
        }
        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Odontologo odonto)
        {
            txtMatricula.Text = odonto.Matricula.ToString();
            txtNombre.Text = odonto.Nombre;
            txtApellido.Text = odonto.Apellido;
            cmbTipoOdonto.SelectedValue = odonto.tipoOdontologo;
            txtFechaDesde.Text = odonto.fechaDesde;
            txtFechaHasta.Text = odonto.fechaHasta;
        }
        //obtiene un objeto odontologo con todos sus datos para una matricula
        private Odontologo ObtenerOdontologo(string Matricula)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Odontologo odonto = new Odontologo();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Odontologos WHERE Matricula = @Matricula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Matricula", Matricula);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    odonto.Matricula = int.Parse(Matricula);
                    odonto.Nombre = dataReader["Nombre"].ToString();
                    odonto.Apellido = dataReader["Apellido"].ToString();
                    odonto.tipoOdontologo = int.Parse(dataReader["tipoOdontologo"].ToString());
                    odonto.fechaHasta = dataReader["fechaHasta"].ToString();
                    odonto.fechaDesde = dataReader["fechaDesde"].ToString();
                    

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
            return odonto;
        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Odontologo odonto = ObtenerDatosOdontologo();
                if (ActualizarOdontologo(odonto))
                {
                    btnActualizar.Enabled = false;
                   
                    MessageBox.Show("Odontologo Actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();
                    CargarComboTipoOdonto();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }

        //actualiza la BD
        private bool ActualizarOdontologo(Odontologo odonto)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Odontologos SET  Nombre = @nom, Apellido = @ape, tipoOdontologo = @tipoOdonto,fechaDesde = CONVERT(DATETIME,@fechaDesde,103),fechaHasta = CONVERT(DATETIME,@fechaHasta,103)" +
                    " WHERE Matricula = @matricula";
               
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@matricula", odonto.Matricula);
                cmd.Parameters.AddWithValue("@nom", odonto.Nombre);
                cmd.Parameters.AddWithValue("@ape", odonto.Apellido);
                cmd.Parameters.AddWithValue("@tipoOdonto", odonto.tipoOdontologo);
                cmd.Parameters.AddWithValue("@fechaDesde", odonto.fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", odonto.fechaHasta);
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

            if (txtMatricula.Text.Equals(""))
            {
                MessageBox.Show("Seleccione algun Odontologo para eliminar");
            }
            else
            {
                if (EliminarOdontologo(txtMatricula.Text))
                {
                    txtMatricula.Text = "0";
                    
                    MessageBox.Show("Eliminado con exito");
                    CargarGrilla();
                    LimpiarCampos();
                    CargarComboTipoOdonto();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }
        }

        //Elimina una fila/tupla de la base de datos
        private bool EliminarOdontologo(string Matricula)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Odontologos WHERE Matricula= @Matricula";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Matricula", Matricula);
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
