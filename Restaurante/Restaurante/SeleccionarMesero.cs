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
        public static string valorArea;
        public SeleccionarMesero()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCMBMeseros()
        {
            DataTable dt = new DataTable();
            Clases.Conexion conexion = new Clases.Conexion();
            string sql = "select * FROM Restaurante.Meseros";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbMesero.DisplayMember = "nombre";
            cmbMesero.ValueMember = "nombre";
            cmbMesero.DataSource = dt;
        }
        private void SeleccionarMesero_Load(object sender, EventArgs e)
        {
            lb3.Text = Convert.ToString( valorMesa);
            lb4.Text = valorArea;
            CargarCMBMeseros();
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLicores_Click(object sender, EventArgs e)
        {

        }

        private void lb3_Click(object sender, EventArgs e)
        {

        }
    }
}
