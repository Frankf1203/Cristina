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
    public partial class RecuperacionContraseña : Form
    {

        public RecuperacionContraseña()
        {
            InitializeComponent();
            cmbPregunta.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            this.Hide();
            inicio.Show();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("Select * From Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Usuario = sdr.GetString(3);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Usuario.Equals(txtUsuario.Text))
                {

                    cmbPregunta.Enabled = true;
                    txtRespuesta.Enabled = true;
                    btnRecupar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void RecuperacionContraseña_Load(object sender, EventArgs e)
        {
            cmbPregunta.Enabled = false;
            txtRespuesta.Enabled = false;
            btnRecupar.Enabled = false;

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

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            this.Close();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Respuesta = "";
            string Id_Empleado = "";

            SqlCommand sql = new SqlCommand("Select Id_Empleado from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            sql.Parameters.AddWithValue("@Usuario", Id_Empleado);
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Id_Empleado = reader["Id_Empleado"].ToString();
            }
            Conexion.Obtenerconexion().Close();
            if (Usuario.Equals(txtUsuario.Text))
            {

                if (cmbPregunta.Text == "¿Cual es tu color favorito?")
                {
                    SqlCommand select = new SqlCommand("Select * from Respuestas where Id_Empleado ='" + Id_Empleado + "' and Cod_Pregunta='" + 1 + "' ", Conexion.Obtenerconexion());
                    select.Parameters.AddWithValue("@Id_Empleado", Respuesta);
                    SqlDataReader sdr = select.ExecuteReader();
                    if (sdr.Read())
                    {
                        Respuesta = sdr["Respuesta"].ToString();

                    }
                    if (Respuesta.Equals(txtRespuesta.Text))
                    {
                        MessageBox.Show("Respuesta correcta.", "Recuperacion Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        NuevaContraseña nueva = new NuevaContraseña();
                        nueva.User = Usuario;
                        this.Hide();
                        nueva.Show();
                    }
                    else
                    {
                        MessageBox.Show("Respuesta incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (cmbPregunta.Text == "¿Cual es el nombre del primer libro que leiste?")
            {
                SqlCommand select = new SqlCommand("Select * from Respuestas where Id_Empleado ='" + Id_Empleado + "' and Cod_Pregunta='" + 2 + "' ", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Id_Empleado", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (Respuesta.Equals(txtRespuesta.Text))
                {
                    MessageBox.Show("Respuesta correcta.", "Recuperacion Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaContraseña nueva = new NuevaContraseña();
                    nueva.User = Usuario;
                    this.Hide();
                    nueva.Show();
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbPregunta.Text == "¿En que año terminaste la secundaria?")
            {

                SqlCommand select = new SqlCommand("Select * from Respuestas where Id_Empleado ='" + Id_Empleado + "' and Cod_Pregunta='" + 3 + "' ", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Id_Empleado", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (Respuesta.Equals(txtRespuesta.Text))
                {
                    MessageBox.Show("Respuesta correcta.", "Recuperacion Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaContraseña nueva = new NuevaContraseña();
                    nueva.User = Usuario;
                    this.Hide();
                    nueva.Show();
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbPregunta.Text == "¿Cual es el nombre de tu mascota?")
            {

                SqlCommand select = new SqlCommand("Select * from Respuestas where Id_Empleado ='" + Id_Empleado + "' and Cod_Pregunta='" + 4 + "' ", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Id_Empleado", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (Respuesta.Equals(txtRespuesta.Text))
                {
                    MessageBox.Show("Respuesta correcta.", "Recuperacion Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaContraseña nueva = new NuevaContraseña();
                    nueva.User = Usuario;
                    this.Hide();
                    nueva.Show();
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbPregunta.Text == "¿Cual es tu pelicula favorita?")
            {
                SqlCommand select = new SqlCommand("Select * from Respuestas where Id_Empleado ='" + Id_Empleado + "' and Cod_Pregunta='" + 5 + "' ", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Id_Empleado", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();
                }
                if (Respuesta.Equals(txtRespuesta.Text))
                {
                    MessageBox.Show("Respuesta correcta.", "Recuperacion Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaContraseña nueva = new NuevaContraseña();
                    nueva.User = Usuario;
                    this.Hide();
                    nueva.Show();
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (cmbPregunta.Text == "¿Cual es tu restaurante preferido?")
            {
                SqlCommand select = new SqlCommand("Select * from Respuestas where Id_Empleado ='" + Id_Empleado + "' and Cod_Pregunta='" + 6 + "' ", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Id_Empleado", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (Respuesta.Equals(txtRespuesta.Text))
                {
                    MessageBox.Show("Respuesta correcta.", "Recuperacion Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevaContraseña nueva = new NuevaContraseña();
                    nueva.User = Usuario;
                    this.Hide();
                    nueva.Show();
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }



        }

        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            txtRespuesta.MaxLength = 25;
        }
    }

}

