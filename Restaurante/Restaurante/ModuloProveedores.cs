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
        public ModuloProveedores()
        {
            InitializeComponent();
        }

        private void ModuloProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = Clases.Proveedor.GetDataView();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Proveedor proveedor = new Clases.Proveedor(
                    txtNombre.Text,
                    txtTelefono.Text,
                    txtDireccion.Text
                    );
                proveedor.Agregar();
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
                    Clases.Proveedor proveedor = new Clases.Proveedor(
                        Convert.ToInt32(txtId.Text),
                        txtNombre.Text,
                        txtTelefono.Text,
                        txtDireccion.Text
                        );

                    proveedor.Modificar();
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
                Clases.Proveedor usuario = new Clases.Proveedor(
                    Convert.ToInt32(txtId.Text)
                    );
                try
                {
                   usuario.Eliminar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
            txtId.Text = Convert.ToString(proveedor.Id);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
