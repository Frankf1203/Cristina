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
    public partial class FacturacionBoleteria : Form
    {
        public FacturacionBoleteria()
        {
            InitializeComponent();
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHora.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbbus.DropDownStyle = ComboBoxStyle.DropDownList;
            timer1.Enabled = true;

            lblReservados.Text = Convert.ToString(compartir_datos.reservado);
            lblVendidos.Text = Convert.ToString(compartir_datos.vendido);
        }


        private void FacturacionBoleteria_Load(object sender, EventArgs e)
        {
            Random numerofactura = new Random();
            int a = numerofactura.Next(0, 9000);
            lblNumeroFactura.Text = a.ToString();

            Ciudades COrigen = new Ciudades();
            COrigen.llenarItems(cmbOrigen);

            Ciudades CDestino = new Ciudades();
            CDestino.llenarItems(cmbDestino);

            cmbDestino.SelectedIndex = -1;
            cmbOrigen.SelectedIndex = -1;
            cmbbus.SelectedIndex = -1;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento23;

        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoOrigen;

            if (cmbOrigen.Text == "Tegucigalpa")
            {
                codigoOrigen = "1";

                compartir_datos.CodOrigen = codigoOrigen;
            }

            else
                if (cmbOrigen.Text == "San Pedro Sula")
            {
                codigoOrigen = "2";

                compartir_datos.CodOrigen = codigoOrigen;
            }

            else
                if (cmbOrigen.Text == "Ceiba")
            {
                codigoOrigen = "3";

                compartir_datos.CodOrigen = codigoOrigen;
            }

        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoDestino;

            if (cmbDestino.Text == "Tegucigalpa")
            {
                codigoDestino = "1";

                if (compartir_datos.CodOrigen == "2" && codigoDestino == "1")
                {
                    cmbHora.Items.Clear();

                    compartir_datos.codHoraDestino = "3";

                    horarios hora = new horarios();
                    hora.llenarItems(cmbHora);
                }
                else
                    if (compartir_datos.CodOrigen == "3" && codigoDestino == "1")
                {
                    cmbHora.Items.Clear();

                    compartir_datos.codHoraDestino = "6";

                    horarios hora = new horarios();
                    hora.llenarItems(cmbHora);
                }
            }
            else
            if (cmbDestino.Text == "San Pedro Sula")
            {
                codigoDestino = "2";

                if (compartir_datos.CodOrigen == "1" && codigoDestino == "2")
                {
                    cmbHora.Items.Clear();

                    compartir_datos.codHoraDestino = "1";

                    horarios hora = new horarios();
                    hora.llenarItems(cmbHora);
                }
            }

            else
            if (cmbDestino.Text == "La Ceiba")
            {
                codigoDestino = "3";

                if (compartir_datos.CodOrigen == "1" && codigoDestino == "3")
                {
                    cmbHora.Items.Clear();

                    compartir_datos.codHoraDestino = "2";

                    horarios hora = new horarios();
                    hora.llenarItems(cmbHora);
                }
            }


        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHora.Text == "05:15:00")
            {
                compartir_datos.CodHorario = "1";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);

            }
            else
             if (cmbHora.Text == "06:30:00")
            {
                compartir_datos.CodHorario = "2";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
             if (cmbHora.Text == "08:30:00")
            {
                compartir_datos.CodHorario = "3";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);

            }
            else
             if (cmbHora.Text == "09:45:00")
            {
                compartir_datos.CodHorario = "4";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
             if (cmbHora.Text == "10:00:00")
            {
                compartir_datos.CodHorario = "5";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "11:15:00")
            {
                compartir_datos.CodHorario = "6";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "11:30:00")
            {
                compartir_datos.CodHorario = "7";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "12:45:00")
            {
                compartir_datos.CodHorario = "8";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "01:45:00")
            {
                compartir_datos.CodHorario = "9";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "02:00:00")
            {
                compartir_datos.CodHorario = "10";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "03:45:00")
            {
                compartir_datos.CodHorario = "11";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }
            else
            if (cmbHora.Text == "05:30:00")
            {
                compartir_datos.CodHorario = "12";
                cmbbus.Items.Clear();

                Numero_de_Bus numbus = new Numero_de_Bus();
                numbus.NumeroBus(cmbbus);
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
        }

        private void btnAsiento1_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento1;
        }

        private void btnAsiento2_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento2;
        }

        private void btnAsiento3_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento3;
        }

        private void btnAsiento4_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento4;
        }

        private void btnAsiento5_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento5;
        }

        private void btnAsiento6_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento6;
        }

        private void btnAsiento7_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento7;
        }

        private void btnAsiento8_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento8;
        }

        private void btnAsiento9_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento9;
        }

        private void btnAsiento10_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento10;
        }

        private void btnAsiento11_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento11;
        }

        private void btnAsiento12_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento12;
        }

        private void btnAsiento13_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento13;
        }

        private void btnAsiento14_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento14;
        }

        private void btnAsiento15_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento15;
        }

        private void btnAsiento16_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento16;
        }

        private void btnAsiento17_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento17;
        }

        private void btnAsiento18_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento18;
        }

        private void btnAsiento19_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento19;
        }

        private void btnAsiento20_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento20;
        }

        private void btnAsiento21_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento21;
        }

        private void btnAsiento22_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento22;
        }

        private void btnAsiento24_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento24;
        }

        private void btnAsiento25_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento25;
        }

        private void btnAsiento26_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento26;
        }

        private void btnAsiento27_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento27;
        }

        private void btnAsiento28_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento28;
        }

        private void btnAsiento29_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento29;
        }

        private void btnAsiento30_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento30;
        }

        private void btnAsiento31_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento31;
        }

        private void btnAsiento32_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento32;
        }

        private void btnAsiento33_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento33;
        }

        private void btnAsiento34_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento34;
        }

        private void btnAsiento35_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento35;
        }

        private void btnAsiento36_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento36;
        }

        private void btnAsiento37_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento37;
        }

        private void btnAsiento38_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento38;
        }

        private void btnAsiento39_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento39;
        }

        private void btnAsiento40_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento40;
        }

        private void btnAsiento41_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento41;
        }

        private void btnAsiento42_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento42;
        }

        private void btnAsiento43_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento43;
        }

        private void btnAsiento44_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento44;
        }

        private void btnAsiento45_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento45;
        }


        private void btnAsiento46_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento46;
        }

        private void btnAsiento47_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento47;
        }

        private void btnAsiento48_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento48;
        }

        private void btnAsiento49_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento49;
        }

        private void btnAsiento50_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento50;
        }

        private void btnAsiento51_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();

        }

        private void btnAsiento52_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento52;
        }

        private void btnAsiento53_Click(object sender, EventArgs e)
        {
            IngresarCliente cliente = new IngresarCliente();
            cliente.Show();
            compartir_datos.color = btnAsiento53;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string identidad;

            IngresarCliente cliente = new IngresarCliente();

            //cliente.id = identidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void cmbOrigen_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAsiento1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAsiento2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAsiento49_Click_1(object sender, EventArgs e)
        {

        }
    }
}
