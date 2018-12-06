using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transporte_Cristina
{
    public partial class Listado_Buses : Form
    {
        public Listado_Buses()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Agregar_Buses agregarBus = new Agregar_Buses();
            this.Close();
            agregarBus.Show();
        }
        private void Listado_Buses_Load(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();

            dataGridView1.DataSource = conexion.tabla("Select *From Buses");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_Buses_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
