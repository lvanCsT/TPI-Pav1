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
    public partial class AltaDocumento : Form
    {
        public AltaDocumento()
        {
            InitializeComponent();
        }

        private void AltaDocumento_Load(object sender, EventArgs e)
        {
            btnActualizar.Enabled = false;
            maskedCodDoc.Enabled = false;
            maskedCodDoc.Visible = false;
            lblCodigoDocumento.Visible = false;
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

                string consulta = "SELECT * FROM Documentos";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dgvDoc.DataSource = tabla;
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

        //obtiene los datos del Documento ingresados y los guarda en un objeto Documento
        private Documento ObtenerDatosDocumento()
        {
            Documento doc = new Documento();
            doc.CodigoDocumento = int.Parse(maskedCodDoc.Text);
            doc.Nombre = tbNombre.Text.Trim();
            doc.Descripcion = rtbDescripcion.Text;

            return doc;

        }

        private void btnAltaDocumento_Click(object sender, EventArgs e)
        {
            if (validarIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos", "Advertencia");
            }
            else
            {
                Documento doc = ObtenerDatosDocumento();


                if (CargarDocumento(doc))
                {
                    MessageBox.Show("Cargado Con Exito", "Carga completa");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Estado", "Advertencia");
                }
            }
        }

        //Metodo para validar campos completos
        private bool validarIngresoDatos()
        {
            bool resultado = tbNombre.Text.Equals("") || rtbDescripcion.Text.Equals("");

            return resultado;
        }

        //Metodo para cargar Estado
        private bool CargarDocumento(Documento doc)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Documentos VALUES (@Nombre, @Descripcion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", doc.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", doc.Descripcion);


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

        //Metodo para limpiar campos
        private void LimpiarCampos()
        {
            maskedCodDoc.Text = "0";
            tbNombre.Text = "";
            rtbDescripcion.Text = "";
        }

        //Ejecuta metodo limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            maskedCodDoc.Visible = false;
            lblCodigoDocumento.Visible = false;
            btnActualizar.Enabled = false;
        }

        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Documento doc)
        {
            maskedCodDoc.Text = doc.CodigoDocumento.ToString();
            tbNombre.Text = doc.Nombre;
            rtbDescripcion.Text = doc.Descripcion;
        }

        //obtiene un objeto Documento con todos sus datos para un codigo documento especifico
        private Documento ObtenerDocumento(string CodigoDocumento)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Documento doc = new Documento();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Documentos WHERE CodDocumento = @CodigoDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodigoDocumento", CodigoDocumento);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    doc.CodigoDocumento = int.Parse(CodigoDocumento);
                    doc.Nombre = dataReader["Nombre"].ToString();
                    doc.Descripcion = dataReader["Descripcion"].ToString();

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
            return doc;
        }

        //Metodo para seleccionar celda
        private void dgvDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            maskedCodDoc.Visible = true;
            lblCodigoDocumento.Visible = true;
            DataGridViewRow filaSeleccionada = dgvDoc.Rows[indice];
            string CodigoDocumento = filaSeleccionada.Cells["CodigoDocumento"].Value.ToString();
            Documento doc = ObtenerDocumento(CodigoDocumento);
            LimpiarCampos();

            CargarCampos(doc);
        }

        //Actualiza la BD y la grilla
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos", "Advertencia");
            }
            else
            {
                Documento doc = ObtenerDatosDocumento();
                if (ActualizarDocumento(doc))
                {
                    btnActualizar.Enabled = false;
                    maskedCodDoc.Visible = false;
                    lblCodigoDocumento.Visible = false;

                    MessageBox.Show("Documento actualizado con éxito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Advertencia");
                }
            }
        }
        private bool ActualizarDocumento(Documento doc)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Documentos SET Descripcion = @Descripcion, Nombre = @Nombre" +
                    " WHERE CodDocumento = @CodDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodDocumento", doc.CodigoDocumento);
                cmd.Parameters.AddWithValue("@Nombre", doc.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", doc.Descripcion);
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

        private void btnBajaDocumento_Click(object sender, EventArgs e)
        {
            if (maskedCodDoc.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun Documento para eliminar");
            }
            else
            {
                if (EliminarDocumento(maskedCodDoc.Text))
                {
                    MessageBox.Show("Eliminado con exito");
                    CargarGrilla();
                    LimpiarCampos();
                    maskedCodDoc.Visible = false;
                    lblCodigoDocumento.Visible = false;
                    btnActualizar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar", "Advertencia");
                }
            }
        }
        //Elimina una fila/tupla de la BD
        private bool EliminarDocumento(string CodigoDocumento)
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Documentos WHERE CodDocumento = @CodigoDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@CodigoDocumento", CodigoDocumento);
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
