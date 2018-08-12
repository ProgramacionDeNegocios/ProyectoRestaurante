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
    public partial class MenuPrincipal : Form
    {
        public int rol = 1;
        public MenuPrincipal()
        {
            InitializeComponent();
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


        private void btnAreas_Click(object sender, EventArgs e)
        {
            ModuloAreas moduloAreas = new ModuloAreas();
            moduloAreas.ShowDialog();
        }
    }
}
