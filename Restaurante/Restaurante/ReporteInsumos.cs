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
    public partial class ReporteInsumos : Form
    {
        public ReporteInsumos()
        {
            InitializeComponent();
        }

        private void ReporteInsumos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Insumos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.Insumos.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
