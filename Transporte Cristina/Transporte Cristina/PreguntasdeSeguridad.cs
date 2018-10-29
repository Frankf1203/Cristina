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
    public partial class PreguntasdeSeguridad : Form
    {
        public PreguntasdeSeguridad()
        {
            InitializeComponent();
            cmbPregunta1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPregunta2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void PreguntasdeSeguridad_Load(object sender, EventArgs e)
        {

        }

        private void txtRespuesta1_TextChanged(object sender, EventArgs e)
        {
            txtRespuesta1.MaxLength = 25;
        }

        private void txtRespuesta2_TextChanged(object sender, EventArgs e)
        {
            txtRespuesta2.MaxLength = 25;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (cmbPregunta1.Text == "" || cmbPregunta2.Text == "" || cmbPregunta1.Text == cmbPregunta2.Text || txtRespuesta1.Text == txtRespuesta2.Text)
            {
                MessageBox.Show("Preguntas y Respuestas no pueden ser iguales o estar vacias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Respuesta();
                NuevaContraseña nueva = new NuevaContraseña();
                nueva.User = lblUsuario.Text;
                this.Hide();
                nueva.Show();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {


        }
        private void Respuesta()
        {
            string Usuario = lblUsuario.Text;
            string Codigo_Usuario = "";
            int Cod_Pregunta;
            string Respuesta1 = txtRespuesta1.Text;
            string Respuesta2 = txtRespuesta2.Text;
            SqlCommand cmd = new SqlCommand("select Codigo_Usuario from Empleados where Usuario ='" + lblUsuario.Text + "'", Conexion.Obtenerconexion());
            cmd.Parameters.AddWithValue("@Usuario", Convert.ToString(lblUsuario.Text));
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Codigo_Usuario = sdr["Codigo_Usuario"].ToString();
            }
            if (cmbPregunta1.Text == "¿Cual es tu color favorito?")
            {
                Cod_Pregunta = 1;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta1 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            else if (cmbPregunta2.Text == "¿Cual es tu color favorito?")
            {
                Cod_Pregunta = 1;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta2 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            if (cmbPregunta1.Text == "¿Cual es el nombre del primer libro que leiste?")
            {
                Cod_Pregunta = 2;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta1 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            else if (cmbPregunta2.Text == "¿Cual es el nombre del primer libro que leiste?")
            {
                Cod_Pregunta = 2;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta2 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            if (cmbPregunta1.Text == "¿En que año terminaste la secundaria?")
            {
                Cod_Pregunta = 3;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta1 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            else if (cmbPregunta2.Text == "¿En que año terminaste la secundaria?")
            {
                Cod_Pregunta = 3;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta2 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            if (cmbPregunta1.Text == "¿Cual es el nombre de tu mascota?")
            {
                Cod_Pregunta = 4;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta1 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            else if (cmbPregunta2.Text == "¿Cual es el nombre de tu mascota?")
            {
                Cod_Pregunta = 4;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta2 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            if (cmbPregunta1.Text == "¿Cual es tu pelicula favorita?")
            {
                Cod_Pregunta = 5;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta1 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            else if (cmbPregunta2.Text == "¿Cual es tu pelicula favorita?")
            {
                Cod_Pregunta = 5;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta2 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            if (cmbPregunta1.Text == "¿Cual es tu restaurante preferido?")
            {
                Cod_Pregunta = 6;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta1 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }
            else if (cmbPregunta2.Text == "¿Cual es tu restaurante preferido?")
            {
                Cod_Pregunta = 6;
                SqlCommand insert = new SqlCommand("Insert into Respuestas(Codigo_Usuario, Cod_Pregunta, Respuesta)Values('" + Codigo_Usuario + "', '" + Cod_Pregunta + "','" + Respuesta2 + "')", Conexion.Obtenerconexion());
                insert.ExecuteNonQuery();

            }


        }



    }
}
