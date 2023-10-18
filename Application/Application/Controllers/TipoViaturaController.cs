using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoViaturaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTipoViatura()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoViaturaById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertTipoViatura(Tipo_Viatura tipoViatura)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTipoViatura(Tipo_Viatura tipoViatura)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteTipoViatura(Tipo_Viatura tipoViatura)
        {
            return Ok();
        }
    }
}
