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
        public string Usuario = "";
        public string Codigo_Usuario = "";
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
        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                e.Cancel = true;
                txtUsuario.Focus();
                errorProviderRecuperacion.SetError(txtUsuario, "Ingrese su contraseña.");
            }
            else
            {
                e.Cancel = false;
                errorProviderRecuperacion.SetError(txtUsuario, null);
            }
        }

        private void cmbPregunta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbPregunta.Text))
            {
                e.Cancel = true;
                cmbPregunta.Focus();
                errorProviderRecuperacion.SetError(cmbPregunta, "Ingrese su pregunta.");
            }
            else
            {
                e.Cancel = false;
                errorProviderRecuperacion.SetError(cmbPregunta, null);
            }
        }

        private void txtRespuesta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRespuesta.Text))
            {
                e.Cancel = true;
                txtRespuesta.Focus();
                errorProviderRecuperacion.SetError(txtRespuesta, "Ingrese su respuesta.");
            }
            else
            {
                e.Cancel = false;
                errorProviderRecuperacion.SetError(txtRespuesta, null);
            }
        }
        private void Validacion()
        {
            Usuario = txtUsuario.Text;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("Select * From Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Usuario = sdr.GetString(6);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Usuario.Equals(txtUsuario.Text))
                {
                    SqlCommand sql = new SqlCommand("select Codigo_Usuario from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                    sql.Parameters.AddWithValue("@Usuario", Codigo_Usuario);
                    SqlDataReader reader = sql.ExecuteReader();
                    if (reader.Read())
                    {
                        Codigo_Usuario = reader["Codigo_Usuario"].ToString();
                    }
                    Conexion.Obtenerconexion().Close();
                    cmbPregunta.Enabled = true;
                    txtRespuesta.Enabled = true;
                    btnRecuperar.Enabled = true;
                    txtUsuario.Enabled = false;
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
        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            Validacion();
        }

        private void RecuperacionContraseña_Load(object sender, EventArgs e)
        {
            cmbPregunta.Enabled = false;
            txtRespuesta.Enabled = false;
            btnRecuperar.Enabled = false;

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
            this.Hide();
            inicio.Show();
        }
        private void RecuperacionPreguntas()
        {
            string Cod_Usuario = "";
            Cod_Usuario = Codigo_Usuario;
            string Respuesta = "";
            
            if (cmbPregunta.Text == "¿Cual es tu color favorito?")
            {
                int Cod_Pregunta = 1;
                SqlCommand select = new SqlCommand("Select Respuesta from Respuestas where Codigo_Usuario ='" + Codigo_Usuario + "'and Cod_Pregunta = '" +Cod_Pregunta +"'", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Codigo_Usuario", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (txtRespuesta.Text == "")
                {
                    MessageBox.Show("Ingrese su respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Focus();
                }
                else if (Encriptacion.Decrypt(Respuesta).Equals(txtRespuesta.Text))
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
            if (cmbPregunta.Text == "¿Cual es el nombre del primer libro que leiste?")
            {
                int Cod_Pregunta = 2;
                SqlCommand select = new SqlCommand("Select Respuesta from Respuestas where Codigo_Usuario ='" + Codigo_Usuario + "'and Cod_Pregunta = '" + Cod_Pregunta + "'", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Codigo_Usuario", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if(txtRespuesta.Text == "")
                {
                    MessageBox.Show("Ingrese su respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Focus();
                }
                else if (Encriptacion.Decrypt(Respuesta).Equals(txtRespuesta.Text))
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
                int Cod_Pregunta = 3;
                SqlCommand select = new SqlCommand("Select Respuesta from Respuestas where Codigo_Usuario ='" + Codigo_Usuario + "'and Cod_Pregunta = '" + Cod_Pregunta + "'", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Codigo_Usuario", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (txtRespuesta.Text == "")
                {
                    MessageBox.Show("Ingrese su respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Focus();
                }
                else if (Encriptacion.Decrypt(Respuesta).Equals(txtRespuesta.Text))
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
                int Cod_Pregunta = 4;
                SqlCommand select = new SqlCommand("Select Respuesta from Respuestas where Codigo_Usuario ='" + Codigo_Usuario + "'and Cod_Pregunta = '" + Cod_Pregunta + "'", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Codigo_Usuario", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (txtRespuesta.Text == "")
                {
                    MessageBox.Show("Ingrese su respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Focus();
                }
                else if (Encriptacion.Decrypt(Respuesta).Equals(txtRespuesta.Text))
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
                int Cod_Pregunta = 5;
                SqlCommand select = new SqlCommand("Select Respuesta from Respuestas where Codigo_Usuario ='" + Codigo_Usuario + "'and Cod_Pregunta = '" + Cod_Pregunta + "'", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Codigo_Usuario", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (txtRespuesta.Text == "")
                {
                    MessageBox.Show("Ingrese su respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Focus();
                }
                else if (Encriptacion.Decrypt(Respuesta).Equals(txtRespuesta.Text))
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
                int Cod_Pregunta = 6;
                SqlCommand select = new SqlCommand("Select Respuesta from Respuestas where Codigo_Usuario ='" + Codigo_Usuario + "'and Cod_Pregunta = '" + Cod_Pregunta + "'", Conexion.Obtenerconexion());
                select.Parameters.AddWithValue("@Codigo_Usuario", Respuesta);
                SqlDataReader sdr = select.ExecuteReader();
                if (sdr.Read())
                {
                    Respuesta = sdr["Respuesta"].ToString();

                }
                if (txtRespuesta.Text == "")
                {
                    MessageBox.Show("Ingrese su respuesta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRespuesta.Focus();
                }
                else if (Encriptacion.Decrypt(Respuesta).Equals(txtRespuesta.Text))
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
        private void button1_Click(object sender, EventArgs e)
        {
            RecuperacionPreguntas();
        }
        
        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {
            txtRespuesta.MaxLength = 25;
        }
               

        private void RecuperacionContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }

        private void txtRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.MaxLength = 25;
        }
    }

}

