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
    public partial class AltaCategoria : Form
    {
        public AltaCategoria()
        {
            InitializeComponent();
        }

        private void AltaCategoria_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            txtCodDesc.Visible = false;
            lblCategoria.Visible = false;
            btnActualizar.Enabled = false;
        }

       
        private void cargarGrilla()
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

                grillaCategoria.DataSource = tabla;

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

        private Categoria ObtenerDatosCategoria()
        {
            Categoria cat = new Categoria();

            cat.CodCategoria = int.Parse(txtCodDesc.Text);
            cat.Descripcion = txtDescripcion.Text;
            return cat;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Categoria cat = ObtenerDatosCategoria();


                if (CargarCategoria(cat))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Categoria");
                }
            }
        }

        private bool CargarCategoria(Categoria cat)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "insert into Categorias VALUES (@desc)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@desc", cat.Descripcion);


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
            txtCodDesc.Visible = false;
            lblCategoria.Visible = false;
            btnActualizar.Enabled = false;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtCodDesc.Text = "0";
            
        }

        private void grillaCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice > -1)
            {
                
                DataGridViewRow filaSeleccionada = grillaCategoria.Rows[indice];
                string CodCat = filaSeleccionada.Cells["CodCategoria"].Value.ToString();
                Categoria cat = ObtenerCategoria(CodCat);
                LimpiarCampos();
                btnActualizar.Enabled = true;
                CargarCampos(cat);
            }
        }

        private Categoria ObtenerCategoria(string CodCat)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Categoria cat = new Categoria();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Categorias WHERE CodCategoria = @codcat";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codcat", CodCat);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    cat.CodCategoria = int.Parse(CodCat);
                    cat.Descripcion = dataReader["Descripcion"].ToString();
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
            return cat;
        }



        private void CargarCampos(Categoria bar)
        {
            txtCodDesc.Text = bar.CodCategoria.ToString();
            txtCodDesc.Visible = true;
            lblCategoria.Visible = true;
            txtDescripcion.Text = bar.Descripcion;

        }




        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");
            }
            else
            {
                Categoria cat = ObtenerDatosCategoria();
                if (ActualizarCategoria(cat))
                {
                    MessageBox.Show("Categoria Actualizada con exito");
                    txtCodDesc.Visible = false;
                    lblCategoria.Visible = false;
                    btnActualizar.Enabled = false;
                    txtCodDesc.Text = "0";
                    LimpiarCampos();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
        }


        private bool ActualizarCategoria(Categoria cat)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Categorias SET Descripcion = @desc" +
                    " WHERE CodCategoria = @codcat";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codcat", cat.CodCategoria);
                cmd.Parameters.AddWithValue("@desc", cat.Descripcion);
              

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
            
            if (txtCodDesc.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione alguna Categoria para eliminar");
            }
            else
            {
                if (EliminarCategoria(txtCodDesc.Text))
                {
                    MessageBox.Show("Eliminado con exito");
                    txtCodDesc.Visible = false;
                    lblCategoria.Visible = false;
                    btnActualizar.Enabled = false;
                    txtCodDesc.Text = "0";
                    cargarGrilla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }

        }

        private bool EliminarCategoria(string NroCat)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Categorias WHERE CodCategoria= @nrocat";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nrocat", NroCat);
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
            bool resultado = txtDescripcion.Text.Equals("");
            

            return resultado;
        }

       
    }
}

