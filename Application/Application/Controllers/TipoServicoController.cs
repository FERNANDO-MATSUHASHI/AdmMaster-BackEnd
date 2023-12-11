using Application.Service.Application;
using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServicoController : ControllerBase
    {
        private readonly ITipoServicoApplication _tipoServicoApplication;

        public TipoServicoController(ITipoServicoApplication tipoServicoApplication)
        {
            _tipoServicoApplication = tipoServicoApplication;
        }

        [HttpGet]
        public IActionResult GetTipoServicos()
        {
            try
            {
                var tipoServicos = _tipoServicoApplication.GetTipoServicos();
                return Ok(tipoServicos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoServicoById(int id)
        {
            try
            {
                var tipoServico = _tipoServicoApplication.GetTipoServicoById(id);
                return Ok(tipoServico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertTipoServico(TipoServicoViewModel tipoServicoViewModel)
        {
            try
            {
                _tipoServicoApplication.InsertTipoServico(tipoServicoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTipoServico(int id, TipoServicoViewModel tipoServicoViewModel)
        {
            try
            {
                _tipoServicoApplication.UpdateTipoServico(id, tipoServicoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTipoServico(int id)
        {
            try
            {
                _tipoServicoApplication.DeleteTipoServico(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("TipoServicos/{gerenteId}")]
        public IActionResult GetTipoServicosByGerenteId(int gerenteId)
        {
            try
            {
                var tipoServicos = _tipoServicoApplication.GetTipoServicosByGerenteId(gerenteId);
                return Ok(tipoServicos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
