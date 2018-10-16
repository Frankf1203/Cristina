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
    class Clientes_BD
    {
        public static int Agregar(clientes addcliente)
        {
            int retornar = 0;

            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Clientes( Id_Cliente , Nombre_Cliente, Telefono) values ('{0}', '{1}','{2}')",
                addcliente.id, addcliente.nombre, addcliente.telefono), conexi);

                retornar = comando.ExecuteNonQuery();

                conexi.Close();

            }

            return retornar;
        }


        public void autoCompletar(TextBox identidadtxt)
        {
            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {
                SqlDataReader dr;

                try
                {
                    SqlCommand comando = new SqlCommand("select Id_Cliente from Clientes", conexi);
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        identidadtxt.AutoCompleteCustomSource.Add(dr["Id_Cliente"].ToString());
                    }
                    dr.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo autocompletar la Identidad: " + ex.ToString());
                }
            }
        }

        public int ClienteRegistrado(string Id_Cliente)
        {
            int contador = 0;

            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {
                SqlDataReader dr;
                try
                {
                    SqlCommand comando = new SqlCommand("select * from Clientes where Id_Cliente = @Id_Cliente", conexi);
                    comando.Parameters.AddWithValue("Id_Cliente", Id_Cliente);
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        contador++;
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
                }
                return contador;
            }
        }


        public void llenarTexBoxConsulta(string Id_Cliente, TextBox txtNombre, TextBox txttelefono)
        {
            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {
                SqlDataReader dr;
                try
                {
                    SqlCommand comando = new SqlCommand("select * from Clientes where Id_Cliente = @Id_Cliente", conexi);
                    comando.Parameters.AddWithValue("Id_Cliente", Id_Cliente);
                    dr = comando.ExecuteReader();
                    if (dr.Read())
                    {
                        txtNombre.Text = dr["Nombre_Cliente"].ToString();
                        txttelefono.Text = dr["Telefono"].ToString();
                    }
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo llenar los campos: " + ex.ToString());
                }
            }

        }
    }
}

