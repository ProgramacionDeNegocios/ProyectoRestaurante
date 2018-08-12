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
    public partial class ModuloCategoriaProducto : Form
    {
        private int id = 0;
        public ModuloCategoriaProducto()
        {
            InitializeComponent();
        }

        private void CargarDGWCategoriaProducto()
        {
            try
            {
                dgvCategoriaProducto.DataSource = Clases.CategoriaProducto.GetDataView();
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

        private void ModuloCategoriaProducto_Load(object sender, EventArgs e)
        {
            CargarDGWCategoriaProducto();
            ResetFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarCategoriaProducto
                    (
                        txtDescripcion.Text
                    );
                CargarDGWCategoriaProducto();

            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar la categoria de producto", "Modificar Categoria Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.ModificarCategoriaProducto
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

        private void dgvCategoriaProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.CategoriaProducto categoria = new Clases.CategoriaProducto();
            categoria.ObtenerCategoriaProducto(
                Convert.ToInt32(
                     dgvCategoriaProducto.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvCategoriaProducto.Select();
            this.id = categoria.Id;

            txtId.Text = categoria.Id.ToString();
            txtDescripcion.Text = categoria.Descripcion;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            CargarDGWCategoriaProducto();
            dgwTipoUnidadEstilo(dgvCategoriaProducto);

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
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar la categoria de un producto" + txtDescripcion.Text, "Eliminar Categoria Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarCategoriaProducto(this.id);
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
