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
        //Parametros temporales mientras determinamos los accesos en los usuarios
        public int rol;

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
            if (rol==1)
            {
                btnModuloUsuarios.Enabled = true;
            }
            else
            {
                btnModuloUsuarios.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModuloAreas moduloAreas = new ModuloAreas();
            moduloAreas.ShowDialog();
        }
    }
}
