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
    public partial class ModuloTipoProducto : Form
    {
        private int id = 0;
        public ModuloTipoProducto()
        {
            InitializeComponent();
        }

        private void CargarDGWTipoProducto()
        {
            try
            {
                dgvTipoProducto.DataSource = Clases.TipoProducto.GetDataView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgwTipoUnidadEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ModuloTipoProducto_Load(object sender, EventArgs e)
        {
            CargarDGWTipoProducto();
            ResetFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarTipoProducto
                    (
                        txtDescripcion.Text
                    );
                CargarDGWTipoProducto();

            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar el tipo de producto", "Modificar Tipo Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.ModificarTipoProducto
                        (
                            this.id,
                            txtDescripcion.Text
                        );
                    ResetFormulario();
                }
                catch (Exception ex)
                {

                    Clases.Mensaje.Advertencia(ex);
                }

            }
        }

        private void dgvTipoProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.TipoProducto tipoproducto = new Clases.TipoProducto();
            tipoproducto.ObtenerTipoProducto(
                Convert.ToInt32(
                    dgvTipoProducto.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvTipoProducto.Select();
            this.id = tipoproducto.Id;

            txtId.Text = tipoproducto.Id.ToString();
            txtDescripcion.Text = tipoproducto.Nombre;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            CargarDGWTipoProducto();
            dgwTipoUnidadEstilo(dgvTipoProducto);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtDescripcion.Enabled = true;
            this.id = 0;
            txtDescripcion.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar el tipo de Producto" + txtDescripcion.Text, "Eliminar Tipo Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarTipoProducto(this.id);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
