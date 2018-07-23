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
    public partial class ModuloMeseros : Form
    {
        public ModuloMeseros()
        {
            InitializeComponent();
        }


        private void CargarDGWMeseros()
        {
            try
            {
                dgvMeseros.DataSource = Clases.Mesero.GetDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwMeseroEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        private void ModuloMeseros_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Mesero mesero = new Clases.Mesero(
                    txtNombre.Text,
                    txtId.Text
                    );
                mesero.Agregar();
                ResetFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar al Mesero", "Modificar Mesero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {

                try
                {
                    Clases.Mesero mesero = new Clases.Mesero(
                        Convert.ToInt32(txtApellido.Text),
                        txtNombre.Text,
                        txtId.Text
                        );

                    mesero.Modificar();
                    ResetFormulario();
                   // dgvMeseros.DataSource = Clases.Mesero.GetDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al Mesero" + txtNombre.Text, "Modificar Mesero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                Clases.Mesero usuario = new Clases.Mesero(
                    Convert.ToInt32(txtApellido.Text)
                    );
                try
                {
                    usuario.Eliminar();
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

        private void dgvMeseros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Mesero Mesero = new Clases.Mesero();
            Mesero.ObtenerMesero(
                Convert.ToInt32(
                    dgvMeseros.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvMeseros.Select();
            txtId.Text = Convert.ToString(Mesero.Id);
            txtNombre.Text = Mesero.Nombre;
            txtApellido.Text = Mesero.Apellido;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void ResetFormulario()
        {
            //this.usuario = null;
            
            txtNombre.Text = "";
            txtId.Text = "";
            txtApellido.Text = "";
            CargarDGWMeseros();
            dgwMeseroEstilo(dgvMeseros);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtId.Enabled = true;
            txtApellido.Enabled = true;

            txtApellido.Focus();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {

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
    }
}
