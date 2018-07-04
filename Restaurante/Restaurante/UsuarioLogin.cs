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
    public partial class UsuarioLogin : Form
    {
        Clases.Conexion conexion = new Clases.Conexion();
        Clases.Usuario usuario = new Clases.Usuario();
        public UsuarioLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidacionCampos())
            {
                errorProvider1.Clear();
                usuario.ObtenerUsuario(txtUsuario.Text.Trim(), txtClave.Text.Trim());
                if (usuario.usuario != txtUsuario.Text.Trim() || usuario.clave != txtClave.Text.Trim())
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtUsuario, "El usuario '" + txtUsuario.Text.ToUpper() + "' no existe ó la clave ingresada es incorrecta");
                    LimpiarFormulario();
                }
                else
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    this.Hide();
                    menuPrincipal.ShowDialog();
                }
                

            }
            
        }

        private Boolean ValidacionCampos()
        {
            if (txtUsuario.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtUsuario, "Ingrese el nombre del usuario");
                return false;
            }
            else if (txtClave.Text == string.Empty)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtClave, "Ingrese la clave del usuario");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void UsuarioLogin_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                errorProvider1.Clear();
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(txtUsuario, "Solo se permiten letras en el Usuario");
                errorProvider1.GetError(txtUsuario);
            }
        }
    }
}
