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
    public partial class ModuloAreas : Form
    {
        private int id = 0;
        public ModuloAreas()
        {
            InitializeComponent();
        }

        private void CargarDGWAreas()
        {
            try
            {
                dgvAreas.DataSource = Clases.Areas.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwAreaEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void ResetFormulario()
        {
            txtNombre.Text = "";
            txtNumero.Text = "";
            CargarDGWAreas();
            dgwAreaEstilo(dgvAreas);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtNumero.Enabled = true;
            this.id = 0;
            txtNombre.Focus();
        }

        private void ModuloAreas_Load(object sender, EventArgs e)
        {
            ResetFormulario();
            CargarDGWAreas();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarAreas
                    (
                        txtNombre.Text,
                        Convert.ToInt16(txtNumero.Text)
                    );
                CargarDGWAreas();
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al area" + txtNombre.Text, "Eliminar area", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
               
                try
                {
                    Clases.Restaurante.EliminarAreas(this.id);
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar area", "Modificar Area", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.ModificarAreas
                        (
                            Convert.ToInt16(this.id),
                            txtNombre.Text,
                            Convert.ToInt16(txtNumero.Text)
                        );
                    ResetFormulario();

                }
                catch (Exception ex)
                {
                    Clases.Mensaje.Advertencia(ex);
                }
            }
        }

        private void dgvAreas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvAreas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Areas area = new Clases.Areas();
            area.ObtenerAreas(
                Convert.ToInt32(
                    dgvAreas.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvAreas.Select();
            this.id = area.Id;
            txtNombre.Text = area.Nombre;
            txtNumero.Text = Convert.ToString(area.NumeroMesas);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
