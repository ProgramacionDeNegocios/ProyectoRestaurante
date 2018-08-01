﻿using System;
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
    public partial class ModuloInsumos : Form
    {
        private int id = 0;
        public ModuloInsumos()
        {
            InitializeComponent();
        }

        private void CargarDGWInsumos()
        {
            try
            {
                dgvInsumos.DataSource = Clases.Insumos.GetDataView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgwInsumoEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void ModuloInsumos_Load(object sender, EventArgs e)
        {
            CargarDGWInsumos();
            CargarCMBTipoUnidad();
            CargarCMBProveedores();
            ResetFormulario();
        }

        private void CargarCMBTipoUnidad()
        {
            DataTable dt = new DataTable();
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = "select * FROM Restaurante.TipoUnidad";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbUnidad.DisplayMember = "descripcion";
            cmbUnidad.ValueMember = "descripcion";
            cmbUnidad.DataSource = dt;
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
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad();
                tipounidad.ObtenerTipoUnidadPorNombre(cmbUnidad.SelectedValue.ToString());

                Clases.Restaurante.AgregarInsumo
                    (
                        txtNombre.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        tipounidad.Id,                        
                        txtDescripcion.Text,
                        proveedor.Id  
                    );
                CargarDGWInsumos();
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de modificar el Insumo", "Modificar Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {

                try
                {
                    Clases.Proveedor proveedor = new Clases.Proveedor();
                    proveedor.ObtenerProveedorPorNombre(cmbProveedor.SelectedValue.ToString());
                    Clases.TipoUnidad tipounidad = new Clases.TipoUnidad();
                    tipounidad.ObtenerTipoUnidadPorNombre(cmbUnidad.SelectedValue.ToString());

                    Clases.Restaurante.ModificarInsumo
                        (
                        this.id,
                        txtNombre.Text,
                        Convert.ToDecimal(txtCosto.Text),
                        tipounidad.Id,
                        txtDescripcion.Text,
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

        private void dgvInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Insumos insumos = new Clases.Insumos();
            insumos.ObtenerInsumo(
                Convert.ToInt32(
                    dgvInsumos.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvInsumos.Select();
            this.id = insumos.Id;

            txtId.Text = insumos.Id.ToString();
            txtNombre.Text = insumos.Nombre;
            txtCosto.Text = insumos.Costo.ToString();
            cmbUnidad.SelectedIndex = insumos.IdTipoUnidad -1;
            txtDescripcion.Text = insumos.Descripcion;
            cmbProveedor.SelectedIndex = insumos.IdProveedor - 1;

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

        }

        private void ResetFormulario()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            cmbUnidad.SelectedValue = "";
            txtDescripcion.Text = "";
            cmbProveedor.SelectedValue = "";
            CargarDGWInsumos();
            dgwInsumoEstilo(dgvInsumos);

            btnNuevo.Enabled = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            txtNombre.Enabled = true;
            txtCosto.Enabled = true;
            txtDescripcion.Enabled = true;
            this.id = 0;
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ResetFormulario();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Está seguro de Eliminar el Insumo", "Eliminar Insumo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta.ToString() == "Yes")
            {
                try
                {
                    Clases.Restaurante.EliminarInsumo(this.id);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
