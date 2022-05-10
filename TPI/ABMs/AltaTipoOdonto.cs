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
    public partial class AltaTipoOdonto : Form
    {
        public AltaTipoOdonto()
        {
            InitializeComponent();
        }

        private void AltaTipoOdonto_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            txtTipoOdonto.Visible = false;
            lblTipoOdonto.Visible = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoOdontologos";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                GrillaTipoOdonto.DataSource = tabla;

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

        private TipoOdontologo ObtenerDatosTipoOdonto()
        {
            TipoOdontologo TipoOdonto = new TipoOdontologo();
            TipoOdonto.Nombre = txtNombre.Text.Trim();
            TipoOdonto.tipoOdontologo = int.Parse(txtTipoOdonto.Text);
            return TipoOdonto;
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {

            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos, Por favor");

            }
            else
            {
                TipoOdontologo TipoOdonto = ObtenerDatosTipoOdonto();


                if (CargarTipoOdonto(TipoOdonto))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el TipoOdonto");
                }
            }
        }
        private bool CargarTipoOdonto(TipoOdontologo TipoOdonto)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into TipoOdontologos VALUES (@nom)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", TipoOdonto.Nombre);


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
            btnActualizar.Enabled = false;
            txtTipoOdonto.Visible = false;
            lblTipoOdonto.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtTipoOdonto.Text = "0";
        }
        private bool validadIngresoDatos()
        {
            bool resultado =
            txtNombre.Text.Equals("");

            return resultado;
        }


        private void GrillaTipoOdonto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            txtTipoOdonto.Visible = true;
            lblTipoOdonto.Visible = true;
            DataGridViewRow filaSeleccionada = GrillaTipoOdonto.Rows[indice];
            string TipoOdontologo = filaSeleccionada.Cells["tipoOdontologo"].Value.ToString();
            TipoOdontologo TipoOdonto = ObtenerTipoOdonto(TipoOdontologo);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(TipoOdonto);
        }
        private void CargarCampos(TipoOdontologo TipoOdonto)
        {
            txtTipoOdonto.Text = TipoOdonto.tipoOdontologo.ToString();
            
            txtNombre.Text = TipoOdonto.Nombre;
        }
        private TipoOdontologo ObtenerTipoOdonto(string TipoOdontologo)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            TipoOdontologo tipoOdonto = new TipoOdontologo();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoOdontologos WHERE tipoOdontologo = @TipoOdontologo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@TipoOdontologo", TipoOdontologo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    tipoOdonto.tipoOdontologo = int.Parse(TipoOdontologo);
                    tipoOdonto.Nombre = dataReader["Nombre"].ToString();
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
            return tipoOdonto;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                TipoOdontologo tipoOdonto = ObtenerDatosTipoOdonto();
                if (ActualizarTipoOdonto(tipoOdonto))
                {
                    btnActualizar.Enabled = false;

                    txtTipoOdonto.Visible = false;
                    lblTipoOdonto.Visible = false;
                    MessageBox.Show("tipoOdonto Actualizado con exito");
                    LimpiarCampos();
                    CargarGrilla();

                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }
        private bool ActualizarTipoOdonto(TipoOdontologo tipoOdonto)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE TipoOdontologos SET  Nombre = @nom" +
                    " WHERE tipoOdontologo = @tipoOdontologo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoOdontologo", tipoOdonto.tipoOdontologo);
                cmd.Parameters.AddWithValue("@nom", tipoOdonto.Nombre);

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


        private void btnELiminar_Click(object sender, EventArgs e)
        {
            if (txtTipoOdonto.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun TipoOdontologo para eliminar");
            }
            else
            {
                if (EliminartipoOdonto(txtTipoOdonto.Text))
                {
                    txtTipoOdonto.Text = "0";
                    txtTipoOdonto.Visible = false;
                    lblTipoOdonto.Visible = false;
                    btnActualizar.Enabled = false;

                    MessageBox.Show("Eliminado con exito");
                    CargarGrilla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }
        }
        //Elimina una fila/tupla de la base de datos
        private bool EliminartipoOdonto(string tipoOdonto)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM TipoOdontologos WHERE tipoOdontologo= @tipoOdonto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipoOdonto", tipoOdonto);
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
