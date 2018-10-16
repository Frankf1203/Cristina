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
    public class Ciudades
    {
        SqlDataReader dr;
        public void llenarItems(ComboBox cb)
        {

            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {

                try
                {
                    SqlCommand comando = new SqlCommand("select Nombre_Ciudad from Ciudades", conexi);
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        cb.Items.Add(dr["Nombre_Ciudad"].ToString());
                    }
                    cb.SelectedIndex = 0;
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se lleno el ComboBox: " + ex.ToString());
                }


            }
        }
    }
}

