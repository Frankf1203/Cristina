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
            cmbPuestoAgregar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuestoModificar.DropDownStyle = ComboBoxStyle.DropDownList;
        }



        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            txtEdad.MaxLength = 2;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Close();
            menu.Show();
        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            txtNombreCompleto.MaxLength = 50;

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuarioAgregar.MaxLength = 25;

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

        private void lblContraseñaTemporal_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdentidad.Text == "" || txtNombreCompleto.Text == "" || txtEdad.Text == "" || txtUsuarioAgregar.Text == "" || cmbPuestoAgregar.Text == "")
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Registrar();
            }
        }
        private void Registrar()
        {

            string Id_Empleado = txtIdentidad.Text;
            string Nombre_Empleado = txtNombreCompleto.Text;
            string Edad_Empleado = txtEdad.Text;
            string Usuario = txtUsuarioAgregar.Text;
            string Contraseña = Encriptacion.Encrypt(lblContraseñaTemporal.Text);
            int Intentos = 0;
            bool IsExist = false;

            SqlCommand sql = new SqlCommand("select * from Empleados Where Usuario = '" + Usuario + "' or Id_Empleado='" + Id_Empleado + "'", Conexion.Obtenerconexion());
            SqlDataReader reader = sql.ExecuteReader();
            if (reader.Read())
            {
                Id_Empleado = reader.GetString(0);
                Usuario = reader.GetString(3);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist == true)
            {
                if (Id_Empleado.Equals(txtIdentidad.Text))
                {
                    MessageBox.Show("Identidad de Empleado ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Usuario.Equals(txtUsuarioAgregar.Text))
                {
                    MessageBox.Show("Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (cmbPuestoAgregar.Text == "1 - Gerente")
                {
                    int Cod_Puesto = 1;
                    int Cod_Estado = 6;
                    SqlCommand insert = new SqlCommand("Insert into Empleados(Id_Empleado, Nombre_Empleado, Edad_Empleado, Usuario, Contraseña, Intentos, Cod_Puesto, Cod_Estado)Values('" + Id_Empleado + "', '" + Nombre_Empleado + "','" + Edad_Empleado + "','" + Usuario + "', '" + Contraseña + "', '" + Intentos + "', '" + Cod_Puesto + "', '" + Cod_Estado + "')", Conexion.Obtenerconexion());
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                    InicioSesion inicio = new InicioSesion();
                    seguridad.lblUsuario.Text = txtUsuarioAgregar.Text;
                    this.Hide();
                    inicio.Show();

                }
                if (cmbPuestoAgregar.Text == "2 - Cajero")
                {
                    int Cod_Puesto = 2;
                    int Cod_Estado = 6;
                    SqlCommand insert = new SqlCommand("Insert into Empleados(Id_Empleado, Nombre_Empleado, Edad_Empleado, Usuario, Contraseña, Intentos, Cod_Puesto, Cod_Estado)Values('" + Id_Empleado + "', '" + Nombre_Empleado + "','" + Edad_Empleado + "','" + Usuario + "', '" + Contraseña + "', '" + Intentos + "', '" + Cod_Puesto + "', '" + Cod_Estado + "')", Conexion.Obtenerconexion());
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Usuario Creado con Exito.", "Cuenta Creada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    PreguntasdeSeguridad seguridad = new PreguntasdeSeguridad();
                    InicioSesion inicio = new InicioSesion();
                    seguridad.lblUsuario.Text = txtUsuarioAgregar.Text;
                    this.Hide();
                    inicio.Show();

                }
                if (cmbPuestoAgregar.Text == "3 - Chofer")
                {
                    int Cod_Puesto = 3;
                    int Cod_Estado = 1;
                    SqlCommand insert = new SqlCommand("Insert into Empleados(Id_Empleado, Nombre_Empleado, Edad_Empleado, Cod_Puesto, Cod_Estado)Values('" + Id_Empleado + "', '" + Nombre_Empleado + "','" + Edad_Empleado + "', '" + Cod_Puesto + "', '" + Cod_Estado + "')", Conexion.Obtenerconexion());
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Empleado Ingresado con Exito.", "Empleado Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }

        private void txtUsuarioModificar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreCompleto.Clear();
            txtEdad.Clear();
            txtUsuarioAgregar.Clear();
            txtIdentidad.Clear();
            cmbPuestoAgregar.SelectedIndex = -1;



        }

        private void AdministracionUsuarios_Load(object sender, EventArgs e)
        {
            txtIdentidadModificar.Enabled = false;
            txtEdadModificar.Enabled = false;
            cmbEstadoModificar.Enabled = false;
            cmbPuestoModificar.Enabled = false;
            txtNombreModificar.Enabled = false;
            txtUsuarioModificar.Enabled = false;
            lblContraseñaTemporal.Text = GenerarClave(8);
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
            txtEdadModificar.Clear();
            txtNombreModificar.Clear();
            txtUsuarioModificar.Clear();
            txtIDBusqueda.Clear();
            txtIdentidadModificar.Clear();
            cmbEstadoModificar.SelectedIndex = -1;
            cmbPuestoModificar.SelectedIndex = -1;

        }

        private void txtUsuarioModificar_TextChanged_1(object sender, EventArgs e)
        {
            txtNombreModificar.MaxLength = 25;
        }

        private void txtNombreModificar_TextChanged(object sender, EventArgs e)
        {
            txtNombreModificar.MaxLength = 50;
        }

        private void txtEdadModificar_TextChanged(object sender, EventArgs e)
        {
            txtEdadModificar.MaxLength = 2;
        }

        private void txtUsuarioEliminar_TextChanged(object sender, EventArgs e)
        {
            txtIDEliminar.MaxLength = 13;
            
        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {
            txtIdentidad.MaxLength = 13;
        }


        private void cmbPuestoAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuestoAgregar.Text == "3 - Chofer")
            {
                txtUsuarioAgregar.Enabled = false;
                lblContraseñaTemporal.Enabled = false;
            }
            else
            {
                txtUsuarioAgregar.Enabled = true;
                lblContraseñaTemporal.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void txtIDBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtIDBusqueda.MaxLength = 13;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            string Id_Empleado = txtIDBusqueda.Text;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("Select Id_Empleado From Empleados where Id_Empleado ='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Id_Empleado = sdr.GetString(0);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Id_Empleado.Equals(txtIDBusqueda.Text))
                {
                    MessageBox.Show("Empleado(a) o Usuario Encontrado", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdentidadModificar.Enabled = true;
                    txtEdadModificar.Enabled = true;
                    cmbEstadoModificar.Enabled = true;
                    cmbPuestoModificar.Enabled = true;
                    txtNombreModificar.Enabled = true;
                    txtUsuarioModificar.Enabled = true;
                    btnLimpiarModificar.Enabled = true;
                    btnModificar.Enabled = true;
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

        private void txtIdentidadModificar_TextChanged(object sender, EventArgs e)
        {
            txtIdentidadModificar.MaxLength = 13;
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }

        private void txtNombreCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Sololetras(e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        private void Modificar()
        {
            string Id_Empleado = txtIdentidadModificar.Text;
            string Nombre_Empleado = txtNombreModificar.Text;
            string Edad_Empleado = txtEdadModificar.Text;
            string Usuario = txtUsuarioModificar.Text;
            bool IsExist = false;
            SqlCommand sql = new SqlCommand("select * from Empleados Where Usuario = '" + Usuario + "' or Id_Empleado='" + Id_Empleado + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = sql.ExecuteReader();
            if (sdr.Read())
            {
                Id_Empleado = sdr.GetString(0);
                Usuario = sdr.GetString(3);
                IsExist = true;
            }
            Conexion.Obtenerconexion().Close();
            if (IsExist)
            {
                if (Id_Empleado.Equals(txtIdentidadModificar.Text))
                {
                    MessageBox.Show("Identidad de Empleado ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Usuario.Equals(txtUsuarioModificar.Text))
                {
                    MessageBox.Show("Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtIdentidadModificar.Text == "" && txtNombreModificar.Text == "" && txtEdadModificar.Text == "" && txtUsuarioModificar.Text == "" && cmbPuestoModificar.Text == "" && cmbEstadoModificar.Text == "")
                {
                    MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cmbPuestoModificar.Text == "1 - Gerente" && cmbEstadoModificar.Text == "1 - Activo")
                    {
                        int Cod_Puesto = 1;
                        int Cod_Estado = 1;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Id_Empleado='" + Id_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad_Empleado='" + Edad_Empleado + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "' Where Id_Empleado='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (cmbPuestoModificar.Text == "1 - Gerente" && cmbEstadoModificar.Text == "2 - Inactivo")
                    {
                        int Cod_Puesto = 1;
                        int Cod_Estado = 2;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Id_Empleado='" + Id_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad_Empleado='" + Edad_Empleado + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "'Where Id_Empleado='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Usuario no pudo ser actualizado", "Actualizacion No Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (cmbPuestoModificar.Text == "2 - Cajero" && cmbEstadoModificar.Text == "1 - Activo")
                    {
                        int Cod_Puesto = 2;
                        int Cod_Estado = 1;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Id_Empleado='" + Id_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad_Empleado='" + Edad_Empleado + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "' Where Id_Empleado='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (cmbPuestoModificar.Text == "2 - Cajero" && cmbEstadoModificar.Text == "2 - Inactivo")
                    {
                        int Cod_Puesto = 2;
                        int Cod_Estado = 2;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Id_Empleado='" + Id_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad_Empleado='" + Edad_Empleado + "',Usuario ='" + Usuario + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "'Where Id_Empleado='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Usuario no pudo ser actualizado", "Actualizacion No Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (cmbPuestoModificar.Text == "3 - Chofer" && cmbEstadoModificar.Text == "1 - Activo")
                    {
                        int Cod_Puesto = 3;
                        int Cod_Estado = 1;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Id_Empleado='" + Id_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad_Empleado='" + Edad_Empleado + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "' Where Id_Empleado='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (cmbPuestoModificar.Text == "3 - Chofer" && cmbEstadoModificar.Text == "2 - Inactivo")
                    {
                        int Cod_Puesto = 3;
                        int Cod_Estado = 2;
                        SqlCommand update = new SqlCommand(@"Update Empleados Set Id_Empleado='" + Id_Empleado + "',Nombre_Empleado='" + Nombre_Empleado + "',Edad_Empleado='" + Edad_Empleado + "',Cod_Puesto='" + Cod_Puesto + "', Cod_Estado='" + Cod_Estado + "'Where Id_Empleado='" + txtIDBusqueda.Text + "'", Conexion.Obtenerconexion());
                        update.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado con Exito.", "Actualizacion Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("Empleado(a) no pudo ser actualizado", "Actualizacion No Realizada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void cmbPuestoModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuestoModificar.Text == "3 - Chofer")
            {
                txtUsuarioModificar.Enabled = false;
            }
            else
            {
                txtUsuarioModificar.Enabled = true;
            }
        }

        private void txtUsuarioModificar_TextChanged_2(object sender, EventArgs e)
        {
            txtUsuarioModificar.MaxLength = 25;
        }

        private void cmbEstadoModificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
        private void Eliminar()
        {
            string Id_Empleado = txtIDEliminar.Text;
            bool IsExist = false;
            SqlCommand cmd = new SqlCommand("select * from Empleados where Id_Empleado ='" + txtIDEliminar.Text + "'", Conexion.Obtenerconexion());
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Id_Empleado = sdr.GetString(0);
                IsExist = true;
            }
            if (IsExist)
            {
                if (Id_Empleado.Equals(txtIDEliminar.Text))
                {
                    SqlCommand command = new SqlCommand("Delete From Empleados Where Id_Empleado ='" + Id_Empleado + "'", Conexion.Obtenerconexion());
                    SqlCommand sqlCommand = new SqlCommand("Delete From Respuestas Where Id_Empleado = '" + Id_Empleado + "'", Conexion.Obtenerconexion());
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

        private void txtIdentidad_MouseDown(object sender, MouseEventArgs e)
        {
            Clipboard.Clear();
        }

        private void txtIDEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.Solonumeros(e);
        }
    }
}
