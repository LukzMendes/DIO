using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models.Usuarios;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginWebModelInput loginWebModellInput)
        
        {
            return Ok(loginWebModellInput);
        }

        [HttpGet]
        [Route("Registrar")]
        public IActionResult Registrar(RegistroWebModelInput registroWebModelInput)

        {
            return Created("", registroWebModelInput);

            }
        }
}
