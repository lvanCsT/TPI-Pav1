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
    public partial class AltaElemento
        : Form
    {
        public AltaElemento()
        {
            InitializeComponent();
        }

        private void AltaElemento_Load(object sender, EventArgs e)
        {
            cmbNombreElemento.Items.Add("Incisivo frontal superior");
            cmbNombreElemento.Items.Add("Incisivo frontal inferior");
            cmbNombreElemento.Items.Add("Incisivo lateral superior");
            cmbNombreElemento.Items.Add("Incisivo lateral inferior");
            cmbNombreElemento.Items.Add("Canino");
            cmbNombreElemento.Items.Add("Primer premolar superior");
            cmbNombreElemento.Items.Add("Primer premolar inferior");
            cmbNombreElemento.Items.Add("Primer premolar superior");
            cmbNombreElemento.Items.Add("Primer premolar inferior");
            cmbNombreElemento.Items.Add("Segundo premolar superior");
            cmbNombreElemento.Items.Add("Tercer premolar superior");
            cmbNombreElemento.Items.Add("Segundo premolar inferior");
            cmbNombreElemento.Items.Add("Tercer premolar inferior");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNroElemento.Text = "";
            cmbNombreElemento.SelectedIndex = -1;
        }


        //obtiene los datos del Elemento ingresados en los textbox y los guarda en un objeto Elemento
        private Elemento ObtenerDatosElemento()
        {
            Elemento ele = new Elemento();

            ele.NroElemento = int.Parse(txtNroElemento.Text);
            ele.Nombre = cmbNombreElemento.GetItemText(cmbNombreElemento.SelectedItem);
            return ele;

        }

        //es la carga del Elemento a la base de datos
        private bool CargarElemento(Elemento ele)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            bool Resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Elementos VALUES (@nro,@nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nro", ele.NroElemento);
                cmd.Parameters.AddWithValue("@nombre", ele.Nombre);

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

        //carga la grilla con la BD
        private void CargarGrilla()
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Elementos";

                cmd.Parameters.Clear();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabla);

                dataGridViewPres.DataSource = tabla;

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

        private void btnAltaElemento_Click(object sender, EventArgs e)
        {
            if (validarIngresoDatos())
            {
                MessageBox.Show("Ingrese Todos los datos");

            }
            else
            {
                Elemento ele = ObtenerDatosElemento();


                if (CargarElemento(ele))
                {
                    MessageBox.Show("Cargado Con Exito");
                    LimpiarCampos();
                    CargarGrilla();
                }
                else
                {
                    MessageBox.Show("Error al cargar el Elemento");
                }
            }
        }

        private bool validarIngresoDatos()
        {
            bool resultado = cmbNombreElemento.SelectedText.Equals(null) ||
            txtNroElemento.Text.Equals("");

            return resultado;
        }

        //obtiene un objeto elemento con todos sus datos para un nro de elemento especifico
        private Elemento ObtenerElemento(string nroEle)
        {
            string cadenaConex = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConex);
            Elemento ele = new Elemento();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT * FROM Elementos WHERE NroElemento = @nroele";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nroele", nroEle);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader != null && dataReader.Read())
                {
                    ele.NroElemento = int.Parse(nroEle);
                    ele.Nombre = dataReader["Nombre"].ToString();

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
            return ele;
        }

        //carga los textbox con los datos de la BD para luego modificar
        private void CargarCampos(Elemento ele)
        {
            txtNroElemento.Text = ele.NroElemento.ToString();
            txtNroElemento.Visible = true;
            lblNroElemento.Visible = true;
            cmbNombreElemento.SelectedValue = ele.Nombre;
        }

        //Muestra los datos de un afiliado al clickear en la grilla una de las filas

        private void dataGridViewPres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            btnActualizar.Enabled = true;
            DataGridViewRow filaSeleccionada = dataGridViewPres.Rows[indice];
            string nroElemento = filaSeleccionada.Cells["NroElemento"].Value.ToString();
            Elemento ele = ObtenerElemento(nroElemento);
            LimpiarCampos();
            //el comando de abajo
            CargarCampos(ele);
        }
    }
}
