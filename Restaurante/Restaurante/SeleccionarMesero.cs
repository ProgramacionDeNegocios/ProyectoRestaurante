using System;
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
    public partial class SeleccionarMesero : Form
    {
        public int valorMesa;
        public string valorArea;
        public SeleccionarMesero()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeleccionarMesero_Load(object sender, EventArgs e)
        {
            lb3.Text = Convert.ToString( valorMesa);
            lb4.Text = valorArea;
        }
        public void estado(Color color)
        {
            ControlMesas.valorColor = color;
            //controlMesas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estado(Color.Gold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estado(Color.Red);
        }
    }
}
