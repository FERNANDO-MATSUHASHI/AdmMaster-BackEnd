using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetVeiculo()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVeiculoById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertVeiculo(Veiculo veiculo)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVeiculo(Veiculo veiculo)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteVeiculo(Veiculo veiculo)
        {
            return Ok();
        }
    }
}
