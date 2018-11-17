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
                Application.Exit();
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            btnControlRutas.Enabled = false;
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
                btnControlRutas.Visible = false;
            }
            
            
        }

        private void btnEncomienda_Click(object sender, EventArgs e)
        {
            RegistroEncomienda encomienda = new RegistroEncomienda();
            this.Close();
            encomienda.Show();
        }

        private void btnAdminUsuarios_Click(object sender, EventArgs e)
        {
            AdministracionEmpleados usuarios = new AdministracionEmpleados();
            this.Close();
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
