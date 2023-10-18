using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NivelController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNivel()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetNivelById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertNivel(Nivel nivel)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateNivel(Nivel nivel)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteNivel(Nivel nivel)
        {
            return Ok();
        }
    }
}