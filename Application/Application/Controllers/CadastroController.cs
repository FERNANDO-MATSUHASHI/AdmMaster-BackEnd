using Application.Service.Interface;
using Domain.Entites;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroUserController : ControllerBase
    {
        private readonly ICadastroUserApplication _cadUserApplication;

        public CadastroUserController(ICadastroUserApplication cadUserApplication)
        {
            _cadUserApplication = cadUserApplication;
        }

        [HttpGet]
        public IActionResult GetUser()
        {
            try
            {
                var users = _cadUserApplication.GetUser();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = _cadUserApplication.GetUserById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertUser(Usuario usuario)
        {
            try
            {
                _cadUserApplication.InsertUser(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, Usuario user)
        {
            try
            {
                _cadUserApplication.UpdateUser(id, user);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _cadUserApplication.DeleteUser(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
