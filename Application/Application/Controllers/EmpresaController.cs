using Application.Service.Application;
using Application.Service.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaApplication _empresaApplication;

        public EmpresaController(IEmpresaApplication empresaApplication)
        {
            _empresaApplication = empresaApplication;
        }

        [HttpGet]
        public IActionResult GetEmpresas()
        {
            try
            {
                var empresas = _empresaApplication.GetEmpresas();
                return Ok(empresas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetEmpresaById(int id)
        {
            try
            {
                var empresa = _empresaApplication.GetEmpresaById(id);
                return Ok(empresa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertEmpresa(EmpresaViewModel empresaViewModel)
        {
            try
            {
                _empresaApplication.InsertEmpresa(empresaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmpresa(int id, EmpresaViewModel empresaViewModel)
        {
            try
            {
                _empresaApplication.UpdateEmpresa(id, empresaViewModel);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmpresa(int id)
        {
            try
            {
                _empresaApplication.DeleteEmpresa(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Empresas/{gerenteId}")]
        public IActionResult GetEmpresaGerenteById(int gerenteId)
        {
            try
            {
                var empresa = _empresaApplication.GetEmpresaGerenteById(gerenteId);
                return Ok(empresa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
