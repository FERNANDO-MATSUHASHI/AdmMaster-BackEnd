using Application.Service.Application;
using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoViaturaController : ControllerBase
    {
        private readonly ITipoViaturaApplication _tipoViaturaApplication;

        public TipoViaturaController(ITipoViaturaApplication tipoViaturaApplication)
        {
            _tipoViaturaApplication = tipoViaturaApplication;
        }

        [HttpGet]
        public IActionResult GetTipoViaturas()
        {
            try
            {
                var tipoViaturas = _tipoViaturaApplication.GetTipoViaturas();
                return Ok(tipoViaturas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoViaturaById(int id)
        {
            try
            {
                var tipoViatura = _tipoViaturaApplication.GetTipoViaturaById(id);
                return Ok(tipoViatura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertTipoViatura(TipoViaturaViewModel tipoViaturaViewModel)
        {
            try
            {
                _tipoViaturaApplication.InsertTipoViatura(tipoViaturaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTipoViatura(int id, TipoViaturaViewModel tipoViaturaViewModel)
        {
            try
            {
                _tipoViaturaApplication.UpdateTipoViatura(id, tipoViaturaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTipoViatura(int id)
        {
            try
            {
                _tipoViaturaApplication.DeleteTipoViatura(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("TipoViaturas/{gerenteId}")]
        public IActionResult GetTipoViaturasByGerenteId(int gerenteId)
        {
            try
            {
                var tipoViaturas = _tipoViaturaApplication.GetTipoViaturasByGerenteId(gerenteId);
                return Ok(tipoViaturas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
