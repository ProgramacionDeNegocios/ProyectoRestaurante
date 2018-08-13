﻿using System;
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
            
            ResetFormulario();
        }

        private void ResetFormulario()
        {
            this.usuario = null;

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtClave.Text = "";
            dgwUsuarios.DataSource = "";
            CargarDGWUsuarios();
            dgwUsuariosEstilo(dgwUsuarios);

            picFoto.Image = Image.FromFile(@"\\DESKTOP-7HRFF62\Fotos2\Ninguna.jpg");

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnAsignarRol.Enabled = false;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtClave.Enabled = true;

            txtNombre.Focus();
            
        }

        private void CargarDGWUsuarios()
        {
            try
            {
                dgwUsuarios.DataSource = Clases.Usuario.GetDataView();
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
                Clases.Restaurante.AgregarUsuario(
                    txtNombre.Text,
                    txtApellido.Text,
                    txtClave.Text);

                
                ResetFormulario();
            }
            catch(SqlException ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Está seguro de modificar al usuario","Modificar Usuario",MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                
                try
                {

                    Clases.Restaurante.ModificarUsuario(
                        this.usuario,
                        txtNombre.Text,
                        txtApellido.Text,
                        txtClave.Text
                        );


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

            
            try
            {
                picFoto.Image = Image.FromFile(@"\\DESKTOP-7HRFF62\Fotos2\" + this.usuario + ".jpg");
            }
            catch
            {
                picFoto.Image = Image.FromFile(@"\\DESKTOP-7HRFF62\Fotos2\Ninguna.jpg");
            }

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnAsignarRol.Enabled = true;
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
                
                try
                {
                    Clases.Restaurante.EliminarUsuario( this.usuario);
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

        private void dgwUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }
    }
}
