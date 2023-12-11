using Application.Service.Application;
using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaturaController : ControllerBase
    {
        public readonly IViaturaApplication _viaturaApplication;

        public ViaturaController(IViaturaApplication viaturaApplication)
        {
            _viaturaApplication = viaturaApplication;
        }

        [HttpGet]
        public IActionResult GetViaturas()
        {
            try
            {
                var viaturas = _viaturaApplication.GetViaturas();
                return Ok(viaturas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetViaturaById(int id)
        {
            try
            {
                var viatura = _viaturaApplication.GetViaturaById(id);
                return Ok(viatura);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertViatura(ViaturaViewModel viaturaViewModel)
        {
            try
            {
                _viaturaApplication.InsertViatura(viaturaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateViatura(int id, ViaturaViewModel viaturaViewModel)
        {
            try
            {
                _viaturaApplication.UpdateViatura(id, viaturaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteViatura(int id)
        {
            try
            {
                _viaturaApplication.DeleteViatura(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Viaturas/{gerenteId}")]
        public IActionResult GetViaturasByGerenteId(int gerenteId)
        {
            try
            {
                var viaturas = _viaturaApplication.GetViaturasByGerenteId(gerenteId);
                return Ok(viaturas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
