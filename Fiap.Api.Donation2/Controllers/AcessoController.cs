using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.Donation2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AcessoController : ControllerBase
    {
        [HttpGet]
        [Route("Anonimo")]
        public string Anonimo()
        {
            return "Anonimo";
        }

        [HttpGet]
        [Route("Autenticado")]
        public string Autenticado()
        {
            return "Autenticado";
        }

        [HttpGet]
        [Route("admin")]
        public string Admin()
        {
            return "Admin";
        }


        [HttpGet]
        [Route("Operador")]
        public string Operador()
        {
            return "Operador";
        }

        [HttpGet]
        [Route("revisor")]
        public string Revisor()
        {
            return "Revisor";
        }
    }
}
