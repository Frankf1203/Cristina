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
    public class horarios
    {
        SqlDataReader dr;


        public void llenarItems(ComboBox cmb)
        {

            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {

                try
                {
                    SqlCommand comando = new SqlCommand("select f.Hora_Salida from Ciudades a inner join [Ciudades/Rutas] b on a.Cod_Ciudad = b.Cod_Ciudad inner join Rutas c on c.Cod_Ruta = b.Cod_Ruta inner join Buses_RutaH d on d.Cod_CiudadRuta = b.Cod_CiudadRuta inner join Buses e on e.No_Bus = d.No_Bus inner join Horarios f on f.Cod_Horario = d.Cod_Horario WHERE d.Cod_CiudadRuta = @codHoraCiudad ORDER BY cast(f.cod_Horario as int) asc", conexi);
                    comando.Parameters.AddWithValue("codHoraCiudad", compartir_datos.codHoraDestino);
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        cmb.Items.Add(dr["Hora_Salida"].ToString());
                    }
                    cmb.SelectedIndex = 0;
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
