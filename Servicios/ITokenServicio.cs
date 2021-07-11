using Microsoft.Extensions.Configuration;
using claseServicio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace claseServicio.Servicios
{
    interface ITokenServicio
    {
        public string generarToken(Usuario dbUsuario, IConfiguration config);
    }
}
