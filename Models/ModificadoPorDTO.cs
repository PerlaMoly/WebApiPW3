using System;
using System.Collections.Generic;

#nullable disable

namespace claseServicio.Models
{
    public partial class ModificadoPorDTO
    {
        public string Email { get; set; }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
    }
}
