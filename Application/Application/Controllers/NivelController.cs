using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NivelController : ControllerBase
    {
        private readonly INivelApplication _nivelApplication;

        public NivelController(INivelApplication nivelApplication)
        {
            _nivelApplication = nivelApplication;
        }

        [HttpGet]
        public IActionResult GetNivel()
        {
            try
            {
                var niveis = _nivelApplication.GetNivel();
                return Ok(niveis);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetNivelById(int id)
        {
            try
            {
                var nivel = _nivelApplication.GetNivelById(id);
                return Ok(nivel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertNivel(NivelViewModel nivelViewModel)
        {
            try
            {
                _nivelApplication.InsertNivel(nivelViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateNivel(int id, NivelViewModel nivelViewModel)
        {
            try
            {
                _nivelApplication.UpdateNivel(id, nivelViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNivel(int id)
        {
            try
            {
                _nivelApplication.DeleteNivel(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}