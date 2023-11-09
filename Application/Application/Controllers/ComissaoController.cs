using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        public IActionResult GetComissao([FromBody]ComissaoViewModel comissaoViewModel)
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
