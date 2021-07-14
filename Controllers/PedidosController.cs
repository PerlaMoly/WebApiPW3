using Microsoft.AspNetCore.Mvc;
using claseServicio.Models;
using claseServicio.Servicios;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using claseServicio.Requests;

namespace claseServicio.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly _20211CTPContext _dBcontext;
        private PedidosServicio _pedidosServicio;
        private readonly IConfiguration _configuration;

        public PedidosController(IConfiguration config)
        {
            //_dBcontext = dBcontext;
            _configuration = config;
            _dBcontext = new _20211CTPContext();
            _pedidosServicio = new PedidosServicio(_dBcontext);
        }

        [HttpPost]
        [Route("Buscar")]
        public ResponsePedidos Buscar([FromBody] PedidosRequest request)
        {
            return _pedidosServicio.Buscar(request.IdCliente, request.IdEstado);
        }


        [HttpPost]
        [Route("Guardar")]
        public string Guardar(string user, string password)
        {
            return "1";          
        }

        
    }
}
