using Domain.ViewModel;
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
        public IActionResult InsertNivel(NivelViewModel nivelViewModel)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateNivel(NivelViewModel nivelViewModel)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteNivel(NivelViewModel nivelViewModel)
        {
            return Ok();
        }
    }
}