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
    public partial class InicioSesion : Form
    {


        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperacionContraseña recuperacion = new RecuperacionContraseña();
            this.Hide();
            recuperacion.Show();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string Codigo_Usuario = "";
            string ID = "";
            string Usuario = txtUsuario.Text;
            string Password = "";
            string Codigo_Estado = "";
            bool IsExist = false;
            int cont = 0;

            SqlCommand cmd = new SqlCommand("select * from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Usuario = sdr.GetString(7);
                Password = sdr.GetString(8);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Usuario.Equals(txtUsuario.Text))
                {
                    SqlCommand sql = new SqlCommand("select Codigo_Estado from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                    sql.Parameters.AddWithValue("@Usuario", Codigo_Estado);
                    SqlDataReader reader = sql.ExecuteReader();
                    if (reader.Read())
                    {
                        Codigo_Estado = reader["Codigo_Estado"].ToString();
                        
                    }
                    Conexion.Obtenerconexion().Close();
                    
                    if (Encriptacion.Decrypt(Password).Equals(txtContraseña.Text))
                    {
                        if (Codigo_Estado == "6")
                        {
                            bool IfExist = false;
                            SqlCommand cd = new SqlCommand("Select Codigo_Usuario From Empleados Where Codigo_Estado = '" + 6 + "'", Conexion.Obtenerconexion());
                            cd.Parameters.AddWithValue("@Codigo_Estado", Codigo_Usuario);
                            SqlDataReader sq = cd.ExecuteReader();
                            if(sq.Read())
                            {
                                Codigo_Usuario = sq["Codigo_Usuario"].ToString();
                            }
                            ID = Codigo_Usuario;
                            
                            SqlCommand command = new SqlCommand("Select * From Respuestas Where Codigo_Usuario = '" + ID + "'", Conexion.Obtenerconexion());
                            SqlDataReader dataReader = command.ExecuteReader();
                            if(dataReader.Read())
                            {
                                Codigo_Usuario = dataReader.GetString(0);
                                IfExist = true;
                            }
                            if(IfExist)
                            {
                                MessageBox.Show("Su cuenta es nueva. Debe establecer las Preguntas de Seguridad y una nueva contraseña", "Primer Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                NuevaContraseña nueva = new NuevaContraseña();
                                nueva.User = Usuario;
                                this.Hide();
                                nueva.Show();
                            }
                            else
                            {
                                MessageBox.Show("Su cuenta es nueva. Debe establecer las Preguntas de Seguridad y una nueva contraseña", "Primer Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                                seguridad.lblUsuario.Text = Usuario;
                                this.Hide();
                                seguridad.Show();

                            }
                        }
                        else if (Codigo_Estado == "5")
                        {
                            MessageBox.Show("Su Usuario se encuentra bloqueado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            RecuperacionContraseña recuperacion = new RecuperacionContraseña();
                            this.Hide();
                            recuperacion.Show();
                        }
                        else if (Codigo_Estado == "2")
                        {
                            MessageBox.Show("Su Usuario esta inactivo. Contacte al Administrador.");
                        }
                        else if (Codigo_Estado == "1")
                        {
                            MenuPrincipal menu = new MenuPrincipal();
                            menu.lblUsuario.Text = Usuario;
                            this.Hide();
                            menu.Show();
                        }

                    }
                    else
                    {
                        int Intentos = 0;
                        MessageBox.Show("¡Contraseña incorrecta! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SqlCommand command = new SqlCommand("select * from Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        SqlDataReader rd = command.ExecuteReader();
                        if (rd.Read())
                        {
                            Intentos = rd.GetInt32(11);
                            IsExist = true;
                        }

                        cont++;
                        Intentos = Intentos + cont;
                        cont = 0;

                        if (Intentos > 2)
                        {
                            SqlCommand update = new SqlCommand(@"Update Empleados Set  Intentos='" + Intentos + "', Codigo_Estado='" + 5 + "' Where Usuario='" + Usuario + "'", Conexion.Obtenerconexion());
                            update.ExecuteNonQuery();
                        }
                        else
                        {
                            SqlCommand update = new SqlCommand(@"Update Empleados Set  Intentos='" + Intentos + "'Where Usuario='" + Usuario + "'", Conexion.Obtenerconexion());
                            update.ExecuteNonQuery();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("¡Usuario incorrecto! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario no existente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

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

        private void txtUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
