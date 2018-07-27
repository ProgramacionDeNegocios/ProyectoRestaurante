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
    public partial class ModuloAreas : Form
    {
        public ModuloAreas()
        {
            InitializeComponent();
        }

        private void CargarDGWMeseros()
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

        private void dgwMeseroEstilo(DataGridView dgw)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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
            txtIdentidad.Text = "";
            txtApellido.Text = "";
            CargarDGWMeseros();
            dgwMeseroEstilo(dgvAreas);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtIdentidad.Enabled = true;
            txtApellido.Enabled = true;
            //this.id = 0;
            txtIdentidad.Focus();
        }

        private void ModuloAreas_Load(object sender, EventArgs e)
        {
            CargarDGWMeseros();
        }
    }
}
