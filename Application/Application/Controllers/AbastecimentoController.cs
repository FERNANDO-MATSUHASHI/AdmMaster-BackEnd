using Application.Service.Application;
using Application.Service.Interface;
using Domain.Entites;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbastecimentoController : ControllerBase
    {
        private readonly IAbastecimentoApplication _abastecimentoApplication;

        public AbastecimentoController(IAbastecimentoApplication abastecimentoApplication)
        {
            _abastecimentoApplication = abastecimentoApplication;
        }

        [HttpGet]
        public IActionResult GetAbastecimentos()
        {
            try
            {
                var abastecimentos = _abastecimentoApplication.GetAbastecimentos();
                return Ok(abastecimentos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAbastecimentoById(int id)
        {
            try
            {
                var abastecimento = _abastecimentoApplication.GetAbastecimentoById(id);
                return Ok(abastecimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertAbastecimento(AbastecimentoViewModel abastecimentoViewModel)
        {
            try
            {
                _abastecimentoApplication.InsertAbastecimento(abastecimentoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAbastecimento(int id, AbastecimentoViewModel abastecimentoViewModel)
        {
            try
            {
                _abastecimentoApplication.UpdateAbastecimento(id, abastecimentoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbastecimento(int id)
        {
            try
            {
                _abastecimentoApplication.DeleteAbastecimento(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Abastecimento/{gerenteId}")]
        public IActionResult GetAbastecimentoGerenteById(int gerenteId)
        {
            try
            {
                var abastecimento = _abastecimentoApplication.GetAbastecimentoGerenteById(gerenteId);
                return Ok(abastecimento);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
