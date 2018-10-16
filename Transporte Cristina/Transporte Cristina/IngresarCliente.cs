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
    public partial class IngresarCliente : Form
    {
        public string id;
        int contreservado = 0;
        int contvendido = 0;

        Clientes_BD clieBD = new Clientes_BD();

        public IngresarCliente()
        {
            InitializeComponent();
            cmbAccion.DropDownStyle = ComboBoxStyle.DropDownList;

            Clientes_BD clie = new Clientes_BD();
            clie.autoCompletar(txtNumeroIdentificacion);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngresarCliente_Load(object sender, EventArgs e)
        {

            txtRTN.Enabled = false;

        }

        private void chkRTN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRTN.Checked == true)
            {
                txtRTN.Enabled = true;
            }
            else
            {
                txtRTN.Enabled = false;
            }
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void txtNumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {


            if (cmbAccion.Text == "Reservado")
            {
                compartir_datos.color.BackColor = Color.SlateGray;

                compartir_datos.reservado = contreservado++;
            }
            else
                if (cmbAccion.Text == "Vendido")
            {
                compartir_datos.color.BackColor = Color.Red;
                compartir_datos.vendido = contvendido++;
            }



            if (txtNumeroIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de identificaciòn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroIdentificacion.Focus();
            }

            if (txtNombreCompleto.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCompleto.Focus();
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }

        }
        private const Keys k_copy = Keys.Control | Keys.C;
        private const Keys k_paste = Keys.Control | Keys.V;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == k_copy) || (keyData == k_paste))
            {
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clientes clie = new clientes();

            if (clieBD.ClienteRegistrado(txtNumeroIdentificacion.Text) == 0)
            {
                if (txtNumeroIdentificacion.Text == "" || txtNombreCompleto.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    clie.id = txtNumeroIdentificacion.Text;
                    clie.nombre = txtNombreCompleto.Text;
                    clie.telefono = Convert.ToInt32(txtTelefono.Text);

                    int resultado = Clientes_BD.Agregar(clie);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Datos Guardados Corerectamente", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                        MessageBox.Show("No se pudieron Guardar lo datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Imposible registrar, Cliente ya registrado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNumeroIdentificacion.Text = "";
            txtTelefono.Text = "";
            txtNombreCompleto.Text = "";
            txtRTN.Text = "";

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (clieBD.ClienteRegistrado(txtNumeroIdentificacion.Text) > 0)
            {
                clieBD.llenarTexBoxConsulta(txtNumeroIdentificacion.Text, txtNombreCompleto, txtTelefono);
            }
        }
    }
}


