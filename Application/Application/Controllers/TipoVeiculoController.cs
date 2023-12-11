using Application.Service.Application;
using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoVeiculoController : ControllerBase
    {
        private readonly ITipoVeiculoApplication _tipoVeiculoApplication;

        public TipoVeiculoController(ITipoVeiculoApplication tipoVeiculoApplication)
        {
            _tipoVeiculoApplication = tipoVeiculoApplication;
        }

        [HttpGet]
        public IActionResult GetTipoVeiculos()
        {
            try
            {
                var tipoVeiculos = _tipoVeiculoApplication.GetTipoVeiculos();
                return Ok(tipoVeiculos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoVeiculoById(int id)
        {
            try
            {
                var tipoVeiculo = _tipoVeiculoApplication.GetTipoVeiculoById(id);
                return Ok(tipoVeiculo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertTipoVeiculo(TipoVeiculoViewModel tipoVeiculoViewModel)
        {
            try
            {
                _tipoVeiculoApplication.InsertTipoVeiculo(tipoVeiculoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTipoVeiculo(int id, TipoVeiculoViewModel tipoVeiculoViewModel)
        {
            try
            {
                _tipoVeiculoApplication.UpdateTipoVeiculo(id, tipoVeiculoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTipoVeiculo(int id)
        {
            try
            {
                _tipoVeiculoApplication.DeleteTipoVeiculo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("TipoVeiculos/{gerenteId}")]
        public IActionResult GetTipoVeiculosByGerenteId(int gerenteId)
        {
            try
            {
                var tipoVeiculos = _tipoVeiculoApplication.GetTipoVeiculosByGerenteId(gerenteId);
                return Ok(tipoVeiculos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
