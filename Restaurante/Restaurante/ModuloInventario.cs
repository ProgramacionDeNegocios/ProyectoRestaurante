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
    public partial class ModuloInventario : Form
    {
        private int id = 0;
        public ModuloInventario()
        {
            InitializeComponent();
        }

        private void CargarDGWInventario()
        {
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgwInventarioEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ModuloInventario_Load(object sender, EventArgs e)
        {
            CargarDGWInventario();
            CargarCMBProveedores();
            ResetFormulario();
        }

        private void CargarCMBProveedores()
        {
            DataTable dt = new DataTable();
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = "select * FROM Restaurante.Proveedores";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbProveedor.DisplayMember = "nombre";
            cmbProveedor.ValueMember = "nombre";
            cmbProveedor.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Proveedor proveedor = new Clases.Proveedor();
                proveedor.ObtenerProveedorPorNombre(cmbProveedor.SelectedValue.ToString());

                Clases.Restaurante.AgregarInventario
                    (
                        txtDescripcion.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToDecimal(txtCantidad.Text),
                        cmbTipoProducto.SelectedIndex,
                        proveedor.Id
                    );
                CargarDGWInventario();
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar el Inventario", "Modificar Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Proveedor proveedor = new Clases.Proveedor();
                    proveedor.ObtenerProveedorPorNombre(cmbProveedor.SelectedValue.ToString());

                    Clases.Restaurante.ModificarInventario
                        ( 
                        this.id,
                        txtDescripcion.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        Convert.ToDecimal(txtPrecioVenta.Text),
                        Convert.ToDecimal(txtCantidad.Text),
                        cmbTipoProducto.SelectedIndex,
                        proveedor.Id
                        );
                    ResetFormulario();
                }
                catch (Exception ex)
                {
                    Clases.Mensaje.Advertencia(ex);
                }

            }
        }       

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Inventario inventario = new Clases.Inventario();
            inventario.ObtenerInsumo(
                Convert.ToInt32(
                    dgvInventario.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvInventario.Select();
            this.id = inventario.IdInventario;

            txtId.Text = inventario.IdInventario.ToString();
            txtDescripcion.Text = inventario.Descripcion.ToString();
            txtCosto.Text = inventario.Costo.ToString();
            txtPrecioVenta.Text = inventario.PrecioVenta.ToString();
            txtCantidad.Text = inventario.Cantidad.ToString();
            cmbTipoProducto.SelectedIndex = inventario.IdTipoProducto;
            cmbProveedor.SelectedIndex = inventario.IdProveedor - 1;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            cmbTipoProducto.SelectedIndex = -1;
            cmbTipoProducto.SelectedValue = "";
            cmbProveedor.SelectedValue = "";
            CargarDGWInventario();
            dgwInventarioEstilo(dgvInventario);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtDescripcion.Enabled = true;
            txtCosto.Enabled = true;
            txtCantidad.Enabled = true;
            txtPrecioVenta.Enabled = true;
            this.id = 0;
            txtDescripcion.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de Eliminar el Inventario", "Eliminar Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarInventario(this.id);
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
    }
}
