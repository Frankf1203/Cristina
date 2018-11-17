using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transporte_Cristina
{
    public partial class NuevaContraseña : Form
    {
        public string User;
        public NuevaContraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = User;
            string Contraseña = Encriptacion.Encrypt(txtContraseña.Text);
            if(txtContraseña.Text =="" || txtConfirmarContraseña.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtContraseña.Text.Equals(txtConfirmarContraseña.Text))
            {
                SqlCommand update = new SqlCommand(@"Update Empleados Set Contraseña='" + Contraseña + "', Codigo_Estado='" + 1 + "', Intentos='" + 0 + "' Where Usuario='" + Usuario + "'", Conexion.Obtenerconexion());
                update.ExecuteNonQuery();
                MessageBox.Show("Contraseña cambiada exitosamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InicioSesion inicio = new InicioSesion();
                this.Hide();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Las contraseña no concuerdan. Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void NuevaContraseña_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = User;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 25;
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 25;
        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                e.Cancel = true;
                txtContraseña.Focus();
                errorProviderNuevaContra.SetError(txtContraseña, "Ingrese su contraseña.");
            }
            else
            {
                e.Cancel = false;
                errorProviderNuevaContra.SetError(txtContraseña, null);
            }
        }
        private void txtConfirmarContraseña_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmarContraseña.Text))
            {
                e.Cancel = true;
                txtConfirmarContraseña.Focus();
                errorProviderNuevaContra.SetError(txtConfirmarContraseña, "Confirme su contraseña");
            }
            else
            {
                e.Cancel = false;
                errorProviderNuevaContra.SetError(txtConfirmarContraseña, null);
            }

        }
        private void NuevaContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }
    }
}
