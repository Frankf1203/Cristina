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
    public partial class ListadoEncomienda : Form
    {
        public ListadoEncomienda()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RegistroEncomienda encomienda = new RegistroEncomienda();
            this.Close();
        }

        private void ListadoEncomienda_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            dataGridView1.DataSource = conexion.tabla("Select *From Factura_Envio");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
