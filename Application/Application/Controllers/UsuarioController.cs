using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioApplication _usuarioApplication;
        protected readonly IHttpContextAccessor _httpContextAccessor;
        protected JwtSecurityToken? _token;

        public UsuarioController(IUsuarioApplication usuarioApplication, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _usuarioApplication = usuarioApplication;
            var token = _httpContextAccessor.HttpContext?.Request.Headers["Authorization"].ToString();
            if (!string.IsNullOrEmpty(token))
                _token = new JwtSecurityToken();
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            try
            {
                if (_token != null)
                {
                    var usuarioIdStr = _token.Claims.FirstOrDefault(c => c.Type == "UsarId")?.Value;
                    //if (!string.IsNullOrEmpty(usuarioIdStr))
                    //    var teste = Convert.ToInt64(usuarioIdStr);
                }

                var usuarios = _usuarioApplication.GetUsuarios();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuarioById(int id)
        {
            try
            {
                var usuario = _usuarioApplication.GetUsuarioById(id);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertUsuario(UsuarioViewModel usuarioViewModel)
        {
            try
            {
                _usuarioApplication.InsertUsuario(usuarioViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, UsuarioViewModel usuarioViewModel)
        {
            try
            {
                _usuarioApplication.UpdateUsuario(id, usuarioViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(int id)
        {
            try
            {
                _usuarioApplication.DeleteUsuario(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Colaboradores/{gerenteId}")]
        public IActionResult GetColaboradores(int gerenteId)
        {
            try
            {
                var colaboradores = _usuarioApplication.GetColaboradores(gerenteId);
                return Ok(colaboradores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            try
            {
                _usuarioApplication.Login(loginViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
