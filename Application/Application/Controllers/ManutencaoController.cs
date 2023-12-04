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
    public class ManutencaoController : ControllerBase
    {
        private readonly IManutencaoApplication _manutencaoApplication;

        public ManutencaoController(IManutencaoApplication manutencaoApplication)
        {
            _manutencaoApplication = manutencaoApplication;
        }

        [HttpGet]
        public IActionResult GetManutencoes()
        {
            try
            {
                var manutencoes = _manutencaoApplication.GetManutencoes();
                return Ok(manutencoes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetManutencaoById(int id)
        {
            try
            {
                var manutencao = _manutencaoApplication.GetManutencaoById(id);
                return Ok(manutencao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertManutencao(ManutencaoViewModel manutencaoViewModel)
        {
            try
            {
                _manutencaoApplication.InsertManutencao(manutencaoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateManutencao(int id, ManutencaoViewModel manutencaoViewModel)
        {
            try
            {
                _manutencaoApplication.UpdateManutencao(id, manutencaoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteManutencao(int id)
        {
            try
            {
                _manutencaoApplication.DeleteManutencao(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Manutencao/{gerenteId}")]
        public IActionResult GetManutencaoGerenteById(int gerenteId)
        {
            try
            {
                var manutencao = _manutencaoApplication.GetManutencaoGerenteById(gerenteId);
                return Ok(manutencao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
