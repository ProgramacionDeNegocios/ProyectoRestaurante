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
    public partial class MenuPrincipal : Form
    {
        public int rol = 1;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnModuloUsuarios_Click(object sender, EventArgs e)
        {
            ModuloUsuarios moduloUsuario = new ModuloUsuarios();
            moduloUsuario.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModuloProveedores_Click(object sender, EventArgs e)
        {
            ModuloProveedores moduloProveedores = new ModuloProveedores();
            moduloProveedores.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModuloMeseros moduloMeseros = new ModuloMeseros();
            moduloMeseros.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            ModuloInsumos moduloInsumos = new ModuloInsumos();
            moduloInsumos.ShowDialog();

        }

        private void btnTipoUnidad_Click(object sender, EventArgs e)
        {
            ModuloTipoUnidad moduloTipoUnidad = new ModuloTipoUnidad();
            moduloTipoUnidad.ShowDialog();
        }

        private void Pedidos_Click(object sender, EventArgs e)
        {
            ModuloInventario moduloInventario = new ModuloInventario();
            moduloInventario.ShowDialog();
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            ModuloTipoProducto moduloTipoProducto = new ModuloTipoProducto();
            moduloTipoProducto.ShowDialog();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ModuloCategoriaProducto moduloCategoriaProducto = new ModuloCategoriaProducto();
            moduloCategoriaProducto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)

        {
            
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ControlMesas controlMesas = new ControlMesas();
            controlMesas.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReporteInsumos reporteInsumos = new ReporteInsumos();
            reporteInsumos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReportePreFactura preFractura = new ReportePreFactura();
            preFractura.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModuloAreas areas = new ModuloAreas();
            areas.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ModuloFacturas factura = new ModuloFacturas();
            factura.ShowDialog();
        }
    }
}
