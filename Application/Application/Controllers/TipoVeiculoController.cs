using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoVeiculoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTipoVeiculo()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoVeiculoById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteTipoVeiculo(Tipo_Veiculo tipoVeiculo)
        {
            return Ok();
        }
    }
}
