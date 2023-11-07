using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComissaoController : ControllerBase
    {
        private readonly IComissaoApplication _comissaoApplication;

        public ComissaoController(IComissaoApplication comissaoApplication)
        {
            _comissaoApplication = comissaoApplication;
        }

        [HttpGet("{id}")]
        public IActionResult GetComissao(ComissaoViewModel comissaoViewModel)
        {
            try
            {
                var comissao = _comissaoApplication.GetComissao(comissaoViewModel);
                return Ok(comissao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
