using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        public readonly IVeiculoApplication _veiculoApplication;

        public VeiculoController(IVeiculoApplication veiculoApplication)
        {
            _veiculoApplication = veiculoApplication;
        }

        [HttpGet]
        public IActionResult GetVeiculos()
        {
            try
            {
                var veiculos = _veiculoApplication.GetVeiculos();
                return Ok(veiculos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetVeiculoById(int id)
        {
            try
            {
                var veiculo = _veiculoApplication.GetVeiculoById(id);
                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertVeiculo(VeiculoViewModel veiculoViewModel)
        {
            try
            {
                _veiculoApplication.InsertVeiculo(veiculoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVeiculo(int id, VeiculoViewModel veiculoViewModel)
        {
            try
            {
                _veiculoApplication.UpdateVeiculo(id, veiculoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVeiculo(int id)
        {
            try
            {
                _veiculoApplication.DeleteVeiculo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
