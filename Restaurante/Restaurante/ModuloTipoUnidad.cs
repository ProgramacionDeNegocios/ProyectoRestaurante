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
    public partial class ModuloTipoUnidad : Form
    {
        private int id = 0;
        public ModuloTipoUnidad()
        {
            InitializeComponent();
        }

        private void CargarDGWTipoUnidad()
        {
            try
            {
                dgvTipoUnidad.DataSource = Clases.TipoUnidad.GetDataView();
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

        private void ModuloTipoUnidad_Load(object sender, EventArgs e)
        {
            CargarDGWTipoUnidad();
            ResetFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void dgvTipoUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            CargarDGWTipoUnidad();
            dgwTipoUnidadEstilo(dgvTipoUnidad);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtId.Enabled = true;
            txtDescripcion.Enabled = true;
            this.id = 0;
            txtId.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
