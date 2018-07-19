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
    public partial class ModuloProveedores : Form
    {
        public ModuloProveedores()
        {
            InitializeComponent();
        }

        private void ModuloProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = Clases.Proveedor.GetDataView();
        }
    }
}
