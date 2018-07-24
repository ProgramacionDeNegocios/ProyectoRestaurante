﻿using System;
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
        private int id = 0;
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
            CargarDGWMeseros();
            ResetFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Restaurante.AgregarMesero
                    (
                        txtIdentidad.Text,
                        txtNombre.Text,
                        txtApellido.Text
                    );
                CargarDGWMeseros();
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
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
                        txtIdentidad.Text,
                        txtNombre.Text,
                        txtApellido.Text
                        );

                    mesero.Modificar();
                    ResetFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void dgvMeseros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Mesero mesero = new Clases.Mesero();
            mesero.ObtenerMesero(
                Convert.ToInt32(
                    dgvMeseros.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvMeseros.Select();
            this.id = mesero.Id;
            txtIdentidad.Text = mesero.Identidad;
            txtNombre.Text = mesero.Nombre;
            txtApellido.Text = mesero.Apellido;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        private void ResetFormulario()
        {
            txtNombre.Text = "";
            txtIdentidad.Text = "";
            txtApellido.Text = "";
            CargarDGWMeseros();
            dgwMeseroEstilo(dgvMeseros);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtIdentidad.Enabled = true;
            txtApellido.Enabled = true;
            this.id = 0;
            txtIdentidad.Focus();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMeseros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar al Mesero" + txtNombre.Text, "Modificar Mesero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                Clases.Mesero mesero = new Clases.Mesero(this.id);
                try
                {
                    mesero.Eliminar();
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
