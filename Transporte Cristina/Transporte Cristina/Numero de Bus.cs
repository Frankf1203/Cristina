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
    class Numero_de_Bus
    {
        SqlDataReader dr;
        public void NumeroBus(ComboBox Numero_bus)
        {

            using (SqlConnection conexi = Conexion.Obtenerconexion())
            {

                try
                {
                    SqlCommand comando = new SqlCommand("SELECT  e.No_Bus FROM Ciudades a inner join [Ciudades/Rutas] b on a.Cod_Ciudad = b.Cod_Ciudad inner join Rutas c on c.Cod_Ruta = b.Cod_Ruta inner join Buses_RutaH d on d.Cod_CiudadRuta = b.Cod_CiudadRuta inner join Buses e on e.No_Bus = d.No_Bus inner join Horarios f on f.Cod_Horario = d.Cod_Horario WHERE b.Cod_Ciudad = @codCiudad and f.Cod_Horario = @codHora", conexi);
                    //comando.Parameters.AddWithValue("codCiudad", compartir_datos.CodOrigen);
                    //comando.Parameters.AddWithValue("codHora", compartir_datos.CodHorario);
                    dr = comando.ExecuteReader();
                    while (dr.Read())
                    {
                        Numero_bus.Items.Add(dr["No_Bus"].ToString());
                    }
                    Numero_bus.SelectedIndex = 0;
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se lleno el textbox: " + ex.ToString());
                }


            }

        }

    }
}
