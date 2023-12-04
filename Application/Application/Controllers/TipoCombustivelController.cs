using Application.Service.Interface;
using Domain.Entites;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCombustivelController : ControllerBase
    {
        private readonly ITipoCombustivelApplication _tipoCombustivelApplication;

        public TipoCombustivelController(ITipoCombustivelApplication tipoCombustivelApplication)
        {
            _tipoCombustivelApplication = tipoCombustivelApplication;
        }

        [HttpGet]
        public IActionResult GetTipoCombustiveis()
        {
            try
            {
                var tipoCombustiveis = _tipoCombustivelApplication.GetTipoCombustiveis();
                return Ok(tipoCombustiveis);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoCombustivelById(int id)
        {
            try
            {
                var tipoCombustivel = _tipoCombustivelApplication.GetTipoCombustivelById(id);
                return Ok(tipoCombustivel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertTipoCombustivel(TipoCombustivelViewModel tipoCombustivelViewModel)
        {
            try
            {
                _tipoCombustivelApplication.InsertTipoCombustivel(tipoCombustivelViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTipoCombustivel(int id, TipoCombustivelViewModel tipoCombustivelViewModel)
        {
            try
            {
                _tipoCombustivelApplication.UpdateTipoCombustivel(id, tipoCombustivelViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTipoCombustivel(int id)
        {
            try
            {
                _tipoCombustivelApplication.DeleteTipoCombustivel(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
