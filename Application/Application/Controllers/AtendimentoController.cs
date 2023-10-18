using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAtendimento()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAtendimentoById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertAtendimento(Atendimento atendimento)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAtendimento(Atendimento atendimento)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteAtendimento(Atendimento atendimento)
        {
            return Ok();
        }
    }
}
