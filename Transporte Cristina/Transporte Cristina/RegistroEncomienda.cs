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
    public partial class RegistroEncomienda : Form
    {
        public int Cod;
        public RegistroEncomienda()
        {
            InitializeComponent();
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPaquete.DropDownStyle = ComboBoxStyle.DropDownList;
            timer2.Enabled = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void RegistroEncomienda_Load(object sender, EventArgs e)
        {
            string Cod_Factura_Envio = "";
            int cont = 0;
            bool IsExist = false;
            SqlCommand sql = new SqlCommand("select Cod_Factura_Envio from Factura_Envio Order by Cod_Factura_Envio desc", Conexion.Obtenerconexion());
            sql.Parameters.AddWithValue("@Cod_Factura_Envio", Cod_Factura_Envio);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Cod_Factura_Envio = reader["Cod_Factura_Envio"].ToString();
            }
            SqlCommand cmd = new SqlCommand("select Cod_Factura_Envio from Factura_Envio Order by Cod_Factura_Envio desc ", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                Cod_Factura_Envio = sdr.GetString(0);
                IsExist = true;
            }
            if(IsExist)
            {
                
                Cod = Convert.ToInt32(Cod_Factura_Envio);
                cont++;
                Cod = Cod + cont;
                cont = 0;
                lblcodfactura.Text = Convert.ToString(Cod);
            }

            
            Clipboard.Clear();
            Random numerofactura = new Random();
            int a = numerofactura.Next(0, 9000);
            Random codigofactura = new Random();
            int b = codigofactura.Next(9000, 900000);
            lblNumeroGuia.Text = a.ToString();
            lblcodfactura.Text = Convert.ToString(Cod_Factura_Envio);
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtDestinatario.Clear();
            txtEmisor.Clear();
            txtNumeroIdentificacion.Clear();
            txtPrecio.Clear();
            txtTelefono.Clear();
            cmbDestino.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            cmbTipoPaquete.SelectedIndex = -1;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaEmision_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaHora_Click(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            ListadoEncomienda listado = new ListadoEncomienda();
            listado.Show();
        }

        private void txtNumeroIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtEmisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtDestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {



            if (txtNumeroIdentificacion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de identificaciòn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroIdentificacion.Focus();
            }
            else

             if (txtEmisor.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Emisor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmisor.Focus();
            }
            else

             if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }
            else

             if (txtDestinatario.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Destinatario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDestinatario.Focus();
            }
            else

             if (txtPrecio.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Precio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
            }
            else

             if (cmbOrigen.Text == cmbDestino.Text)
            {
                MessageBox.Show("Error: Seleccione Origen y Destino Distintos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Conexion.Obtenerconexion();

                string No_Guia = lblNumeroGuia.Text;
                string Desc_Encomienda = txtDescripcion.Text;
                string Id_Cliente = txtNumeroIdentificacion.Text;
                string Emisor = txtEmisor.Text;
                string Fecha_Emicion = lblFechaHora.Text;
                string Precio = txtPrecio.Text;
                string Destinatario = txtDestinatario.Text;
                string Cod_Factura_Envio = lblcodfactura.Text;
                int Cod_Tipo = 1;

                //int Cod_Estado = 1;
                SqlCommand command = new SqlCommand(@"Update Factura_Envio Set  Cod_Factura_Envio ='" + Cod + "' where Cod_Factura_Envio = '" + Cod_Factura_Envio + "'", Conexion.Obtenerconexion());
                command.ExecuteNonQuery();
                
                SqlCommand insert = new SqlCommand("Insert into Encomienda(No_Guia, Desc_Encomienda, Cod_Tipo)Values('" + No_Guia + "', '" + Desc_Encomienda + "','" + Cod_Tipo + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();
                SqlCommand insertar = new SqlCommand("Insert into Factura_Envio(Cod_Factura_Envio, No_Guia, Id_Cliente, Emisor,  Precio, Destinatario, Fecha_Emision)Values('" + Cod_Factura_Envio + "','" + No_Guia + "', '" + Id_Cliente + "','" + Emisor + "','" + Precio + "','" + Destinatario + "','" + Fecha_Emicion + "')", Conexion.Obtenerconexion());
                insertar.ExecuteNonQuery();
                MessageBox.Show("Encomienda Registrada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);





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

        private void txtNumeroIdentificacion_TextChanged(object sender, EventArgs e)
        {
            txtNumeroIdentificacion.MaxLength = 13;
        }

        private void txtEmisor_TextChanged(object sender, EventArgs e)
        {
            txtEmisor.MaxLength = 50;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtTelefono.MaxLength = 8;
        }

        private void txtDestinatario_TextChanged(object sender, EventArgs e)
        {
            txtDestinatario.MaxLength = 50;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 50;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 6;
        }

        private void txtNumeroIdentificacion_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtEmisor_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtTelefono_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtDestinatario_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtDescripcion_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtPrecio_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }
    }
}
