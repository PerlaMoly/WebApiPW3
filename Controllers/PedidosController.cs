using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace claseServicio.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PedidosController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {

            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PedidosController> _logger;

        public PedidosController(ILogger<PedidosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Buscar()
        {
            return 1;
        }


        [HttpPost]
        public string Guardar(string user, string password)
        {
            return "1";          
        }

        
    }
}
