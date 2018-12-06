using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Transporte_Cristina
{
    public partial class AdministracionEmpleados : Form
    {
        public AdministracionEmpleados()
        {
            InitializeComponent();
            comboboxPuestoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxPuestoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
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
            string Usuario = textboxUsuarioAgregar.Text;
            string  Telefono = textboxTelefonoAgregar.Text;
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
                    int Codigo_Puesto = 1;
                    int Cod_Estado = 6;
                    if (textboxTelefonoAgregar.Text == "")
                    {
                        SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Codigo_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
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
                        SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, , Telefono, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Telefono + "','" + Usuario + "', '" + Contraseña + "', '" + Codigo_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
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
                        SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, , Telefono, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Telefono + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Codigo_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                        InicioSesion inicio = new InicioSesion();
                        seguridad.lblUsuario.Text = textboxUsuarioAgregar.Text;
                        this.Hide();
                        inicio.Show();
                    }
                }
                if (comboboxPuestoAgregar.Text == "Cajero")
                {
                    int Codigo_Puesto = 2;
                    int Cod_Estado = 6;
                    if (textboxTelefonoAgregar.Text == "")
                    {
                        SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Codigo_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
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
                        SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Telefono, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Telefono + "','" + Usuario + "', '" + Contraseña + "', '" + Codigo_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
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
                        SqlCommand insert = new SqlCommand("Insert into Empleados(Identidad_Empleado, Nombre_Empleado, Apellido_Empleado, Telefono, Celular, Usuario, Contraseña, Codigo_Puesto, Codigo_Estado, Intentos)Values('" + Identidad_Empleado + "', '" + Nombre_Empleado + "', '" + Apellido_Empleado + "', '" + Telefono + "', '" + Celular + "','" + Usuario + "', '" + Contraseña + "', '" + Codigo_Puesto + "', '" + Cod_Estado + "', '" + Intentos + "')", Conexion.Obtenerconexion());
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textboxIdentidadAgregar.Clear();
            textboxNombreAgregar.Clear();
            textboxApellidoAgregar.Clear();
            textboxTelefonoAgregar.Clear();
            textboxCelularAgregar.Clear();
            textboxUsuarioAgregar.Clear();
            comboboxPuestoAgregar.SelectedIndex = -1;

        }

        private void AdministracionUsuarios_Load(object sender, EventArgs e)
        {
            textboxIdentidadModificar.Enabled = false;
            comboboxPuestoModificar.Enabled = false;
            textboxNombreModificar.Enabled = false;
            textboxApellidoModificar.Enabled = false;
            textboxTelefonoModificar.Enabled = false;
            textboxCelularModificar.Enabled = false;
            labelContraseñaTemporal.Text = GenerarClave(8);
            btnModificar.Enabled = false;
            btnLimpiarModificar.Enabled = false;
            textboxContraseña.Enabled = false;
        }

        private void btnRegresarEliminar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
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
            textboxApellidoModificar.Clear();
            textboxNombreModificar.Clear();
            textboxIdentidadModificar.Clear();
            comboboxPuestoModificar.SelectedIndex = -1;
            textboxTelefonoModificar.Clear();
            textboxCelularModificar.Clear();
            textboxContraseña.Clear();
        }

        private void textboxUsuarioModificar_TextChanged_1(object sender, EventArgs e)
        {
            textboxNombreModificar.MaxLength = 25;
        }

        private void textboxNombreModificar_TextChanged(object sender, EventArgs e)
        {
            textboxNombreModificar.MaxLength = 25;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ModificarEstado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            string Usuario = textboxUsuarioBusqueda.Text;
            string Identidad = "";
            string Nombre = "";
            string Apellido = "";
            int Puesto = 0;
            bool IsExist = false;
            string Telefono = "";
            string Celular = "";
            SqlCommand cmd = new SqlCommand("Select * From Empleados where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
            cmd.Parameters.AddWithValue("@Identidad_Empleado", Identidad);
            cmd.Parameters.AddWithValue("@Nombre_Empleado", Nombre);
            cmd.Parameters.AddWithValue("@Apellido_Empleado", Apellido);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Celular", Celular);
            cmd.Parameters.AddWithValue("@Codigo_Puesto", Puesto);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                if (sdr["Telefono"] != DBNull.Value && sdr["Celular"] != DBNull.Value)
                {
                    Identidad = sdr.GetString(1);
                    Nombre = sdr.GetString(2);
                    Apellido = sdr.GetString(3);
                    Telefono = sdr.GetString(4);
                    Celular = sdr.GetString(5);
                    Usuario = sdr.GetString(6);
                    Puesto = sdr.GetInt32(8);
                    IsExist = true;
                    
                }
                else if(sdr["Telefono"] == DBNull.Value && sdr["Celular"] == DBNull.Value)
                {
                    Identidad = sdr.GetString(1);
                    Nombre = sdr.GetString(2);
                    Apellido = sdr.GetString(3);
                    Usuario = sdr.GetString(6);
                    Puesto = sdr.GetInt32(8);
                    IsExist = true;
                }
                else if (sdr["Telefono"] == DBNull.Value)
                {
                    Identidad = sdr.GetString(1);
                    Nombre = sdr.GetString(2);
                    Apellido = sdr.GetString(3);
                    Celular = sdr.GetString(5);
                    Usuario = sdr.GetString(6);
                    Puesto = sdr.GetInt32(8);
                    IsExist = true;
                }
                else if (sdr["Celular"] == DBNull.Value)
                {
                    Identidad = sdr.GetString(1);
                    Nombre = sdr.GetString(2);
                    Apellido = sdr.GetString(3);
                    Telefono = sdr.GetString(4);
                    Usuario = sdr.GetString(6);
                    Puesto = sdr.GetInt32(8);
                    IsExist = true;
                }                
                
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Usuario.Equals(textboxUsuarioBusqueda.Text))
                {
                    MessageBox.Show("Empleado(a) o Usuario Encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textboxIdentidadModificar.Enabled = true;
                    comboBoxEstado.Enabled = true;
                    comboboxPuestoModificar.Enabled = true;
                    textboxNombreModificar.Enabled = true;
                    btnLimpiarModificar.Enabled = true;
                    btnModificar.Enabled = true;
                    textboxApellidoModificar.Enabled = true;
                    textboxTelefonoModificar.Enabled = true;
                    textboxCelularModificar.Enabled = true;
                    textboxUsuarioBusqueda.Enabled = false;
                    btnBuscar.Enabled = false;
                    textboxContraseña.Enabled = true;
                    textboxIdentidadModificar.Text = Identidad;
                    textboxNombreModificar.Text = Nombre;
                    textboxApellidoModificar.Text = Apellido;
                    textboxTelefonoModificar.Text = Convert.ToString(Telefono);
                    if (Telefono == "" || Telefono == "0")
                    {
                        textboxTelefonoModificar.Text = "Campo vacio";
                    }
                    textboxCelularModificar.Text = Convert.ToString(Celular);
                    if (Celular == "" || Celular == "0")
                    {
                        textboxCelularModificar.Text = "Campo vacio";
                    }
                    if (Puesto == 1)
                    {
                        comboboxPuestoModificar.Text = "Gerente";
                    }
                    else
                    {
                        comboboxPuestoModificar.Text = "Cajero";
                    }
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
            string Usuario = textboxUsuarioBusqueda.Text;
            string Identidad_Empleado = textboxIdentidadModificar.Text;
            string Nombre_Empleado = textboxNombreModificar.Text;
            string Apellido_Empleado = textboxApellidoModificar.Text;
            string Telefono = textboxTelefonoModificar.Text;
            string Celular = textboxCelularModificar.Text;
            string Contraseña = Encriptacion.Encrypt(textboxContraseña.Text);
            bool IsExist = false;
            SqlCommand sql = new SqlCommand("Select * from Empleados Where Usuario = '" + Usuario + "'", Conexion.Obtenerconexion());
            sql.Parameters.AddWithValue("@Telefono", Telefono);
            sql.Parameters.AddWithValue("@Celular", Celular);
            SqlDataReader sdr = sql.ExecuteReader();
            if (sdr.Read())
            {
                if (sdr["Telefono"] != DBNull.Value && sdr["Celular"] != DBNull.Value)
                {
                    Identidad_Empleado = sdr.GetString(1);
                    Telefono = sdr.GetString(4);
                    Celular = sdr.GetString(5);
                    IsExist = true;

                }
                else if (sdr["Telefono"] == DBNull.Value && sdr["Celular"] == DBNull.Value)
                {
                    Identidad_Empleado = sdr.GetString(1);
                    IsExist = true;
                }
                else if (sdr["Telefono"] == DBNull.Value)
                {
                    Identidad_Empleado = sdr.GetString(1);
                    Celular = sdr.GetString(5);
                    Usuario = sdr.GetString(6);
                    IsExist = true;
                }
                else if (sdr["Celular"] == DBNull.Value)
                {
                    Identidad_Empleado = sdr.GetString(1);
                    Telefono = sdr.GetString(4);
                    IsExist = true;
                }
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (comboboxPuestoModificar.Text == "Gerente")
                {
                    if (textboxTelefonoModificar.Text == "Campo vacio" && textboxCelularModificar.Text == "Campo vacio" || textboxTelefonoModificar.Text == "" && textboxCelularModificar.Text == "")
                    {
                        Telefono = "0";
                        Celular = "0";
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Telefono = '" + Telefono + "' Celular = '" + Celular + "',  Codigo_Puesto = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxTelefonoModificar.Text != "Campo vacio")
                    {
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Telefono = '"+ Telefono +"',  Codigo_Puesto = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if(textboxCelularModificar.Text != "Campo vacio")
                    {
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Celular = '" + Celular + "',  Codigo_Puesto = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxTelefonoModificar.Text == "Campo vacio" || textboxTelefonoModificar.Text == "")
                    {
                        Telefono = "0";
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "',  Telefono = '" + Telefono + "', Codigo_Puesto = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxCelularModificar.Text == "Campo vacio" || textboxCelularModificar.Text == "")
                    {
                        Celular = "0";
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Celular = '" + Celular + "', Codigo_Puesto = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Telefono = textboxTelefonoModificar.Text;
                        Celular = textboxCelularModificar.Text;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Telefono = '" + Telefono + "', Celular = '" + Celular + "', Codigo_Puesto = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }                    
                    if (textboxContraseña.Text == "") 
                    {
                        
                    }
                    else
                    {
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Contraseña = '" + Contraseña + "' Where Usuario = '" + Usuario + "' ", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                    }

                }
                else if (comboboxPuestoModificar.Text == "Cajero")
                {
                    if (textboxTelefonoModificar.Text == "Campo vacio" && textboxCelularModificar.Text == "Campo vacio" || textboxTelefonoModificar.Text == "" && textboxCelularModificar.Text == "")
                    {
                        Telefono = "0";
                        Celular = "0";
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Telefono = '" + Telefono + "', Celular = '" + Celular + "',  Codigo_Puesto = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxTelefonoModificar.Text != "Campo vacio")
                    {
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Telefono = '" + Telefono + "',  Codigo_Puesto = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxCelularModificar.Text != "Campo vacio")
                    {
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Celular = '" + Celular + "',  Codigo_Puesto = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxTelefonoModificar.Text == "Campo vacio" || textboxTelefonoModificar.Text == "")
                    {
                        Telefono = "0";
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "',  Telefono = '" + Telefono + "', Codigo_Puesto = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (textboxCelularModificar.Text == "Campo vacio" || textboxCelularModificar.Text == "")
                    {
                        Celular = "0";
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Celular = '" + Celular + "', Codigo_Puesto = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Telefono = textboxTelefonoModificar.Text;
                        Celular = textboxCelularModificar.Text;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Identidad_Empleado = '" + Identidad_Empleado + "', Nombre_Empleado = '" + Nombre_Empleado + "', Apellido_Empleado = '" + Apellido_Empleado + "', Telefono = '" + Telefono + "', Celular = '" + Celular + "', Codigo_Puesto = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (textboxContraseña.Text == "")
                    {

                    }
                    else
                    {
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Contraseña = '" + Contraseña + "' Where Usuario = '" + Usuario + "' ", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                    }
                }
            }

        }

        private void ModificarEstado()
        {
            string Usuario = textboxUsuarioEstado.Text;
            int Codigo_Usuario = 0;
            int Estado = 0;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("select * from Empleados where Usuario ='" + textboxUsuarioEstado.Text + "'", Conexion.Obtenerconexion());
            cmd.Parameters.AddWithValue("@Codigo_Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Codigo_Estado", Estado);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Codigo_Usuario = sdr.GetInt32(0);
                Usuario = sdr.GetString(6);
                Estado = sdr.GetInt32(9);
                IsExist = true;
            }
            if (IsExist)
            {
                if (Usuario.Equals(textboxUsuarioEstado.Text))
                {
                    if (comboBoxEstado.Text == "")
                    {
                        MessageBox.Show("Seleccione un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (comboBoxEstado.Text == "Inactivo")
                    {
                        SqlCommand command = new SqlCommand("Update Empleados Set Codigo_Estado = '" + 2 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Estado de Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        SqlCommand command = new SqlCommand("Update Empleados Set Codigo_Estado = '" + 1 + "' Where Usuario ='" + Usuario + "'", Conexion.Obtenerconexion());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Estado de Usuario modificado con exito.", "Modificacion con Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
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
            textboxUsuarioEstado.MaxLength = 25;
        }

        private void textboxNombreAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Registrar();
            }
            Validar.Sololetras(e);
        }

        private void textboxIdentidadAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Registrar();
            }
            Validar.Solonumeros(e);
        }

        private void textboxApellidoAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Registrar();
            }
            Validar.Sololetras(e);
        }

        private void textboxAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }


        private void textboxTelefonoAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxTelefonoAgregar.MaxLength = 8;
        }

        private void textboxTelefonoAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Registrar();
            }
            Validar.Solonumeros(e);
        }

        private void textboxCelularAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxCelularAgregar.MaxLength = 8;
        }

        private void textboxCelularAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Registrar();
            }
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

        private void _KeyPress(object sender, KeyPressEventArgs e)
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

        private void textboxIdentidadAgregar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxIdentidadAgregar.Text))
            {
                e.Cancel = true;
                textboxIdentidadAgregar.Focus();
                errorProviderAdmin.SetError(textboxIdentidadAgregar, "Ingrese su identidad.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxIdentidadAgregar, null);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            textboxIdentidadAgregar.Clear();
            textboxApellidoAgregar.Clear();
            textboxNombreAgregar.Clear();
            textboxUsuarioAgregar.Clear();
            textboxTelefonoAgregar.Clear();
            textboxCelularAgregar.Clear();
            comboboxPuestoAgregar.SelectedIndex = -1;
        }

        private void textboxNombreAgregar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxNombreAgregar.Text))
            {
                e.Cancel = true;
                textboxNombreAgregar.Focus();
                errorProviderAdmin.SetError(textboxNombreAgregar, "Ingrese su nombre.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxNombreAgregar, null);
            }
        }

        private void textboxApellidoAgregar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxApellidoAgregar.Text))
            {
                e.Cancel = true;
                textboxApellidoAgregar.Focus();
                errorProviderAdmin.SetError(textboxApellidoAgregar, "Ingrese su apellido.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxApellidoAgregar, null);
            }
        }

        private void comboboxPuestoAgregar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboboxPuestoAgregar.Text))
            {
                e.Cancel = true;
                comboboxPuestoAgregar.Focus();
                errorProviderAdmin.SetError(comboboxPuestoAgregar, "Ingrese su puesto.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(comboboxPuestoAgregar, null);
            }
        }

        private void textboxUsuarioAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Registrar();
            }
            Validar.TextoConNumeros(e);
        }

        private void AdministracionEmpleados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegresarModificar_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void textboxNombreAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxNombreAgregar.MaxLength = 25;
        }

        private void textboxApellidoAgregar_TextChanged(object sender, EventArgs e)
        {
            textboxApellidoModificar.MaxLength = 25;
        }


        private void textboxUsuarioAgregar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxUsuarioAgregar.Text))
            {
                e.Cancel = true;
                textboxUsuarioAgregar.Focus();
                errorProviderAdmin.SetError(textboxUsuarioAgregar, "Ingrese su usuario.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxUsuarioAgregar, null);
            }
        }

        private void textboxUsuarioBusqueda_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxUsuarioBusqueda.Text))
            {
                e.Cancel = true;
                textboxUsuarioBusqueda.Focus();
                errorProviderAdmin.SetError(textboxUsuarioBusqueda, "Ingrese su usuario.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxUsuarioBusqueda, null);
            }
        }

        private void textboxIdentidadModificar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxIdentidadModificar.Text))
            {
                e.Cancel = true;
                textboxIdentidadModificar.Focus();
                errorProviderAdmin.SetError(textboxIdentidadModificar, "Ingrese su Identidad.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxIdentidadModificar, null);
            }
        }

        private void textboxNombreModificar_TextChanged_1(object sender, EventArgs e)
        {
            textboxNombreModificar.MaxLength = 25;
        }

        private void textboxNombreModificar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxNombreModificar.Text))
            {
                e.Cancel = true;
                textboxNombreModificar.Focus();
                errorProviderAdmin.SetError(textboxNombreModificar, "Ingrese su nombre.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxNombreModificar, null);
            }
        }

        private void textboxApellidoModificar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textboxApellidoModificar.Text))
            {
                e.Cancel = true;
                textboxApellidoModificar.Focus();
                errorProviderAdmin.SetError(textboxApellidoModificar, "Ingrese su apellido.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxApellidoModificar, null);
            }
        }

        private void textboxUsuarioModificar_TextChanged(object sender, EventArgs e)
        {
            textboxNombreModificar.MaxLength = 25;
        }

        private void textboxUsuarioModificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }

        private void comboboxPuestoModificar_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboboxPuestoModificar.Text))
            {
                e.Cancel = true;
                comboboxPuestoModificar.Focus();
                errorProviderAdmin.SetError(comboboxPuestoModificar, "Seleccione un puesto.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(comboboxPuestoModificar, null);
            }
        }

        private void textboxContraseña_TextChanged(object sender, EventArgs e)
        {
            textboxContraseña.MaxLength = 25;
        }

        private void textboxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.TextoConNumeros(e);
        }

        private void textboxUsuarioBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Buscar();
            }
            Validar.TextoConNumeros(e);
        }

        private void textboxTelefonoModificar_MouseClick(object sender, MouseEventArgs e)
        {
            textboxTelefonoModificar.Clear();
        }

        private void textboxCelularModificar_MouseClick(object sender, MouseEventArgs e)
        {
            textboxCelularModificar.Clear();
        }

        private void textboxCelularModificar_Enter(object sender, EventArgs e)
        {
            textboxCelularModificar.Clear();
        }

        private void textboxTelefonoModificar_Enter(object sender, EventArgs e)
        {
            textboxTelefonoModificar.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textboxUsuarioEstado_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textboxUsuarioEstado.Text))
            {
                e.Cancel = true;
                textboxUsuarioEstado.Focus();
                errorProviderAdmin.SetError(textboxUsuarioEstado, "Ingrese el usuario.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(textboxUsuarioEstado, null);
            }
        }

        private void comboBoxEstado_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBoxEstado.Text))
            {
                e.Cancel = true;
                comboBoxEstado.Focus();
                errorProviderAdmin.SetError(comboBoxEstado, "Seleccione un estado.");
            }
            else
            {
                e.Cancel = false;
                errorProviderAdmin.SetError(comboBoxEstado, null);
            }
        }

        private void textboxUsuarioEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ModificarEstado();
            }
            Validar.TextoConNumeros(e);
        }
    }
}
