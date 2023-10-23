using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : ControllerBase
    {
        private readonly ICargoApplication _cargoApplication;

        public CargoController(ICargoApplication cargoApplication)
        {
            _cargoApplication = cargoApplication;
        }

        [HttpGet]
        public IActionResult GetCargo()
        {
            try
            {
                var cargos = _cargoApplication.GetCargo();
                return Ok(cargos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoById(int id)
        {
            try
            {
                var cargo = _cargoApplication.GetCargoById(id);
                return Ok(cargo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertCargo(CargoViewModel cargoViewModel)
        {
            try
            {
                _cargoApplication.InsertCargo(cargoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCargo(int id, CargoViewModel cargoViewModel)
        {
            try
            {
                _cargoApplication.UpdateCargo(id, cargoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCargo(int id)
        {
            try
            {
                _cargoApplication.DeleteCargo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
