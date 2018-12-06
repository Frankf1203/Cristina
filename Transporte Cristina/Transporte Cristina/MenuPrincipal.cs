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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                InicioSesion inicio = new InicioSesion();
                this.Hide();
                inicio.Show();
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            string Codigo_Puesto="";
            string Usuario = lblUsuario.Text;
            SqlCommand sql = new SqlCommand("select Codigo_Puesto from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            sql.Parameters.AddWithValue("@Usuario", Codigo_Puesto);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Codigo_Puesto = reader["Codigo_Puesto"].ToString();
            }
            if(Codigo_Puesto=="2")
            {
                btnAdminUsuarios.Visible = false;
                btnAgregarBus.Visible = false;
                btnArqueoCaja.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
                     
        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            RegistroEncomienda encomienda = new RegistroEncomienda();
            this.Hide();
            encomienda.Show();
        }

        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            AdministracionEmpleados usuarios = new AdministracionEmpleados();
            this.Hide();
            usuarios.Show();
        }

        private void btnAgregarBus_Click(object sender, EventArgs e)
        {
            Agregar_Buses agbus = new Agregar_Buses();
            this.Hide();
            agbus.Show();
        }

        private void btnArqueoCaja_Click(object sender, EventArgs e)
        {
            ArqueoCaja arqueo = new ArqueoCaja();
            arqueo.User = lblUsuario.Text;
            this.Hide();
            arqueo.Show();
        }
    }
}
