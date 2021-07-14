using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace claseServicio.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ClientesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {

            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public int Get()
        {
            return 1;
        }


        [HttpPost]
        [Authorize]
        public string Filtrar(string user, string password)
        {
            return "1";          
        }

        
    }
}
