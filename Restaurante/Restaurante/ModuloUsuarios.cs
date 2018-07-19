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
        private string usuario;
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
            this.usuario = null;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtClave.Text = "";
            cmbDepartamento.SelectedValue = "";
            dgwUsuarios.DataSource = "";
            CargarDGWUsuarios();
            dgwUsuariosEstilo(dgwUsuarios);

           
            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnPermisos.Enabled = false;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtClave.Enabled = true;
            cmbDepartamento.Enabled = true;

            txtNombre.Focus();
            
        }

        private void CargarCMBDepartamento()
        {
            cmbDepartamento.DisplayMember = "departamento";
            cmbDepartamento.ValueMember = "departamento";
            cmbDepartamento.DataSource = Clases.TipoAcceso.GenerarDataSourceDepartamentos();
        }

        private void CargarDGWUsuarios()
        {
            try
            {
                dgwUsuarios.DataSource = Clases.Usuario.GenerarDataViewUsuarios();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
           
            try
            {
                Clases.TipoAcceso tipoAcceso = new Clases.TipoAcceso();
                tipoAcceso.ObtenerAreaPorDepartamento(cmbDepartamento.SelectedValue.ToString());

                Clases.Usuario usuario = new Clases.Usuario(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtClave.Text,
                    tipoAcceso.id);

                usuario.Agregar();
                ResetFormulario();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Está seguro de modificar al usuario","Modificar Usuario",MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                
                try
                {
                    Clases.TipoAcceso tipoAcceso = new Clases.TipoAcceso();
                    tipoAcceso.ObtenerAreaPorDepartamento(cmbDepartamento.SelectedValue.ToString());

                    Clases.Usuario usuario = new Clases.Usuario(
                        this.usuario,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtClave.Text,
                        tipoAcceso.id);

                    usuario.Modificar();
                    ResetFormulario();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void dgwUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Usuario usuario = new Clases.Usuario();
            usuario.ObtenerUsuario(dgwUsuarios.Rows[e.RowIndex].Cells["Usuario"].Value.ToString());
            dgwUsuarios.Select();
            txtNombre.Text = usuario.nombre;
            txtApellido.Text = usuario.apellido;
            txtClave.Text = usuario.clave;
            this.usuario = usuario.usuario;
            cmbDepartamento.SelectedIndex = usuario.departamento - 1;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnPermisos.Enabled = true;
        }

        private void dgwUsuariosEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al usuario" + this.usuario, "Modificar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                Clases.TipoAcceso tipoAcceso = new Clases.TipoAcceso();
                tipoAcceso.ObtenerAreaPorDepartamento(cmbDepartamento.SelectedValue.ToString());

                Clases.Usuario usuario = new Clases.Usuario(
                    this.usuario
                    );
                try
                {
                    usuario.Eliminar();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.usuario = null;
                    ResetFormulario();
                }
            }
        }
    }
}
