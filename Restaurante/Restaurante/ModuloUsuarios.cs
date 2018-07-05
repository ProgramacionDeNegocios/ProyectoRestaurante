using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Restaurante
{
    public partial class ModuloUsuarios : Form
    {
        public ModuloUsuarios()
        {
            InitializeComponent();
        }

        private void ModuloUsuarios_Load(object sender, EventArgs e)
        {
            
            CargarCMBDepartamento();
            ResetFormulario();
        }

        private void ResetFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtClave.Text = "";
            cmbDepartamento.SelectedValue = "";
            dgwUsuarios.DataSource = "";
            CargarDGWUsuarios();
        }

        private void CargarCMBDepartamento()
        {
            DataTable dt = new DataTable();
            Clases.Conexion conexion = new Clases.Conexion();
                string sql = "select * FROM Acceso.TipoAcceso";
                SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "departamento";
            cmbDepartamento.DataSource = dt;
        }

        private void CargarDGWUsuarios()
        {
            Clases.Conexion conexion = new Clases.Conexion();

            //colocar el nombre del area a la cual pertenece el usuario en el strin de conexion
            string sql = @"SELECT   Acceso.Usuarios.id          as Código,
                                    Acceso.Usuarios.nombre      as Nombre, 
                                    Acceso.Usuarios.apellido    as Apellido, 
                                    Acceso.Usuarios.usuario     as Usuario,
                                    Acceso.TipoAcceso.departamento as Departamento
                            FROM Acceso.TipoAcceso 
                            INNER JOIN Acceso.Usuarios 
                            ON Acceso.TipoAcceso.id = Acceso.Usuarios.departamento";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Acceso.Usuarios");
                DataTable dt = ds.Tables["Acceso.Usuarios"];
                DataView dv = new DataView(dt,
                    "",
                    "Código",
                    DataViewRowState.Unchanged);
                dgwUsuarios.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Informacion");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.Usuario usuario = new Clases.Usuario();
            Clases.TipoAcceso tipoAcceso = new Clases.TipoAcceso();
            tipoAcceso.ObtenerPorDepartamento(cmbDepartamento.SelectedValue.ToString());
            MessageBox.Show(cmbDepartamento.SelectedValue.ToString());
            MessageBox.Show(Convert.ToString(tipoAcceso.id));
            usuario.nombre = txtNombre.Text;
            usuario.apellido = txtApellido.Text;
            usuario.clave = txtClave.Text;
            usuario.departamento = tipoAcceso.id;
            try
            {
                usuario.Agregar();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ResetFormulario();
            }
            
        }
    }
}
