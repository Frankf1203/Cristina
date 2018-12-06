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
            timerfecha.Enabled = true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }


        private void Factura()
        {
            if (radioButtonNo.Checked == true)
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Selecione un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDestinatario.Focus();
                }
            }

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
             if (cmbOrigen.Text == "")
            {
                MessageBox.Show("Error: Seleccione el Origen", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            if (cmbDestino.Text == "")
            {
                MessageBox.Show("Error: Seleccione el Destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else

             if (cmbOrigen.Text == cmbDestino.Text)
            {
                MessageBox.Show("Error: Seleccione Origen y Destino Distintos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
             if (cmbTipoPaquete.Text == "")
            {
                MessageBox.Show("Error: Seleccione el tipo de paquete", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
             if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Error: Ingrese la descripcion del paquete", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
             if (textBox2.Text == "")
            {
                MessageBox.Show("Error: Seleccione un bus", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Conexion.Obtenerconexion();

                string Desc_Encomienda = txtDescripcion.Text;
                string Fecha_Emicion = lblFechaHora.Text;
                string Precio = txtPrecio.Text;
                string Destinatario = txtDestinatario.Text;
                string Cod_Factura_Envio = lblcodfactura.Text;
                int Cod_Tipo = 0;
                int Cod_ciudad = 0;

                if (cmbOrigen.Text == "Tegucigalpa")
                {
                    Cod_ciudad = 1;
                }
                else
                if (cmbOrigen.Text == "San Pedro Sula")
                {
                    Cod_ciudad = 2;
                }
                else
                if (cmbOrigen.Text == "La Ceiba")
                {
                    Cod_ciudad = 3;
                }

                if (cmbTipoPaquete.Text == "Caja")
                {
                    Cod_Tipo = 1;
                }
                else if (cmbTipoPaquete.Text == "Sobre")
                {
                    Cod_Tipo = 2;
                }
                else
                {
                    Cod_Tipo = 3;
                }


                int Codigo_usuario = 4;

                string Id_Cliente = textBox1.Text;
                int Cod_Estado = 1;
                string Placa = textBox2.Text;

                if (radioButtonNo.Checked == true)
                {

                    /* SqlCommand command = new SqlCommand(@"Update Factura_Encomienda Set  Codigo_Factura_Envio ='" + Cod + "' where Codigo_Factura_Envio = '" + Cod_Factura_Envio + "'", Conexion.Obtenerconexion());
                     command.ExecuteNonQuery();*/

                    SqlCommand insert = new SqlCommand("Insert into Encomiendas( Descripcion_Encomienda, Codigo_Tipo_Encomienda, Codigo_Ciudad, Codigo_Estado )Values('" + Desc_Encomienda + "','" + Cod_Tipo + "','" + Cod_ciudad + "','" + Cod_Estado + "')", Conexion.Obtenerconexion());
                    insert.ExecuteNonQuery();
                    SqlCommand insertar = new SqlCommand("Insert into Factura_Encomienda( Numero_Guia, Fecha_Emision, Codigo_Usuario, Identidad_Cliente, Destinatario, Precio, Placa_Bus )Values('" + lblNumeroGuia.Text + "', '" + Fecha_Emicion + "', '" + Codigo_usuario + "', '" + Id_Cliente + "','" + Destinatario + "','" + Precio + "','" + Placa + "')", Conexion.Obtenerconexion());
                    insertar.ExecuteNonQuery();
                    MessageBox.Show("Encomienda Registrada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    if (radioButtonSi.Checked == true)
                {
                    string id = textBoxIdentidadFac.Text;
                    string nombre = textBoxNombreFac.Text;
                    string apellido = textBoxApellidoFac.Text;
                    string celular = textBoxCelularFac.Text;
                    string rtn = textBoxRTNFac.Text;

                    /*SqlCommand command = new SqlCommand(@"Update Factura_Encomienda Set  Codigo_Factura_Envio ='" + Cod + "' where Codigo_Factura_Envio = '" + Cod_Factura_Envio + "'", Conexion.Obtenerconexion());
                    command.ExecuteNonQuery();*/

                    if (textBoxIdentidadFac.Text == "")
                    {
                        MessageBox.Show("Error: Ingrese la identidad del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                         if (textBoxNombreFac.Text == "")
                    {
                        MessageBox.Show("Error: Ingrese el nombre del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                         if (textBoxApellidoFac.Text == "")
                    {
                        MessageBox.Show("Error: Ingrese el apellido del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                         if (textBoxCelularFac.Text == "")
                    {
                        MessageBox.Show("Error: Ingrese el celular del cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {
                        SqlCommand insert1 = new SqlCommand("Insert into Clientes(Identidad_Cliente, Nombre_Cliente, Apellido_Cliente, Celular, RTN )Values('" + id + "', '" + nombre + "','" + apellido + "','" + celular + "','" + rtn + "')", Conexion.Obtenerconexion());
                        insert1.ExecuteNonQuery();
                        SqlCommand insert = new SqlCommand("Insert into Encomiendas( Descripcion_Encomienda, Codigo_Tipo_Encomienda, Codigo_Ciudad, Codigo_Estado )Values('" + Desc_Encomienda + "','" + Cod_Tipo + "','" + Cod_ciudad + "','" + Cod_Estado + "')", Conexion.Obtenerconexion());
                        insert.ExecuteNonQuery();
                        SqlCommand insertar = new SqlCommand("Insert into Factura_Encomienda( Numero_Guia, Fecha_Emision, Codigo_Usuario, Identidad_Cliente, Destinatario, Precio, Placa_Bus )Values( '" + lblNumeroGuia.Text + "', '" + Fecha_Emicion + "', '" + Codigo_usuario + "', '" + id + "','" + Destinatario + "','" + Precio + "','" + Placa + "')", Conexion.Obtenerconexion());
                        insertar.ExecuteNonQuery();
                        MessageBox.Show("Encomienda Registrada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void dataGridViewClientesFac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridViewClientesFac.Rows[e.RowIndex].Cells["Identidad_Cliente"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Placa_Bus"].Value.ToString();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            string Numero_Guia = "";
            txtDescripcion.Clear();
            txtDestinatario.Clear();
            textBoxIdentidadFac.Clear();
            textBoxNombreFac.Clear();
            textBoxApellidoFac.Clear();
            txtPrecio.Clear();
            textBoxCelularFac.Clear();
            textBoxRTNFac.Clear();
            cmbDestino.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            cmbTipoPaquete.SelectedIndex = -1;
            SqlCommand guia = new SqlCommand("Select Numero_Guia From Encomiendas order by Numero_Guia desc", Conexion.Obtenerconexion());
            guia.Parameters.AddWithValue("@Numero_Guia", Numero_Guia);
            SqlDataReader dataReader = guia.ExecuteReader();
            if (dataReader.Read())
            {
                Numero_Guia = dataReader["Numero_Guia"].ToString();
            }
            lblNumeroGuia.Text = Numero_Guia;
            Clipboard.Clear();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            Factura();
        }

        private void RegistroEncomienda_Load_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBoxRTNFac.Enabled = false;
            Conexion conexion = new Conexion();

            SqlConnection cn = new SqlConnection("Data Source=FRANK\\SQLEXPRESS;Initial Catalog=EncomiendaCristinaBD;Integrated Security=True");
            SqlCommand cm = new SqlCommand("select Nombre_Ciudad from Ciudades;", cn);

            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read() == true)
            {
                cmbOrigen.Items.Add(dr[0]);
                cmbDestino.Items.Add(dr[0]);

            }
            cn.Close();
            SqlCommand ce = new SqlCommand("select Descripcion_Tipo_Encomienda from Tipo_Encomienda;", cn);
            cn.Open();
            SqlDataReader de = ce.ExecuteReader();
            while (de.Read() == true)
            {
                cmbTipoPaquete.Items.Add(de[0]);

            }

            dataGridViewClientesFac.DataSource = conexion.tabla("Select *From Clientes");
            dataGridView1.DataSource = conexion.tabla("Select * From Buses");


            radioButtonNo.Checked = true;
           
            string Cod_Factura_Envio = "";
            string Numero_Guia = "";
            int cont = 0;
            bool IsExist = false;
            SqlCommand sql = new SqlCommand("select Codigo_Factura_Envio from Factura_Encomienda Order by Codigo_Factura_Envio desc", Conexion.Obtenerconexion());
            sql.Parameters.AddWithValue("@Cod_Factura_Envio", Cod_Factura_Envio);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Cod_Factura_Envio = reader["Codigo_Factura_Envio"].ToString();
            }
            SqlCommand cmd = new SqlCommand("select Codigo_Factura_Envio from Factura_Encomienda Order by Codigo_Factura_Envio desc ", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {

                //Cod_Factura_Envio = sdr.GetString(0);
                IsExist = true;
            }
            if (IsExist)
            {

                Cod = Convert.ToInt32(Cod_Factura_Envio);
                cont++;
                Cod = Cod + cont;
                cont = 0;
                lblcodfactura.Text = Convert.ToString(Cod);
            }
            SqlCommand guia = new SqlCommand("Select Numero_Guia From Encomiendas order by Numero_Guia desc", Conexion.Obtenerconexion());
            guia.Parameters.AddWithValue("@Numero_Guia", Numero_Guia);
            SqlDataReader dataReader = guia.ExecuteReader();
            if (dataReader.Read())
            {
                Numero_Guia = dataReader["Numero_Guia"].ToString();
            }
            lblNumeroGuia.Text = Numero_Guia;
            Clipboard.Clear();
            lblFechaHora.Text = DateTime.Now.ToString();
        }



        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Placa_Bus"].Value.ToString();
        }

        private void dataGridViewClientesFac_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridViewClientesFac.Rows[e.RowIndex].Cells["Identidad_Cliente"].Value.ToString();
        }

        private void radioButtonNo_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked == true)
            {
                groupBox2.Enabled = false;
                dataGridViewClientesFac.Enabled = true;
                label12.Enabled = true;
                textBox1.Visible = true;
            }
        }

        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSi.Checked == true)
            {
                groupBox2.Enabled = true;
                dataGridViewClientesFac.Enabled = false;
                label12.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBoxRTNFac.Enabled = true;
            }
            else
            {
                textBoxRTNFac.Enabled = false;
            }
        }

        private void txtDestinatario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }       

        private void RegistroEncomienda_Shown(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.MaxLength = 13;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textBoxIdentidadFac_TextChanged(object sender, EventArgs e)
        {
            textBoxIdentidadFac.MaxLength = 13;
        }

        private void textBoxIdentidadFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textBoxNombreFac_TextChanged(object sender, EventArgs e)
        {
            textBoxNombreFac.MaxLength = 25;
        }

        private void textBoxNombreFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textBoxApellidoFac_TextChanged(object sender, EventArgs e)
        {
            textBoxApellidoFac.MaxLength = 25;
        }

        private void textBoxApellidoFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textBoxCelularFac_TextChanged(object sender, EventArgs e)
        {
            textBoxCelularFac.MaxLength = 8;
        }

        private void textBoxCelularFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textBoxRTNFac_TextChanged(object sender, EventArgs e)
        {
            textBoxRTNFac.MaxLength = 14;
        }

        private void textBoxRTNFac_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.MaxLength = 10;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.MaxLength = 100;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }

        private void txtDestinatario_TextChanged(object sender, EventArgs e)
        {
            txtDestinatario.MaxLength = 25;
        }

        private void RegistroEncomienda_Activated(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }
    }
    

}
