using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class ModuloProveedores : Form
    {
        private int id = 0;
        public ModuloProveedores()
        {
            InitializeComponent();
        }
        private void CargarDGWProveedor()
        {
            try
            {
                dgvProveedores.DataSource = Clases.Proveedor.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwProveedorEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        private void ModuloProveedores_Load(object sender, EventArgs e)
        {
            CargarDGWProveedor();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarProveedor(
                    txtNombre.Text,
                    txtTelefono.Text,
                    txtDireccion.Text
                    );
                CargarDGWProveedor();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar al proveedor", "Modificar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {

                try
                {
                    Clases.Restaurante.ModificarProveedor(
                   Convert.ToInt32(this.id),
                    txtNombre.Text,
                    txtTelefono.Text,
                    txtDireccion.Text
                        );
                    ResetFormulario();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al Proveedor" + txtNombre.Text, "Modificar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                
                try
                {
                    Clases.Restaurante.EliminarProveedor(this.id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    ResetFormulario();
                }
            }
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Proveedor proveedor = new Clases.Proveedor();
            proveedor.ObtenerProveedor(
                Convert.ToInt32(
                    dgvProveedores.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvProveedores.Select();
            this.id = proveedor.Id;
            txtNombre.Text = proveedor.Nombre;
            txtTelefono.Text = proveedor.Telefono;
            txtDireccion.Text = proveedor.Direccion;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }
        private void ResetFormulario()
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            CargarDGWProveedor();
            dgwProveedorEstilo(dgvProveedores);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            this.id = 0;
            txtNombre.Focus();
        }
            private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }
    }
}
