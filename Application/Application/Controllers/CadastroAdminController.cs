using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroAdminController : ControllerBase
    {
        private readonly ICadastroAdminApplication _cadastroAdminApplication;
        public string PublicKey = "adminAdmMaster";

        public CadastroAdminController(ICadastroAdminApplication cadastroAdminApplication)
        {
            _cadastroAdminApplication = cadastroAdminApplication;
        }

        [HttpPost("CadastrarNivel/{publicKey}")]
        public IActionResult InsertNivel(string publicKey, NivelViewModel nivelViewModel)
        {
            try
            {
                if (publicKey != PublicKey)
                    throw new Exception("Public Key errada.");

                _cadastroAdminApplication.InsertNivel(nivelViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CadastrarCargo/{publicKey}")]
        public IActionResult InsertCargo(string publicKey, CargoViewModel cargoViewModel)
        {
            try
            {
                if (publicKey != PublicKey)
                    throw new Exception("Public Key errada.");

                _cadastroAdminApplication.InsertCargo(cargoViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CadastrarUsuario/{publicKey}")]
        public IActionResult InsertUser(string publicKey, UsuarioViewModel usuarioViewModel)
        {
            try
            {
                if (publicKey != PublicKey)
                    throw new Exception("Public Key errada.");

                _cadastroAdminApplication.InsertUser(usuarioViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
