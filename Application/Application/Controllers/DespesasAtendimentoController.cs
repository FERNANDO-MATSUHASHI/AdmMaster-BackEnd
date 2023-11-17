using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasAtendimentoController : ControllerBase
    {
        private readonly IDespesasAtendimentoApplication _despesasApplication;

        public DespesasAtendimentoController(IDespesasAtendimentoApplication despesasApplication)
        {
            _despesasApplication = despesasApplication;
        }

        [HttpGet]
        public IActionResult GetDespesas()
        {
            try
            {
                var despesa = _despesasApplication.GetDespesas();
                return Ok(despesa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetDespesasByFilter")]
        public IActionResult GetDespesasByFilter(string? qru, DateTime? dataInicial, DateTime? dataFinal)
        {
            try
            {
                var despesas = _despesasApplication.GetDespesasByFilter(qru, dataInicial, dataFinal);
                return Ok(despesas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Viatura/{id}")]
        public IActionResult GetInfoViatura(int id)
        {
            try
            {
                var viatura = _despesasApplication.GetInfoViatura(id);
                return Ok(viatura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDespesasById(int id)
        {
            try
            {
                var despesa = _despesasApplication.GetDespesaById(id);
                return Ok(despesa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertDespesa(Despesas_AtendimentoViewModel despesaViewModel)
        {
            try
            {
                _despesasApplication.InsertDespesa(despesaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDespesa(int id, Despesas_AtendimentoViewModel despesaViewModel)
        {
            try
            {
                _despesasApplication.UpdateDespesa(id, despesaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDespesa(int id)
        {
            try
            {
                _despesasApplication.DeleteDespesa(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
