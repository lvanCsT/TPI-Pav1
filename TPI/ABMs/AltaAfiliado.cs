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
    public partial class AltaAfiliado : Form
    {
        public AltaAfiliado()
        {
            InitializeComponent();
        }

        private void AltaAfiliado_Load(object sender, EventArgs e)
        {
            buttonActualizar.Enabled = false;
            textBoxNroAfiliado.Visible = false;
            labelNroAfiliado.Visible = false;
            cargarGrilla();
            CargarComboCategoria();
            CargarComboBarrio();
            CargarComboTipoDoc();

        }
        //Las 3 funciones cargan el combobox con la BD
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

        private void CargarComboBarrio()
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

                comboBoxBarrio.DataSource = tabla;
                comboBoxBarrio.DisplayMember = "nombre";
                comboBoxBarrio.ValueMember = "NroBarrio";
                comboBoxBarrio.SelectedIndex = -1;
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

        private void CargarComboTipoDoc()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM TipoDocumentos";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                comboBoxTipoDoc.DataSource = tabla;
                comboBoxTipoDoc.DisplayMember = "Descripcion";
                comboBoxTipoDoc.ValueMember = "CodTipo";
                comboBoxTipoDoc.SelectedIndex = -1;
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

        //carga la grilla con la BD
        private void cargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Afiliados";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewAfiliados.DataSource = tabla;

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

        //obtiene los datos del afiliado ingresados en los textbox y los guarda en un objeto Afiliado
        private Afiliado ObtenerDatosAfiliado()
        {
            Afiliado afi = new Afiliado();

            afi.NroAfiliado = int.Parse(textBoxNroAfiliado.Text);
            afi.Categoria = (int)comboBoxCateg.SelectedValue;
            afi.Apellido = textBoxApe.Text.Trim();
            afi.Nombre = textBoxNom.Text.Trim();
            afi.TipoDoc = (int)comboBoxTipoDoc.SelectedValue;
            afi.NroDoc = int.Parse(maskedTextBoxNroDocumento.Text);
            afi.FechaNacimiento = maskedTextBoxFechaNac.Text;
            afi.Calle = textBoxCalle.Text.Trim();
            afi.NroCalle = int.Parse(maskedTextBoxNroCalle.Text);
            afi.Barrio = (int)comboBoxTipoDoc.SelectedValue;

            return afi;

        }

        //se ejecuta la carga del afiliado y resetea la grilla
        private void buttonAltaAfiliado_Click(object sender, EventArgs e)
        {
            if (validadIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");

            }
            else
            {
                Afiliado afi = ObtenerDatosAfiliado();


                if (CargarAfiliado(afi))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    CargarComboCategoria();
                    CargarComboBarrio();
                    CargarComboTipoDoc();
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Afiliado");
                }
            }
        }

        //es la carga del afiliado a la base de datos
        private bool CargarAfiliado(Afiliado afi)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Afiliados VALUES (@codCat,@ape,@nom,@tipoDoc,@nroDoc,CONVERT(DATETIME,@fechaNac,103),@calle,@nroCalle,@barrio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codCat", afi.Categoria);
                cmd.Parameters.AddWithValue("@ape", afi.Apellido);
                cmd.Parameters.AddWithValue("@nom", afi.Nombre);
                cmd.Parameters.AddWithValue("@tipoDoc", afi.TipoDoc);
                cmd.Parameters.AddWithValue("@nroDoc", afi.NroDoc);
                cmd.Parameters.AddWithValue("@fechaNac", afi.FechaNacimiento);
                cmd.Parameters.AddWithValue("@calle", afi.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", afi.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", afi.Barrio);

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
            textBoxNroAfiliado.Visible = false;
            labelNroAfiliado.Visible = false;
            buttonActualizar.Enabled = false;
        }

        //Limpia los campos
        private void LimpiarCampos()
        {
            
            comboBoxCateg.SelectedValue = -1;
            textBoxApe.Text = "";
            textBoxNom.Text = "";
            comboBoxTipoDoc.SelectedValue = -1;
            maskedTextBoxNroDocumento.Text = "";
            maskedTextBoxFechaNac.Text = "";
            textBoxCalle.Text = "";
            maskedTextBoxNroCalle.Text = "";
            comboBoxBarrio.SelectedValue = -1;
        }

        //Muestra los datos de un afiliado al clickear en la grilla una de las filas
        private void dataGridViewAfiliados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            buttonActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridViewAfiliados.Rows[indice];
            string nroAfiliado = filaSeleccionada.Cells["NroAfiliado"].Value.ToString();
            Afiliado afi = ObtenerAfiliado(nroAfiliado);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(afi);

        }
        
        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Afiliado afi)
        {
            textBoxNroAfiliado.Text = afi.NroAfiliado.ToString();
            textBoxNroAfiliado.Visible = true;
            labelNroAfiliado.Visible = true;
            comboBoxCateg.SelectedValue = afi.Categoria;
            textBoxApe.Text = afi.Apellido;
            textBoxNom.Text = afi.Nombre;
            comboBoxTipoDoc.SelectedValue = afi.TipoDoc;
            maskedTextBoxNroDocumento.Text = afi.NroDoc.ToString();
            maskedTextBoxFechaNac.Text = afi.FechaNacimiento;
            textBoxCalle.Text = afi.Calle;
            maskedTextBoxNroCalle.Text = afi.NroCalle.ToString();
            comboBoxBarrio.SelectedValue = afi.Barrio;
        }


        //obtiene un objeto afiliado con todos sus datos para un nro de afiliado especifico
        private Afiliado ObtenerAfiliado(string Nroafi)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Afiliado afi = new Afiliado();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Afiliados WHERE NroAfiliado = @nroafi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroafi", Nroafi);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    afi.NroAfiliado = int.Parse(Nroafi);
                    afi.Categoria = int.Parse(dataReader["CodCategoria"].ToString());
                    afi.Apellido = dataReader["Apellido"].ToString();
                    afi.Nombre = dataReader["Nombre"].ToString();
                    afi.TipoDoc = int.Parse(dataReader["TipoDoc"].ToString());
                    afi.NroDoc = int.Parse(dataReader["NroDoc"].ToString());
                    afi.FechaNacimiento = dataReader["Fecha_Nacimiento"].ToString();
                    afi.Calle = dataReader["Calle"].ToString();
                    afi.NroCalle = int.Parse(dataReader["Nro_Calle"].ToString());
                    afi.Barrio = int.Parse(dataReader["Id_Barrio"].ToString());
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
            return afi;
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
                Afiliado afi = ObtenerDatosAfiliado();
                if (ActualizarAfiliado(afi))
                {
                    buttonActualizar.Enabled = false;
                    textBoxNroAfiliado.Visible = false;
                    labelNroAfiliado.Visible = false;

                    MessageBox.Show("Afiliado Actualizado con exito");
                    LimpiarCampos();
                    cargarGrilla();
                    CargarComboBarrio();
                    CargarComboCategoria();
                    CargarComboTipoDoc();
                }
                else
                {
                    MessageBox.Show("Error al actualizar");
                }
            }
            
        }

        //actualiza la BD
        private bool ActualizarAfiliado(Afiliado afi)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "UPDATE Afiliados SET CodCategoria = @codCat, Apellido = @ape,Nombre = @nom, TipoDoc = @tipoDoc,NroDoc = @nroDoc,Fecha_Nacimiento = CONVERT(DATETIME,@fechaNac,103),Calle = @calle,Nro_Calle = @nroCalle,Id_Barrio = @barrio" +
                    " WHERE NroAfiliado = @nroafi";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroafi", afi.NroAfiliado);
                cmd.Parameters.AddWithValue("@codCat", afi.Categoria);
                cmd.Parameters.AddWithValue("@ape", afi.Apellido);
                cmd.Parameters.AddWithValue("@nom", afi.Nombre);
                cmd.Parameters.AddWithValue("@tipoDoc", afi.TipoDoc);
                cmd.Parameters.AddWithValue("@nroDoc", afi.NroDoc);
                cmd.Parameters.AddWithValue("@fechaNac", afi.FechaNacimiento);
                cmd.Parameters.AddWithValue("@calle", afi.Calle);
                cmd.Parameters.AddWithValue("@nroCalle", afi.NroCalle);
                cmd.Parameters.AddWithValue("@barrio", afi.Barrio);

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
            if (textBoxNroAfiliado.Text.Equals("0"))
            {
                MessageBox.Show("Seleccione algun afiliado para eliminar");
            }
            else
            {
                if (EliminarAfiliado(textBoxNroAfiliado.Text))
                {
                    textBoxNroAfiliado.Text = "0";
                    textBoxNroAfiliado.Visible = false;
                    labelNroAfiliado.Visible = false;
                    buttonEliminar.Enabled = false;

                    MessageBox.Show("Eliminado con exito");
                    cargarGrilla();
                    LimpiarCampos();
                    CargarComboBarrio();
                    CargarComboCategoria();
                    CargarComboTipoDoc();
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar");
                }
            }
            
        }

        //Elimina una fila/tupla de la base de datos
        private bool EliminarAfiliado(string NroAfi) 
        {
            bool Resultado = false;
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = " DELETE FROM Afiliados WHERE NroAfiliado= @nroafi";
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

        private bool validadIngresoDatos()
        {
            bool resultado = comboBoxCateg.SelectedText.Equals(null) ||
            textBoxApe.Text.Equals("") ||
            textBoxNom.Text.Equals("") ||
            comboBoxTipoDoc.SelectedText.Equals(null) ||
            maskedTextBoxNroDocumento.Text.Equals("") ||
            maskedTextBoxFechaNac.Text.Equals("") ||
            textBoxCalle.Text.Equals("") ||
            maskedTextBoxNroCalle.Text.Equals("") ||
            comboBoxBarrio.SelectedText.Equals(null);

            return resultado;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
