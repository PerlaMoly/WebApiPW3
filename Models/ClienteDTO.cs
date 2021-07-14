using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace claseServicio.Models
{
    public class ClienteDTO
    {
        public int IdCliente { get; set; }

        public int Numero { get; set; }

        public String Nombre { get; set; }

        public String Direccion { get; set; }

        public String Telefono { get; set; }
    }
}
