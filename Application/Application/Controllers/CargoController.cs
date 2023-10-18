using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCargo()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertCargo(Cargo cargo)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCargo(Cargo cargo)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteCargo(Cargo cargo)
        {
            return Ok();
        }
    }
}
