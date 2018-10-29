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
    public partial class AdministracionEmpleados : Form
    {
        public AdministracionEmpleados()
        {
            InitializeComponent();
            comboboxPuestoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxEstadoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxPuestoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }
                          
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }
        
        private string GenerarClave(int longitud)
        {
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < longitud--)
            {
                res.Append(caracteres[rnd.Next(caracteres.Length)]);
            }
            return res.ToString();
            
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }
        private void Registrar()
        {

            string Identidad_Empleado = textboxIdentidadAgregar.Text;
            string Nombre_Empleado = textboxNombreAgregar.Text;
            string Apellido_Empleado = textboxApellidoAgregar.Text;
            string Edad= textboxEdadAgregar.Text;
            string Usuario = textboxUsuarioAgregar.Text;
            string Telefono = textboxTelefonoAgregar.Text;
            string Celular = textboxCelularAgregar.Text;
            string Contraseña = Encriptacion.Encrypt(labelContraseñaTemporal.Text);
            int Intentos = 0;
            bool IsExist = false;

            SqlCommand sql = new SqlCommand("select * from Empleados Where Usuario = '" + Usuario + "' or Identidad_Empleado='" + Identidad_Empleado + "'", Conexion.Obtenerconexion());
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Identidad_Empleado = reader.GetString(1);
                Usuario = reader.GetString(7);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist == true)
            {
                if (Identidad_Empleado.Equals(textboxIdentidadAgregar.Text) || Usuario.Equals(textboxUsuarioAgregar.Text))
                {
                    MessageBox.Show("Identidad de Empleado o Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                if (comboboxPuestoAgregar.Text == "Gerente")
                {
                    int Cod_Puesto = 1;
                    int Cod_Estado = 6;
                    if(textboxTelefonoAgregar.Text == "" && textboxCelularAgregar.Text=="")
                    {
                        MessageBox.Show("Debe de ingresar al menos su Telefono o Celular.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (textboxTelefonoAgregar.Text == "")
                        {
                            SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Edad, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Edad + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Cod_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                            InicioSesion inicio = new InicioSesion();
                            seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                            this.Hide();
                            inicio.Show();
                        }
                        else if (textboxCelularAgregar.Text == "")
                        {
                            SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Edad, Telefono, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Edad + "', '" + Telefono + "','" + Usuario + "', '" + Contraseña + "', '" + Cod_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                            InicioSesion inicio = new InicioSesion();
                            seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                            this.Hide();
                            inicio.Show();
                        }
                        else
                        {
                            SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Edad, Telefono, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Edad + "', '" + Telefono + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Cod_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                            InicioSesion inicio = new InicioSesion();
                            seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                            this.Hide();
                            inicio.Show();
                        }
                    }
                    

                }
                if (comboboxPuestoAgregar.Text == "Cajero")
                {
                    int Cod_Puesto = 2;
                    int Cod_Estado = 6;
                    if (textboxTelefonoAgregar.Text == "" && textboxCelularAgregar.Text == "")
                    {
                        MessageBox.Show("Debe de ingresar al menos su Telefono o Celular.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (textboxTelefonoAgregar.Text == "")
                        {
                            SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Edad, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Edad + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Cod_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                            InicioSesion inicio = new InicioSesion();
                            seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                            this.Hide();
                            inicio.Show();
                        }
                        else if (textboxCelularAgregar.Text == "")
                        {
                            SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Edad, Telefono, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Edad + "', '" + Telefono + "','" + Usuario + "', '" + Contraseña + "', '" + Cod_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                            InicioSesion inicio = new InicioSesion();
                            seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                            this.Hide();
                            inicio.Show();
                        }
                        else
                        {
                            SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Edad, Telefono, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Edad + "', '" + Telefono + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Cod_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                            insert.ExecuteNonQuery();
                            MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                            InicioSesion inicio = new InicioSesion();
                            seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                            this.Hide();
                            inicio.Show();
                        }


                    }
                }
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textboxIdentidadAgregar.Clear();
            textboxNombreAgregar.Clear();
            textboxApellidoAgregar.Clear();
            textboxEdadAgregar.Clear();
            textboxTelefonoAgregar.Clear();
            textboxCelularAgregar.Clear();
            textboxUsuarioAgregar.Clear();
            comboboxPuestoAgregar.SelectedIndex = -1;

        }

        private void AdministracionUsuarios_Load(object sender, EventArgs e)
        {
            textboxIdentidadModificar.Enabled = false;
            textboxEdadModificar.Enabled = false;
            comboboxEstadoModificar.Enabled = false;
            comboboxPuestoModificar.Enabled = false;
            textboxNombreModificar.Enabled = false;
            textboxUsuarioModificar.Enabled = false;
            textboxApellidoModificar.Enabled = false;
            textboxTelefonoModificar.Enabled = false;
            textboxCelularModificar.Enabled = false;
            labelContraseñaTemporal.Text = GenerarClave(8);
            btnModificar.Enabled = false;
            btnLimpiarModificar.Enabled = false;


        }

        private void btnRegresarEliminar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void btnRegresarModificar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void btnLimpiarModificar_Click(object sender, EventArgs e)
        {
            textboxEdadModificar.Clear();
            textboxNombreModificar.Clear();
            textboxUsuarioModificar.Clear();
            textboxUsuarioBusqueda.Clear();
            textboxIdentidadModificar.Clear();
            comboboxEstadoModificar.SelectedIndex = -1;
            comboboxPuestoModificar.SelectedIndex = -1;

        }

        private void textboxUsuarioModificar_TextChanged_1(object sender, EventArgs e)
        {
            textboxNombreModificar.MaxLength = 25;
        }

        private void textboxNombreModificar_TextChanged(object sender, EventArgs e)
        {
            textboxNombreModificar.MaxLength = 25;
        }

        private void textboxEdadModificar_TextChanged(object sender, EventArgs e)
        {
            textboxEdadModificar.MaxLength = 2;
        }

               
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            string Usuario = textboxUsuarioBusqueda.Text;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("Select Usuario From Empleados where Usuario ='" + textboxUsuarioBusqueda.Text + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Usuario= sdr.GetString(0);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Usuario.Equals(textboxUsuarioBusqueda.Text))
                {
                    MessageBox.Show("Empleado(a) o Usuario Encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textboxIdentidadModificar.Enabled = true;
                    textboxEdadModificar.Enabled = true;
                    comboboxEstadoModificar.Enabled = true;
                    comboboxPuestoModificar.Enabled = true;
                    textboxNombreModificar.Enabled = true;
                    textboxUsuarioModificar.Enabled = true;
                    btnLimpiarModificar.Enabled = true;
                    btnModificar.Enabled = true;
                    textboxApellidoModificar.Enabled = true;
                    textboxTelefonoModificar.Enabled = true;
                    textboxCelularModificar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Empleado(a) o Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empleado(a) o Usuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        private void Modificar()
        {
            string Identidad_Empleado = textboxIdentidadAgregar.Text;
            string Nombre_Empleado = textboxNombreAgregar.Text;
            string Apellido_Empleado = textboxApellidoAgregar.Text;
            string Edad = textboxEdadAgregar.Text;
            string Usuario = textboxUsuarioAgregar.Text;
            string Telefono = textboxTelefonoAgregar.Text;
            string Celular = textboxCelularAgregar.Text;
            bool IsExist = false;
            SqlCommand sql = new SqlCommand("Select * from Empleados Where Usuario = '" + Usuario + "' or Identidad_Empleado='" + Identidad_Empleado + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = sql.ExecuteReader();
            if (sdr.Read())
            {
                Identidad_Empleado = sdr.GetString(0);
                Usuario = sdr.GetString(3);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Identidad_Empleado.Equals(textboxIdentidadModificar.Text))
                {
                    MessageBox.Show("Identidad de Empleado ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Usuario.Equals(textboxUsuarioModificar.Text))
                {
                    MessageBox.Show("Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textboxIdentidadModificar.Text == "" && textboxNombreModificar.Text == "" && textboxEdadModificar.Text == "" && textboxUsuarioModificar.Text == "" && comboboxPuestoModificar.Text == "" && comboboxEstadoModificar.Text == "")
                {
                    MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (comboboxPuestoModificar.Text == "Gerente" && comboboxEstadoModificar.Text == "Activo")
                    {
                        int Cod_Puesto = 1;
                        int Cod_Estado = 1;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado='" + Identidad_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad='" + Edad + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "' Where Identidad_Empleado='" + textboxUsuarioBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (comboboxPuestoModificar.Text == "Gerente" && comboboxEstadoModificar.Text == "Inactivo")
                    {
                        int Cod_Puesto = 1;
                        int Cod_Estado = 2;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado='" + Identidad_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad='" + Edad + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "'Where Identidad_Empleado='" + textboxUsuarioBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Usuario no pudo ser actualizado", "Actualizacion No Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (comboboxPuestoModificar.Text == "Cajero" && comboboxEstadoModificar.Text == "Activo")
                    {
                        int Cod_Puesto = 2;
                        int Cod_Estado = 1;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado='" + Identidad_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad='" + Edad + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "' Where Identidad_Empleado='" + textboxUsuarioBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (comboboxPuestoModificar.Text == "Cajero" && comboboxEstadoModificar.Text == "Inactivo")
                    {
                        int Cod_Puesto = 2;
                        int Cod_Estado = 2;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado='" + Identidad_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad='" + Edad + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "'Where Identidad_Empleado='" + textboxUsuarioBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Usuario no pudo ser actualizado", "Actualizacion No Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void textboxUsuarioModificar_TextChanged_2(object sender, EventArgs e)
        {
            textboxUsuarioModificar.MaxLength = 25;
        }


        private void Eliminar()
        {
            string Usuario = textboxUsuarioEliminar.Text;
            int Codigo_Usuario = 0;
            int reset = 0;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("select * from Empleados where Usuario ='" + textboxUsuarioEliminar.Text + "'", Conexion.Obtenerconexion());
            cmd.Parameters.AddWithValue("@Codigo_Usuario", Usuario);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Codigo_Usuario = sdr.GetInt32(0);
                Usuario = sdr.GetString(7);
                IsExist = true;
            }
            reset = Codigo_Usuario - 1;
            if (IsExist)
            {
                if (Usuario.Equals(textboxUsuarioEliminar.Text))
                {
                    SqlCommand command = new SqlCommand("Delete From Empleados Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                    SqlCommand sqlCommand = new SqlCommand("Delete From Respuestas Where Codigo_Usuario = '" + Codigo_Usuario + "'", Conexion.Obtenerconexion());
                    command.ExecuteNonQuery();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Cuenta eliminada con exito", "Eliminacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario escrito incorrectamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }

        private void textboxIdentidadAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxIdentidadAgregar.MaxLength = 13;
        }

        private void textboxUsuarioEliminar_TextChanged(object sender, EventArgs e)
        {
            textboxUsuarioEliminar.MaxLength = 25;
        }

        private void textboxNombreAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textboxIdentidadAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxApellidoAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textboxEdadAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxEdadAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxEdadAgregar.MaxLength = 2;
        }

        private void textboxTelefonoAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxTelefonoAgregar.MaxLength = 8;
        }

        private void textboxTelefonoAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxCelularAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxCelularAgregar.MaxLength = 8;
        }

        private void textboxCelularAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxUsuarioAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxUsuarioAgregar.MaxLength = 25;
        }

        private void textboxUsuarioBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            textboxUsuarioBusqueda.MaxLength = 25;
        }

        private void textboxIdentidadModificar_TextChanged(object sender, EventArgs e)
        {
            textboxIdentidadAgregar.MaxLength = 13;
        }

        private void textboxIdentidadModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxNombreModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textboxApellidoModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void textboxApellidoModificar_TextChanged(object sender, EventArgs e)
        {
            textboxApellidoModificar.MaxLength = 25;
        }

        private void textboxEdadModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxTelefonoModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void textboxTelefonoModificar_TextChanged(object sender, EventArgs e)
        {
            textboxTelefonoModificar.MaxLength = 8;
        }

        private void textboxCelularModificar_TextChanged(object sender, EventArgs e)
        {
            textboxCelularModificar.MaxLength = 8;
        }

        private void textboxCelularModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
    }
}
