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
            try
            {
                Clases.Restaurante.AgregarTipoUnidad
                    (
                        txtDescripcion.Text
                    );
                CargarDGWTipoUnidad();
            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar el tipo de unidad", "Modificar Tipo Unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.ModificarTipoUnidad
                        (
                            Convert.ToInt32(txtId.Text),
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

        private void dgvTipoUnidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.TipoUnidad tipounidad = new Clases.TipoUnidad();
            tipounidad.ObtenerTipoUnidad(
                Convert.ToInt32(
                    dgvTipoUnidad.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvTipoUnidad.Select();
            this.id = tipounidad.Id;

            txtDescripcion.Text = tipounidad.Descripcion;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
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
            DialogResult respuesta = MessageBox.Show("Está seguro de eliminar el tipo de unidad" + txtDescripcion.Text, "Eliminar Tipo Unidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {

                try
                {
                    Clases.Restaurante.EliminarTipoUnidad(this.id);
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
