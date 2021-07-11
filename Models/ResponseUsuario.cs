using System;
using System.Collections.Generic;

#nullable disable

namespace claseServicio.Models
{
    public partial class ResponseUsuario
    {
        public ResponseUsuario()
        {

        }

        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public string Token{ get; set; }

    }
}
