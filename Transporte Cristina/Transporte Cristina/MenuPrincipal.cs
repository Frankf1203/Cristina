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
            Application.Exit();
        }

        private void btnFacturacionBoletos_Click(object sender, EventArgs e)
        {
            /*FacturacionBoleteria boletos = new FacturacionBoleteria();*/
            this.Close();
            //boletos.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            btnArqueoCaja.Enabled = false;
            btnControlRutas.Enabled = false;
            string Cod_Puesto="";
            string Usuario = lblUsuario.Text;
            SqlCommand sql = new SqlCommand("select Cod_Puesto from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            sql.Parameters.AddWithValue("@Usuario", Cod_Puesto);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Cod_Puesto = reader["Cod_Puesto"].ToString();
            }
            if(Cod_Puesto=="2")
            {
                btnAdminUsuarios.Enabled = false;
                btnAgregarBus.Enabled = false;
                btnArqueoCaja.Enabled = false;
                btnControlRutas.Enabled = false;
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

        }
    }
}
