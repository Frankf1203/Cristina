using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte_Cristina
{
    public partial class Agregar_Buses : Form
    {
        public Agregar_Buses()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text == "" && txtPlaca.Text == "" && txtMarca.Text == "" && txtmodelo.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Registrar();
            }
        }

        private void Registrar()
        {

            string No_Bus = txtnumero.Text;
            string Placa_Bus = txtPlaca.Text;
            string Marca_Bus = txtMarca.Text;
            string Modelo_Bus = txtmodelo.Text;
            int Cantidad_Asientos = Convert.ToInt32(txtasientos.Text);

            SqlCommand insert = new SqlCommand("Insert into Buses(No_Bus, Placa_Bus, Marca_Bus, Modelo_Bus, Cantidad_Asientos)Values('" + No_Bus + "', '" + Placa_Bus + "','" + Marca_Bus + "','" + Modelo_Bus + "', '" + Cantidad_Asientos + "')", Conexion.Obtenerconexion());
            insert.ExecuteNonQuery();
            MessageBox.Show("Bus Registrado Con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtmodelo.Clear();
            txtasientos.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listado_Buses listado = new Listado_Buses();
            this.Close();
            listado.Show();
        }
        private void Agregar_Buses_Load(object sender, EventArgs e)
        {

        }

        private void txtnumero_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtPlaca_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtMarca_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtmodelo_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtasientos_TextChanged(object sender, EventArgs e)
        {
            txtasientos.MaxLength = 2;
        }

        private void txtasientos_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            txtnumero.MaxLength = 2;
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {
            txtPlaca.MaxLength = 6;
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            txtMarca.MaxLength = 50;
        }

        private void txtmodelo_TextChanged(object sender, EventArgs e)
        {
            txtmodelo.MaxLength = 50;
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void txtasientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtnumero.Text == "" && txtPlaca.Text == "" && txtMarca.Text == "" && txtmodelo.Text == "")
            {
                MessageBox.Show("Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Registrar();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Listado_Buses liste = new Listado_Buses();
            liste.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtPlaca.Clear();
            txtMarca.Clear();
            txtmodelo.Clear();
            txtasientos.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }
    }
}
