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
    public partial class ModuloFacturas : Form
    {
        public ModuloFacturas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ModuloFacturas_Load(object sender, EventArgs e)
        {
            Encabezado();

        }


        private void Encabezado()
        {

            lblSetFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            int hora = DateTime.Now.Hour;
            if (hora > 0 && hora < 12)
            {
                lblSetJornada.Text = "Matutina";
            }
            else
            {
                if (hora>=12 && hora < 6)
                {
                    lblSetJornada.Text = "Vespertina";
                }
                else
                {
                    lblSetJornada.Text = "Nocturna";
                }
            }

        }
    }
}
