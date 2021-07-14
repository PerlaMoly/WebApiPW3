using claseServicio.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace claseServicio.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientesController : ControllerBase
    {

        private readonly _20211CTPContext _dbContext;

        public ClientesController(_20211CTPContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Authorize]
        public List<ClienteDTO> ObtenerClientes()
        {
            return _dbContext.Clientes
               .Select(c => new ClienteDTO { IdCliente = c.IdCliente, Numero = c.Numero, Nombre = c.Nombre, Direccion = c.Direccion, Telefono = c.Telefono }).ToList(); ;
        }


        [HttpPost]
        [Authorize]
        public List<ClienteDTO> FiltroClientes(String filtro)
        {
            return _dbContext.Clientes
                .Where(f => f.Nombre.Contains(filtro))
               .Select(c => new ClienteDTO { IdCliente = c.IdCliente, Numero = c.Numero, Nombre = c.Nombre, Direccion = c.Direccion, Telefono = c.Telefono }).ToList(); ;
        }


    }
}
