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
    public partial class ArqueoCaja : Form
    {
        public string User;
        public ArqueoCaja()
        {
            InitializeComponent();
        }

        private void buttonTodoACero_Click(object sender, EventArgs e)
        {
            textboxL500.Text = "0";
            textboxL100.Text = "0";
            textboxL50.Text = "0";
            textboxL20.Text = "0";
            textboxL10.Text = "0";
            textboxL5.Text = "0";
            textboxL2.Text = "0";
            textboxTotalBilletes.Text = "0";
            textboxL1.Text = "0";
        }

        private void textboxSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxL500_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL100_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL50_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL20_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void textboxL1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void buttonTotalBilletes_Click(object sender, EventArgs e)
        {
            int total;
            total = int.Parse(textboxL500.Text) * 500 + int.Parse(textboxL100.Text) * 100 + int.Parse(textboxL50.Text) * 50 + int.Parse(textboxL20.Text) * 20 + int.Parse(textboxL10.Text) * 10 + int.Parse(textboxL5.Text) * 5 + int.Parse(textboxL2.Text) * 2 + int.Parse(textboxTotalBilletes.Text) * 1;
            textboxL1.Text = Convert.ToString(total);
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void ArqueoCaja_Load(object sender, EventArgs e)
        {
            labelUser.Text = User;
        }

        private void buttonCierraCaja_Click(object sender, EventArgs e)
        {

        }
    }
}
