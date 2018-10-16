using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte_Cristina
{
    public class clientes
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }


        public clientes() { }

        public clientes(string ClieId, string ClieNombre, int ClieTelefono)
        {
            this.id = ClieId;
            this.nombre = ClieNombre;
            this.telefono = ClieTelefono;
        }


    }
}
