using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaturaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetViatura()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetViaturaById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertViatura(Viatura viatura)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateViatura(Viatura viatura)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteViatura(Viatura viatura)
        {
            return Ok();
        }
    }
}
