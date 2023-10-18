using Domain.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServicoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTipoServico()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoServicoById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult InsertTipoServico(Tipo_Servico tipoServico)
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTipoServico(Tipo_Servico tipoServico)
        {
            return Ok();
        }

        [HttpDelete()]
        public IActionResult DeleteTipoServico(Tipo_Servico tipoServico)
        {
            return Ok();
        }
    }
}
