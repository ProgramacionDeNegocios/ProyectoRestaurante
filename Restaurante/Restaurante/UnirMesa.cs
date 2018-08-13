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
    public partial class UnirMesa : Form
    {
        string nombre;
        public UnirMesa()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void ParametrosPedido( string j)
        {
            
            SeleccionarMesero.valorArea = this.nombre;
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();

            seleccionarMesero.valorMesa = listBox1;
            seleccionarMesero.ShowDialog();
            //estadoMesas(n, mesas.SelectedIndex);


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mesa = Convert.ToInt32(comboBox1.Text);
            listBox1.Text = Convert.ToString(mesa);
        }
    }
}
