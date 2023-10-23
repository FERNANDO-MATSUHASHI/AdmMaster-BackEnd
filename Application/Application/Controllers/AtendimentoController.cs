using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtendimentoController : ControllerBase
    {
        private readonly IAtendimentoApplication _atendimentoApplication;

        public AtendimentoController(IAtendimentoApplication atendimentoApplication)
        {
            _atendimentoApplication = atendimentoApplication;
        }

        [HttpGet]
        public IActionResult GetAtendimento()
        {
            try
            {
                var atendimentos = _atendimentoApplication.GetAtendimento();
                return Ok(atendimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAtendimentoById(int id)
        {
            try
            {
                var atendimento = _atendimentoApplication.GetAtendimentoById(id);
                return Ok(atendimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertAtendimento(AtendimentoViewModel atendimentoViewModel)
        {
            try
            {
                _atendimentoApplication.InsertAtendimento(atendimentoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAtendimento(int id, AtendimentoViewModel atendimentoViewModel)
        {
            try
            {
                _atendimentoApplication.UpdateAtendimento(id, atendimentoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAtendimento(int id)
        {
            try
            {
                _atendimentoApplication.DeleteAtendimento(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
