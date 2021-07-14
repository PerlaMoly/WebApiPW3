using claseServicio.Models;
using claseServicio.Servicios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace claseServicio.Controllers
{
    [ApiController]
    // [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly _20211CTPContext _dBcontext;
        private LoginServicio _loginServicio;
        private readonly TokenServicio _tokenServicio;
        private readonly IConfiguration _configuration;
        private ResponseUsuario _responseUsuario;

        public AuthController(IConfiguration config)
        {
            //_dBcontext = dBcontext;
            _configuration = config;
            _dBcontext = new _20211CTPContext();
            _loginServicio = new LoginServicio(_dBcontext);
            _tokenServicio = new TokenServicio();
            _responseUsuario = new ResponseUsuario();

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/v1/[controller]/Login")]
        public ResponseUsuario Login(Usuario user)
        {
            _loginServicio.Ingresar(user.Email, user.Password, out Usuario usuarioSalida);
            if (usuarioSalida != null)
            {
                string tokengenerado = _tokenServicio.generarToken(usuarioSalida, _configuration);
                _responseUsuario.Email = usuarioSalida.Email;
                _responseUsuario.IdUsuario = usuarioSalida.IdUsuario;
                _responseUsuario.Nombre = usuarioSalida.Nombre;
                _responseUsuario.Apellido = usuarioSalida.Apellido;
                _responseUsuario.FechaNacimiento = usuarioSalida.FechaNacimiento;
                _responseUsuario.Token = tokengenerado;

                // var updatedCustomer = JsonConvert.DeserializeObject(salida);
            }
            return _responseUsuario;
        }


        [HttpPost]
        [Authorize]
        [Route("api/v1/[controller]/Logout")]
        public object Logout(int idUsuario)
        {
            return "{ }";
        }

    }
}
