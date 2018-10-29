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
            if (txtContraseña.Text.Equals(txtConfirmarContraseña.Text))
            {
                SqlCommand update = new SqlCommand(@"Update Empleados Set Contraseña='" + Contraseña + "', Codigo_Estado='" + 1 + "', Intentos='" + 0 + "' Where Usuario='" + Usuario + "'", Conexion.Obtenerconexion());
                update.ExecuteNonQuery();
                MessageBox.Show("Contraseña cambiada exitosamente.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                InicioSesion inicio = new InicioSesion();
                this.Close();
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
            txtContraseña.MaxLength = 15;
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.MaxLength = 15;
        }
    }
}
