using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsuario()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertUsuario(Usuario usuario)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUsuario(Usuario usuario)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteUsuario(Usuario usuario)
        {
            return Ok();
        }
    }
}
