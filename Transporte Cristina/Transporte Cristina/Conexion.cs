using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Transporte_Cristina
{
    class Conexion
    {
        public string conect;
        protected SqlConnection connection;
        public Conexion()
        {
            this.conect = (@"Data Source=.\SQLEXPRESS;Initial Catalog=EncomiendaCristinaBD;Integrated Security=True");
            this.connection = new SqlConnection(this.conect);
        }

        public static SqlConnection Obtenerconexion()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=EncomiendaCristinaBD;Integrated Security=True");
            conexion.Open();
            return conexion;

        }
        public DataTable tabla(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = new SqlCommand(sql, Conexion.Obtenerconexion());
            da.Fill(ds);
            dt = ds.Tables[0];
            return dt;
        }

       

    }

}